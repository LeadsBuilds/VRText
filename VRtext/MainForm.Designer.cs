
namespace VRText
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MessageList = new System.Windows.Forms.ListView();
            this.spotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypingLabel = new System.Windows.Forms.Label();
            this.rotatingTime = new System.Windows.Forms.NumericUpDown();
            this.rotateCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendAgainButton = new System.Windows.Forms.Button();
            this.spotifyLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.addButtonLabel = new System.Windows.Forms.Label();
            this.cooldownLabel = new System.Windows.Forms.Label();
            this.MoveItemDownButton = new System.Windows.Forms.Button();
            this.MoveItemUpButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textInput = new VRText.src.VRText.UI.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rotatingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageList
            // 
            this.MessageList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.MessageList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.MessageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MessageList.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.MessageList.ForeColor = System.Drawing.SystemColors.Menu;
            this.MessageList.FullRowSelect = true;
            this.MessageList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.MessageList.HideSelection = false;
            this.MessageList.LabelEdit = true;
            this.MessageList.Location = new System.Drawing.Point(13, 50);
            this.MessageList.Margin = new System.Windows.Forms.Padding(10);
            this.MessageList.MultiSelect = false;
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(760, 358);
            this.MessageList.TabIndex = 2;
            this.MessageList.TileSize = new System.Drawing.Size(756, 2);
            this.MessageList.UseCompatibleStateImageBehavior = false;
            this.MessageList.View = System.Windows.Forms.View.Details;
            this.MessageList.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.MessageList_DrawSubItem);
            this.MessageList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MessageList_ItemSelectionChanged);
            // 
            // spotifyCheckBox
            // 
            this.spotifyCheckBox.AutoSize = true;
            this.spotifyCheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spotifyCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spotifyCheckBox.Location = new System.Drawing.Point(15, 492);
            this.spotifyCheckBox.Name = "spotifyCheckBox";
            this.spotifyCheckBox.Size = new System.Drawing.Size(106, 21);
            this.spotifyCheckBox.TabIndex = 3;
            this.spotifyCheckBox.Text = "Spotify Status";
            this.spotifyCheckBox.UseVisualStyleBackColor = true;
            this.spotifyCheckBox.CheckedChanged += new System.EventHandler(this.spotifyCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message history:";
            // 
            // TypingLabel
            // 
            this.TypingLabel.AutoSize = true;
            this.TypingLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.TypingLabel.Location = new System.Drawing.Point(15, 409);
            this.TypingLabel.Name = "TypingLabel";
            this.TypingLabel.Size = new System.Drawing.Size(0, 17);
            this.TypingLabel.TabIndex = 5;
            this.TypingLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rotatingTime
            // 
            this.rotatingTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.rotatingTime.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotatingTime.ForeColor = System.Drawing.Color.White;
            this.rotatingTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rotatingTime.Location = new System.Drawing.Point(645, 488);
            this.rotatingTime.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.rotatingTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rotatingTime.Name = "rotatingTime";
            this.rotatingTime.Size = new System.Drawing.Size(81, 25);
            this.rotatingTime.TabIndex = 7;
            this.rotatingTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rotateCheckBox
            // 
            this.rotateCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rotateCheckBox.AutoSize = true;
            this.rotateCheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateCheckBox.ForeColor = System.Drawing.Color.Snow;
            this.rotateCheckBox.Location = new System.Drawing.Point(528, 490);
            this.rotateCheckBox.Name = "rotateCheckBox";
            this.rotateCheckBox.Size = new System.Drawing.Size(116, 21);
            this.rotateCheckBox.TabIndex = 8;
            this.rotateCheckBox.Text = "Rotate list each";
            this.rotateCheckBox.UseVisualStyleBackColor = true;
            this.rotateCheckBox.CheckedChanged += new System.EventHandler(this.rotateCheckbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(732, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "seconds";
            // 
            // sendAgainButton
            // 
            this.sendAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.sendAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.sendAgainButton.FlatAppearance.BorderSize = 2;
            this.sendAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendAgainButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendAgainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.sendAgainButton.Location = new System.Drawing.Point(787, 256);
            this.sendAgainButton.Name = "sendAgainButton";
            this.sendAgainButton.Size = new System.Drawing.Size(91, 30);
            this.sendAgainButton.TabIndex = 11;
            this.sendAgainButton.Text = "Send Again";
            this.sendAgainButton.UseVisualStyleBackColor = false;
            this.sendAgainButton.Click += new System.EventHandler(this.sendAgainButton_Click);
            // 
            // spotifyLabel
            // 
            this.spotifyLabel.AutoSize = true;
            this.spotifyLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spotifyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.spotifyLabel.Location = new System.Drawing.Point(172, 484);
            this.spotifyLabel.Margin = new System.Windows.Forms.Padding(5);
            this.spotifyLabel.MaximumSize = new System.Drawing.Size(350, 40);
            this.spotifyLabel.Name = "spotifyLabel";
            this.spotifyLabel.Size = new System.Drawing.Size(0, 17);
            this.spotifyLabel.TabIndex = 13;
            this.spotifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spotifyLabel.Visible = false;
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.settingsLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.settingsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsLabel.Location = new System.Drawing.Point(775, 81);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Padding = new System.Windows.Forms.Padding(5);
            this.settingsLabel.Size = new System.Drawing.Size(59, 25);
            this.settingsLabel.TabIndex = 20;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.Visible = false;
            // 
            // addButtonLabel
            // 
            this.addButtonLabel.AutoSize = true;
            this.addButtonLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.addButtonLabel.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.addButtonLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButtonLabel.Location = new System.Drawing.Point(716, 386);
            this.addButtonLabel.Name = "addButtonLabel";
            this.addButtonLabel.Padding = new System.Windows.Forms.Padding(5);
            this.addButtonLabel.Size = new System.Drawing.Size(39, 25);
            this.addButtonLabel.TabIndex = 21;
            this.addButtonLabel.Text = "Add";
            this.addButtonLabel.Visible = false;
            // 
            // cooldownLabel
            // 
            this.cooldownLabel.AutoSize = true;
            this.cooldownLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cooldownLabel.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cooldownLabel.ForeColor = System.Drawing.Color.Orange;
            this.cooldownLabel.Location = new System.Drawing.Point(19, 435);
            this.cooldownLabel.Name = "cooldownLabel";
            this.cooldownLabel.Size = new System.Drawing.Size(142, 19);
            this.cooldownLabel.TabIndex = 23;
            this.cooldownLabel.Text = "3 seconds cooldown...";
            this.cooldownLabel.Visible = false;
            // 
            // MoveItemDownButton
            // 
            this.MoveItemDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MoveItemDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.MoveItemDownButton.FlatAppearance.BorderSize = 2;
            this.MoveItemDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveItemDownButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.MoveItemDownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.MoveItemDownButton.Image = global::VRText.Properties.Resources.arrow_down;
            this.MoveItemDownButton.Location = new System.Drawing.Point(787, 205);
            this.MoveItemDownButton.Name = "MoveItemDownButton";
            this.MoveItemDownButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MoveItemDownButton.Size = new System.Drawing.Size(91, 29);
            this.MoveItemDownButton.TabIndex = 26;
            this.MoveItemDownButton.UseVisualStyleBackColor = false;
            this.MoveItemDownButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MoveItemUpButton
            // 
            this.MoveItemUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MoveItemUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.MoveItemUpButton.FlatAppearance.BorderSize = 2;
            this.MoveItemUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveItemUpButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.MoveItemUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.MoveItemUpButton.Image = global::VRText.Properties.Resources.arrow_up;
            this.MoveItemUpButton.Location = new System.Drawing.Point(787, 135);
            this.MoveItemUpButton.Name = "MoveItemUpButton";
            this.MoveItemUpButton.Size = new System.Drawing.Size(91, 29);
            this.MoveItemUpButton.TabIndex = 25;
            this.MoveItemUpButton.UseVisualStyleBackColor = false;
            this.MoveItemUpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.aboutButton.FlatAppearance.BorderSize = 2;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Image = global::VRText.Properties.Resources.info;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(811, 50);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(77, 30);
            this.aboutButton.TabIndex = 19;
            this.aboutButton.Text = "About";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseCompatibleTextRendering = true;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.settingsButton.FlatAppearance.BorderSize = 2;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI Historic", 14F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(775, 50);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(34, 30);
            this.settingsButton.TabIndex = 18;
            this.settingsButton.UseCompatibleTextRendering = true;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            this.settingsButton.MouseHover += new System.EventHandler(this.settingsButton_MouseHover);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.AddButton.Image = global::VRText.Properties.Resources.add2;
            this.AddButton.Location = new System.Drawing.Point(726, 413);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(44, 49);
            this.AddButton.TabIndex = 12;
            this.AddButton.UseCompatibleTextRendering = true;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseLeave += new System.EventHandler(this.addButtonLabel_MouseLeave);
            this.AddButton.MouseHover += new System.EventHandler(this.addButtonLabel_MouseHover);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.removeButton.FlatAppearance.BorderSize = 2;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.removeButton.Image = global::VRText.Properties.Resources.bin;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.removeButton.Location = new System.Drawing.Point(787, 170);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(91, 29);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove selected";
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.sendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(113)))), ((int)(((byte)(115)))));
            this.sendButton.FlatAppearance.BorderSize = 2;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(227)))), ((int)(((byte)(249)))));
            this.sendButton.Image = global::VRText.Properties.Resources.send;
            this.sendButton.Location = new System.Drawing.Point(627, 413);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(95, 49);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sendButton.UseMnemonic = false;
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VRText.Properties.Resources.logoSmall;
            this.pictureBox1.Location = new System.Drawing.Point(606, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 39);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.textInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textInput.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Italic);
            this.textInput.ForeColor = System.Drawing.Color.Gray;
            this.textInput.Location = new System.Drawing.Point(16, 428);
            this.textInput.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.textInput.MaxLength = 144;
            this.textInput.Name = "textInput";
            this.textInput.PlaceHolderText = "Message";
            this.textInput.Size = new System.Drawing.Size(607, 33);
            this.textInput.TabIndex = 22;
            this.textInput.Text = "Message";
            this.textInput.WordWrap = false;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            this.textInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textInput_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(892, 528);
            this.Controls.Add(this.MoveItemDownButton);
            this.Controls.Add(this.MoveItemUpButton);
            this.Controls.Add(this.cooldownLabel);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.addButtonLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.rotatingTime);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.spotifyLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.sendAgainButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotateCheckBox);
            this.Controls.Add(this.TypingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spotifyCheckBox);
            this.Controls.Add(this.MessageList);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "VRText";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rotatingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListView MessageList;
        private System.Windows.Forms.CheckBox spotifyCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TypingLabel;
        private System.Windows.Forms.NumericUpDown rotatingTime;
        private System.Windows.Forms.CheckBox rotateCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button sendAgainButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label spotifyLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label addButtonLabel;
        private src.VRText.UI.PlaceHolderTextBox textInput;
        private System.Windows.Forms.Label cooldownLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MoveItemUpButton;
        private System.Windows.Forms.Button MoveItemDownButton;
    }
}

