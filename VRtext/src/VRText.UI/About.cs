using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WMPLib;

namespace VRText.src.VRText.UI
{
    public partial class AboutForm : Form
    {
        private WindowsMediaPlayer wmp;
        public AboutForm()
        {
            InitializeComponent();

            this.wmp = initializeMediaPlayer();
            this.wmp.controls.play();

            pictureBox2.Controls.Add(developerLabel);
            pictureBox2.Controls.Add(inspirationLabel);
            pictureBox2.Controls.Add(nameLabel);
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Location = new System.Drawing.Point(123, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AboutForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
            this.wmp.controls.stop();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

            

        }

        private WindowsMediaPlayer initializeMediaPlayer()
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VRText.Resources.acoustic.mp3");
            string temppath = Path.GetTempPath() + "\\tempaacoustsongVRTEXTAPP230920220s2d1h5g1jh5g9w8e.mp3";

            if (File.Exists(temppath))
            {
                wmp.URL = temppath;
                wmp.settings.volume = 80;
                wmp.settings.setMode("loop", true);

                return wmp;
            }

            using (Stream output = new FileStream(temppath, FileMode.Create))
            {
                byte[] buffer = new byte[1800000];
                int read;

                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, read);
                }
            }
            wmp.URL = temppath;
            wmp.settings.volume = 80;
            wmp.settings.setMode("loop", true);

            return wmp;
        }

    }
}
