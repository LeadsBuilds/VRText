
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
            this.languageOptions = new System.Windows.Forms.ComboBox();
            this.SettingsFormLabelSettings = new System.Windows.Forms.Label();
            this.SelectLanguageLabel = new System.Windows.Forms.Label();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.serverAddressInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
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
            "Português do Brasil"});
            this.languageOptions.Location = new System.Drawing.Point(27, 97);
            this.languageOptions.Name = "languageOptions";
            this.languageOptions.Size = new System.Drawing.Size(153, 28);
            this.languageOptions.TabIndex = 19;
            this.languageOptions.SelectedIndexChanged += new System.EventHandler(this.languageOptions_SelectedIndexChanged);
            // 
            // SettingsFormLabelSettings
            // 
            this.SettingsFormLabelSettings.AutoSize = true;
            this.SettingsFormLabelSettings.Font = new System.Drawing.Font("Winter Sunday", 30F);
            this.SettingsFormLabelSettings.ForeColor = System.Drawing.Color.Snow;
            this.SettingsFormLabelSettings.Location = new System.Drawing.Point(13, 9);
            this.SettingsFormLabelSettings.Name = "SettingsFormLabelSettings";
            this.SettingsFormLabelSettings.Size = new System.Drawing.Size(243, 48);
            this.SettingsFormLabelSettings.TabIndex = 20;
            this.SettingsFormLabelSettings.Text = "Settings / Configurações";
            this.SettingsFormLabelSettings.UseCompatibleTextRendering = true;
            // 
            // SelectLanguageLabel
            // 
            this.SelectLanguageLabel.AutoSize = true;
            this.SelectLanguageLabel.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.SelectLanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.SelectLanguageLabel.Location = new System.Drawing.Point(35, 67);
            this.SelectLanguageLabel.Name = "SelectLanguageLabel";
            this.SelectLanguageLabel.Size = new System.Drawing.Size(143, 27);
            this.SelectLanguageLabel.TabIndex = 21;
            this.SelectLanguageLabel.Text = "Language / Idioma";
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
            this.testConnectionButton.Location = new System.Drawing.Point(252, 211);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(210, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "OSC Connection Settings";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(25, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 69);
            this.label2.TabIndex = 26;
            this.label2.Text = "Default Server Settings:\r\n\r\nAddress: 127.0.0.1\r\nPort: 9000";
            this.label2.UseCompatibleTextRendering = true;
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(410, 272);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.serverAddressInput);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.SelectLanguageLabel);
            this.Controls.Add(this.SettingsFormLabelSettings);
            this.Controls.Add(this.languageOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VRText - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox languageOptions;
        private System.Windows.Forms.Label SettingsFormLabelSettings;
        private System.Windows.Forms.Label SelectLanguageLabel;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.TextBox serverAddressInput;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label testLabel;
    }
}