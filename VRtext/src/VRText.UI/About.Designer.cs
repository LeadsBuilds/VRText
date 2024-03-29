﻿
namespace VRText.src.VRText.UI
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.developerLabel = new System.Windows.Forms.Label();
            this.inspirationLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.additionsLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // developerLabel
            // 
            this.developerLabel.AutoSize = true;
            this.developerLabel.BackColor = System.Drawing.Color.Transparent;
            this.developerLabel.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.developerLabel.Location = new System.Drawing.Point(87, 6);
            this.developerLabel.Name = "developerLabel";
            this.developerLabel.Size = new System.Drawing.Size(192, 20);
            this.developerLabel.TabIndex = 2;
            this.developerLabel.Text = "Developed by LeadsBuilds ";
            this.developerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.developerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // inspirationLabel
            // 
            this.inspirationLabel.AutoSize = true;
            this.inspirationLabel.BackColor = System.Drawing.Color.Transparent;
            this.inspirationLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspirationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inspirationLabel.Location = new System.Drawing.Point(52, 163);
            this.inspirationLabel.Name = "inspirationLabel";
            this.inspirationLabel.Size = new System.Drawing.Size(257, 75);
            this.inspirationLabel.TabIndex = 3;
            this.inspirationLabel.Text = " We were born to try\r\nTo see each other through\r\nTo know and love ourselves and o" + "thers as well\r\nIs the most difficult and meaningful work\r\nWe\'ll ever do";
            this.inspirationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nameLabel.Location = new System.Drawing.Point(236, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.nameLabel.Size = new System.Drawing.Size(86, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "AKA Downluck";
            // 
            // additionsLabel
            // 
            this.additionsLabel.AutoSize = true;
            this.additionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.additionsLabel.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.additionsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.additionsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.additionsLabel.Location = new System.Drawing.Point(245, 45);
            this.additionsLabel.Name = "additionsLabel";
            this.additionsLabel.Padding = new System.Windows.Forms.Padding(3);
            this.additionsLabel.Size = new System.Drawing.Size(117, 19);
            this.additionsLabel.TabIndex = 4;
            this.additionsLabel.Text = "Additions by Myrkur";
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.BackColor = System.Drawing.Color.Transparent;
            this.translationLabel.Font = new System.Drawing.Font("Malgun Gothic", 8F);
            this.translationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.translationLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.translationLabel.Location = new System.Drawing.Point(12, 26);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Padding = new System.Windows.Forms.Padding(3);
            this.translationLabel.MaximumSize = new System.Drawing.Size(92, 100);
            this.translationLabel.AutoSize = true;
            this.translationLabel.TabIndex = 4;
            this.translationLabel.Text = "Translations by Myrkur\nDexElDino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VRText.Properties.Resources.shoot;
            this.pictureBox1.Location = new System.Drawing.Point(110, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VRText.Properties.Resources.shootgif;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 250);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(364, 247);
            this.ControlBox = false;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.additionsLabel);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.inspirationLabel);
            this.Controls.Add(this.developerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Deactivate += new System.EventHandler(this.AboutForm_Deactivate);
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.Label inspirationLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label additionsLabel;
        private System.Windows.Forms.Label translationLabel;
    }
}