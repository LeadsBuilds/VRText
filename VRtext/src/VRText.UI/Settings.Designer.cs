
namespace VRText.src.VRText.UI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.languageOptions = new System.Windows.Forms.ComboBox();
            this.SelectLanguageLabel = new System.Windows.Forms.Label();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.serverAddressInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.TextBox();
            this.OSCConnectionLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.SpotifyPrefixLabel = new System.Windows.Forms.Label();
            this.SpotifyPrefixInput = new System.Windows.Forms.TextBox();
            this.ResetSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // languageOptions
            // 
            this.languageOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.languageOptions.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.languageOptions.FormattingEnabled = true;
            this.languageOptions.Items.AddRange(new object[] {
            "English",
            "Português do Brasil",
            "Deutsch",
            "Italiano",
            "Français",
            "Norsk"
            });
            this.languageOptions.Location = new System.Drawing.Point(27, 102);
            this.languageOptions.Name = "languageOptions";
            this.languageOptions.Size = new System.Drawing.Size(153, 28);
            this.languageOptions.TabIndex = 19;
            this.languageOptions.SelectedIndexChanged += new System.EventHandler(this.languageOptions_SelectedIndexChanged);
            // 
            // SelectLanguageLabel
            // 
            this.SelectLanguageLabel.AutoSize = true;
            this.SelectLanguageLabel.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.SelectLanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.SelectLanguageLabel.Location = new System.Drawing.Point(26, 72);
            this.SelectLanguageLabel.Name = "SelectLanguageLabel";
            this.SelectLanguageLabel.Size = new System.Drawing.Size(77, 27);
            this.SelectLanguageLabel.TabIndex = 21;
            this.SelectLanguageLabel.Text = "Language";
            this.SelectLanguageLabel.UseCompatibleTextRendering = true;
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.testConnectionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.testConnectionButton.FlatAppearance.BorderSize = 2;
            this.testConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testConnectionButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.testConnectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.testConnectionButton.Location = new System.Drawing.Point(209, 208);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(97, 29);
            this.testConnectionButton.TabIndex = 22;
            this.testConnectionButton.Text = "Test & Save";
            this.testConnectionButton.UseMnemonic = false;
            this.testConnectionButton.UseVisualStyleBackColor = false;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // serverAddressInput
            // 
            this.serverAddressInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.serverAddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverAddressInput.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.serverAddressInput.ForeColor = System.Drawing.Color.White;
            this.serverAddressInput.Location = new System.Drawing.Point(210, 102);
            this.serverAddressInput.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.serverAddressInput.MaxLength = 144;
            this.serverAddressInput.Name = "serverAddressInput";
            this.serverAddressInput.Size = new System.Drawing.Size(188, 25);
            this.serverAddressInput.TabIndex = 23;
            this.serverAddressInput.Text = "Server address";
            this.serverAddressInput.WordWrap = false;
            // 
            // portInput
            // 
            this.portInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.portInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portInput.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Italic);
            this.portInput.ForeColor = System.Drawing.Color.White;
            this.portInput.Location = new System.Drawing.Point(210, 151);
            this.portInput.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.portInput.MaxLength = 144;
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(188, 25);
            this.portInput.TabIndex = 24;
            this.portInput.Text = "Port";
            this.portInput.WordWrap = false;
            // 
            // OSCConnectionLabel
            // 
            this.OSCConnectionLabel.AutoSize = true;
            this.OSCConnectionLabel.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.OSCConnectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.OSCConnectionLabel.Location = new System.Drawing.Point(209, 72);
            this.OSCConnectionLabel.Name = "OSCConnectionLabel";
            this.OSCConnectionLabel.Size = new System.Drawing.Size(188, 27);
            this.OSCConnectionLabel.TabIndex = 25;
            this.OSCConnectionLabel.Text = "OSC Connection Settings";
            this.OSCConnectionLabel.UseCompatibleTextRendering = true;
            // 
            // testLabel
            // 
            this.testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.testLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.testLabel.Location = new System.Drawing.Point(225, 184);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(161, 21);
            this.testLabel.TabIndex = 27;
            this.testLabel.Text = "Test sent over 127.0.0.1:8000";
            this.testLabel.UseCompatibleTextRendering = true;
            this.testLabel.Visible = false;
            // 
            // SpotifyPrefixLabel
            // 
            this.SpotifyPrefixLabel.AutoSize = true;
            this.SpotifyPrefixLabel.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.SpotifyPrefixLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.SpotifyPrefixLabel.Location = new System.Drawing.Point(26, 150);
            this.SpotifyPrefixLabel.Name = "SpotifyPrefixLabel";
            this.SpotifyPrefixLabel.Size = new System.Drawing.Size(101, 27);
            this.SpotifyPrefixLabel.TabIndex = 28;
            this.SpotifyPrefixLabel.Text = "Spotify Prefix";
            this.SpotifyPrefixLabel.UseCompatibleTextRendering = true;
            // 
            // SpotifyPrefixInput
            // 
            this.SpotifyPrefixInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SpotifyPrefixInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpotifyPrefixInput.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.SpotifyPrefixInput.ForeColor = System.Drawing.Color.White;
            this.SpotifyPrefixInput.Location = new System.Drawing.Point(27, 180);
            this.SpotifyPrefixInput.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.SpotifyPrefixInput.MaxLength = 30;
            this.SpotifyPrefixInput.Name = "SpotifyPrefixInput";
            this.SpotifyPrefixInput.Size = new System.Drawing.Size(153, 25);
            this.SpotifyPrefixInput.TabIndex = 29;
            this.SpotifyPrefixInput.Text = "Listening to: ";
            this.SpotifyPrefixInput.WordWrap = false;
            this.SpotifyPrefixInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpotifyPrefixInput_KeyUp);
            // 
            // ResetSettings
            // 
            this.ResetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ResetSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.ResetSettings.FlatAppearance.BorderSize = 2;
            this.ResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSettings.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.ResetSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.ResetSettings.Location = new System.Drawing.Point(324, 208);
            this.ResetSettings.Name = "ResetSettings";
            this.ResetSettings.Size = new System.Drawing.Size(73, 29);
            this.ResetSettings.TabIndex = 30;
            this.ResetSettings.Text = "Reset";
            this.ResetSettings.UseMnemonic = false;
            this.ResetSettings.UseVisualStyleBackColor = false;
            this.ResetSettings.Click += new System.EventHandler(this.ResetSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "2022 LeadsBuilds";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // GitHub
            // 
            this.GitHub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GitHub.AutoSize = true;
            this.GitHub.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.GitHub.LinkColor = System.Drawing.Color.LightGray;
            this.GitHub.Location = new System.Drawing.Point(222, 247);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(176, 16);
            this.GitHub.TabIndex = 33;
            this.GitHub.TabStop = true;
            this.GitHub.Text = "https://github.com/LeadsBuilds";
            this.GitHub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VRText.Properties.Resources.settings_header;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 50);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(410, 272);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetSettings);
            this.Controls.Add(this.SpotifyPrefixInput);
            this.Controls.Add(this.SpotifyPrefixLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.OSCConnectionLabel);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.serverAddressInput);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.SelectLanguageLabel);
            this.Controls.Add(this.languageOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VRText - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox languageOptions;
        private System.Windows.Forms.Label SelectLanguageLabel;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.TextBox serverAddressInput;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label OSCConnectionLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label SpotifyPrefixLabel;
        private System.Windows.Forms.TextBox SpotifyPrefixInput;
        private System.Windows.Forms.Button ResetSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel GitHub;
    }
}