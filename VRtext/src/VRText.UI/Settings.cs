using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using SharpOSC;
using VRText.Config;
using VRText.Utils;
using System.Threading;
using System.Net.Sockets;

namespace VRText.src.VRText.UI
{
    public partial class Settings : Form
    {
        private MainForm mainForm;
        public Settings(MainForm parent)
        {
            this.mainForm = parent;
            InitializeComponent();
            InitializeSettings();
            configControls();
        }

        private void InitializeSettings()
        {

            serverAddressInput.Text = OSC.getAddress();
            portInput.Text = OSC.getAddressPort().ToString();
        }

        private void languageOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lang = languageOptions.Text;
            string variant;

            switch(lang)
            {
                case "English":
                    variant = "en-US";
                    break;
                case "Português do Brasil":
                    variant = "pt-BR";
                    break;
                default:
                    variant = "pt-BR";
                    break;
            }

            this.mainForm.lang = new Lang(variant).getCurrentLanguage();
            this.mainForm.setComponentLanguage();
            this.mainForm.language = variant;
        }

        private void configControls()
        {
            string currentLanguage = this.mainForm.language;
            Console.WriteLine(currentLanguage);

            if (currentLanguage == "en-US")
            {
                languageOptions.SelectedItem = "English";

                return;
            }

            if (currentLanguage == "pt-BR")
            {
                languageOptions.SelectedItem = "Português do Brasil";

                return;
            }

        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            string address = serverAddressInput.Text;
            int port = int.Parse(portInput.Text);
            var delay = new Interval();
            var inputMessage = new OscMessage(OSC.getTypingEndPoint(), true);
            var sendMessage = new UDPSender(address, port);

            sendMessage.Send(inputMessage);
            testLabel.Visible = true;
            testLabel.Text = "Test sent over: " + address + ":" + port;
            OSC.setNewAddress(address, portInput.Text);
            delay.setTimeout(() =>
            {
                inputMessage = new OscMessage(OSC.getTypingEndPoint(), false);
                sendMessage.Send(inputMessage);
            }, 2000);
        }
    }
}
