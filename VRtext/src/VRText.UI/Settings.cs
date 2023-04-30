using System;
using System.Linq;
using System.Windows.Forms;
using VRText.Config;
using VRText.Utils;
using VRText.Spotify;
using VRText.Handlers;
using OscMessage = VRText.SharpOSC.OscMessage;
using UDPSender = VRText.SharpOSC.UDPSender;

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
            var loadSettings = SQLiteHandler.LoadSettings();

            if (loadSettings.Any())
            {
                var settingsValues = loadSettings[0];
                
                var serverAddress = settingsValues[0];
                var serverPort = settingsValues[1];
                var spotifyPrefix = settingsValues[2];
                var lang = settingsValues[3];

                var language = new Lang(lang).GetCurrentLanguage();
                if (language != null)
                {
                    mainForm.lang = language;
                    mainForm.language = lang;
                }
                
                mainForm.SetComponentLanguage(mainForm);
                mainForm.SetComponentLanguage(this);
                
                serverAddressInput.Text = serverAddress;
                portInput.Text = serverPort;
                SpotifyPrefixInput.Text = spotifyPrefix;

                SQLiteHandler.UpdateLanguageSettings(lang);
                SQLiteHandler.UpdateOSCSettings(serverAddress, serverPort);
            }

        }

        private void languageOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lang = languageOptions.Text;
            string variant;

            switch(lang)
            {
                case "English":
                    variant = "en-US";
                    break;
                case "Português do Brasil":
                    variant = "pt-BR";
                    break;
                case "Español":
                    variant = "es-419";
                    break;
                case "Deutsch":
                    variant = "de-DE";
                    break;
                case "Italiano":
                    variant = "it-IT";
                    break;
                case "Français":
                    variant = "fr-FR";
                    break;
                case "Norsk":
                    variant = "no-NO";
                    break;
                default:
                    MessageBox.Show("Invalid language or incomplete\nreverting to default");
                    variant = "en-US";
                    break;
            }
            
            var language = new Lang(variant).GetCurrentLanguage();
            if (language != null)
            {
                this.mainForm.lang = language;
            }
            this.mainForm.SetComponentLanguage(mainForm);
            this.mainForm.SetComponentLanguage(this);
            this.mainForm.language = variant;
            SQLiteHandler.UpdateLanguageSettings(variant);
        }

        private void configControls()
        {
            var currentLanguage = this.mainForm.language;
            Console.WriteLine(currentLanguage);

            switch (currentLanguage)
            {
                case "en-US":
                    languageOptions.SelectedItem = "English";

                    return;
                case "pt-BR":
                    languageOptions.SelectedItem = "Português do Brasil";

                    return;
                case "es-419":
                    languageOptions.SelectedItem = "Español";
                    return;
                case "de-DE":
                    languageOptions.SelectedItem = "Deutsch";

                    return;
                case "fr-FR":
                    languageOptions.SelectedItem = "Français";

                    return;
                case "no-NO":
                    languageOptions.SelectedItem = "Norsk";

                    return;
                case "it-IT":
                    languageOptions.SelectedItem = "Italiano";
                    break;
            }
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            var address = serverAddressInput.Text;
            var port = int.Parse(portInput.Text);

            if (!OSC.IsValidateIp(address))
            {
                new ErrorHandler().Show("Invalid IP Address", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, true);
                
                return;
            }
            
            if (port > 65535 || port <= 1024)
            {
                new ErrorHandler().Show("The specified port is out of range", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, true);
                
                return;
            }

            var delay = new Interval();
            var inputMessage = new OscMessage(OSC.GetTypingEndPoint(), true);
            var sendMessage = new UDPSender(address, port);

            sendMessage.Send(inputMessage);
            testLabel.Visible = true;
            testLabel.Text = "Test sent over: " + address + ":" + port;
            OSC.SetNewAddress(address, portInput.Text);
            delay.setTimeout(() =>
            {
                inputMessage = new OscMessage(OSC.GetTypingEndPoint(), false);
                sendMessage.Send(inputMessage);
            }, 2000);
        }

        private void ResetSettings_Click(object sender, EventArgs e)
        {
            var serverAddress = "127.0.0.1";
            var serverPort = "9000";

            OSC.SetNewAddress(serverAddress, serverPort);
            serverAddressInput.Text = serverAddress;
            portInput.Text = serverPort;
            testLabel.Text = "Default settings have been set.";

        }

        private void SpotifyPrefixInput_KeyUp(object sender, KeyEventArgs e)
        {
            string prefix = SpotifyPrefixInput.Text;
            SpotifyHandler.setPrefix(prefix);
            SQLiteHandler.UpdateSpotifyPrefix(prefix);
        }

        private void GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LeadsBuilds");
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }
    }
}
