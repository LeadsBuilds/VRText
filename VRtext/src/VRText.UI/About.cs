using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRText.src.VRText.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            pictureBox2.Controls.Add(label1);
            pictureBox2.Controls.Add(label2);
            pictureBox2.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new System.Drawing.Point(123, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
