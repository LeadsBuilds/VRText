using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Swan;
using VRText.Utils;
using VRText.Handlers;
using VRText.Spotify;
using VRText.Config;
using VRText.src.VRText.UI;

namespace VRText
{
    public partial class MainForm : Form
    {
        System.Timers.Timer intervalTimer;
        System.Timers.Timer checkTypingTimer;
        
        private readonly Interval _interval = new Interval();
        private readonly Interval _indicatorInterval = new Interval();
        private bool _isTyping;
        private bool _isTypingState;
        
        private string _selectedMessage = "";
        
        private decimal _loadedRotatingTime;
        public string language;

        public List<KeyValuePair<string, string>> lang;
        public MainForm()
        {
            CosturaUtility.Initialize();

            if (this.language != "pt-BR" && this.language != "en-US")
            {
                this.language = "en-US";
            }
#if DEBUG
            Console.WriteLine("Loaded default language: " + this.language);
#endif
            
            var currentLanguage = new Lang(this.language).GetCurrentLanguage();
            if (currentLanguage != null)
            {
                this.lang = currentLanguage;
            }
            
            InitializeComponent();
            InitParams();
            InitDataBase();
            SetComponentLanguage(this);
            InitListView(MessageList);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var text = textInput.Text;

            if (text == "\r\n" || text.Length <= 0)
            {
                textInput.Text = "";
                return;
            }

            if (rotateCheckBox.Checked)
            {
                MessageHandler.saveLog(MessageList, text);
                return;
            }

            MessageHandler.sendMessage(text);
            MessageHandler.saveLog(MessageList, text);
            var messagedelay = new Interval();
            textInput.Enabled = false;
            sendButton.Enabled = false;
            sendAgainButton.Enabled = false;
            cooldownLabel.Visible = true;
            messagedelay.setTimeout(() => this.TypingCoolDown(), 1000);
            textInput.Clear();
            MessageList.Items[MessageList.Items.Count - 1].EnsureVisible();
        }

        private void TypingCoolDown()
        {
            MessageHandler.invokeCtrl(textInput, () =>
            {
                textInput.Enabled = true;
                cooldownLabel.Visible = false;
                sendButton.Enabled = true;
                sendAgainButton.Enabled = true;
                textInput.Select();
            });
        }

        private void HandleTypingIndicator()
        {
            var changeText = textInput.Text;
            _indicatorInterval.setTimeout(() =>
            {
                if (textInput.Text == changeText)
                {
                    MessageHandler.SendTypingIndicator(false);
                    _isTypingState = false;
                    _isTyping = false;
                }
            },500);

            if (!_isTyping)
            {
                _isTyping = true;
                return;
            }
            
            if (_isTyping && !_isTypingState)
            {
                _isTypingState = true;
                MessageHandler.SendTypingIndicator(true);
                return;
            }
            
            _isTyping = true;
        }

        private void textInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(this, new EventArgs());
                textInput.Clear();
                textInput.Refresh();
                e.Handled = true;
            }
        }

        private void InitListView(ListView listView)
        {
            listView.OwnerDraw = true;
            listView.Columns.Add("Message", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sent At", -2, HorizontalAlignment.Left);
    
            listView.BorderStyle = BorderStyle.FixedSingle;

            var messages = SQLiteHandler.GetAllMessages();
            
            foreach (var message in messages)
            {
                var item = new ListViewItem(new[] { message[0], message[1] });
                listView.Items.Add(item);
            }
            
            ResizeListViewColumns(listView);
            this.rotatingTime.Value = this._loadedRotatingTime;
        }

        private void ResizeListViewColumns(ListView listView)
        {
            listView.Columns[1].Width = 200;
            listView.Columns[0].Width = 757 - listView.Columns[1].Width;
        }

        private void rotateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!rotateCheckBox.Checked)
            {
                this._interval.Stop(intervalTimer);
                SQLiteHandler.SetCheckBoxStatus(false, "rotate");
                
                return;
            }

            if (spotifyCheckBox.Checked)
            {
                spotifyCheckBox.Checked = false;
                this._interval.Stop(this.intervalTimer);
            }
            
            SQLiteHandler.SetCheckBoxStatus(true, "rotate");
            this.intervalTimer = this._interval.Set(() => MessageHandler.Rotate(MessageList), (int)rotatingTime.Value * 1000);
        }
        private void spotifyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            spotifyLabel.Visible = true;
            if (!spotifyCheckBox.Checked)
            {
                spotifyLabel.Visible = false;
                this._interval.Stop(intervalTimer);
                SQLiteHandler.SetCheckBoxStatus(false, "spotify");
                
                return;
            }

            if (rotateCheckBox.Checked)
            {
                rotateCheckBox.Checked = false;
                this._interval.Stop(this.intervalTimer);
            }

            SQLiteHandler.SetCheckBoxStatus(true, "spotify");
            this.intervalTimer = this._interval.Set(() => SpotifyHandler.SendOverOSC(), (int)rotatingTime.Value * 100);
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            var remainder = MessageHandler.getMessageLength(textInput);

            TypingLabel.Text =  remainder + "/144 " + this.lang.SingleOrDefault(x => x.Key == "typing").Value;

            if (remainder > 125)
            {
                TypingLabel.Text = "";
            }
            
            HandleTypingIndicator();
        }

        private void MessageList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var currentItem = e.Item.Text;
            this._selectedMessage = currentItem;
        }

        private void sendAgainButton_Click(object sender, EventArgs e)
        {
            textInput.Select();
            textInput.Text = _selectedMessage;
            textInput.Select(textInput.Text.Length, 0);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            MessageHandler.removeFromList(MessageList);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var text = textInput.Text;

            if (text == "\r\n" || text.Length <= 0)
            {
                textInput.Text = "";
                return;
            }

            MessageHandler.addToList(MessageList, textInput.Text);
        }

        private void InitParams()
        {
            textInput.PlaceHolderText = this.lang.SingleOrDefault(x => x.Key == "placeHolder").Value;
            cooldownLabel.Text = this.lang.SingleOrDefault(x => x.Key == "cooldown").Value;
        }

        private void InitDataBase()
        {
            SQLiteHandler.init();
            InitializeSettings();

        }
        
        private void InitializeSettings()
        {
            var loadSettings = SQLiteHandler.LoadSettings();
            string serverAddress;
            string serverPort;
            string spotifyPrefix;
            string lang;
            string spotifyStatus;
            string rotateList;
            string rotatingTime;

            serverAddress = OSC.GetAddress();
            serverPort = OSC.GetAddressPort().ToString();
            spotifyPrefix = SpotifyHandler.getPrefix();
            lang = language;
            spotifyStatus = spotifyCheckBox.Checked.ToString();
            rotateList = rotateCheckBox.Checked.ToString();
            rotatingTime = "10";

            if (loadSettings.Any())
            {
                var settingsValues = loadSettings[0];
                
                serverAddress = settingsValues[0];
                serverPort = settingsValues[1];
                spotifyPrefix = settingsValues[2];
                lang = settingsValues[3];
                spotifyStatus = settingsValues[4];
                rotateList = settingsValues[5];
                rotatingTime = settingsValues[6];

                var loadedLang = new Lang(lang).GetCurrentLanguage();
                if (language != null)
                {
                    this.lang = loadedLang;
                }

                spotifyCheckBox.Checked = spotifyStatus.ToBoolean();
                rotateCheckBox.Checked = rotateList.ToBoolean();
                this._loadedRotatingTime = Int16.Parse(rotatingTime);
                
                OSC.SetNewAddress(serverAddress, serverPort);
                SpotifyHandler.setPrefix(spotifyPrefix);
            }

            string[] data = { serverAddress, serverPort, spotifyPrefix, lang, spotifyStatus, rotateList, rotatingTime };
            
            if (!loadSettings.Any()) SQLiteHandler.InitSettings(data);

        }

        private void MessageList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var backColor = new SolidBrush(Color.FromArgb(16, 40, 47));
            var selectedColor = new SolidBrush(Color.FromArgb(66, 113, 115));
            var foreColor = new SolidBrush(Color.White);

            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(selectedColor, e.Bounds);
            }else
            {
                e.Graphics.FillRectangle(backColor, e.Bounds);
            }
            e.DrawText();
        }

        // FORM LANGUAGE CONFIG

        public void SetComponentLanguage(Control parentControl)
        {
            foreach (Control ctrl in parentControl.Controls)
            {
                var excludedControls = new HashSet<string> { "logoLabel", "GitHub", "languageOptions", "CopyrightLabel", "serverAddressInput", "portInput", "SpotifyPrefixInput" };
                
                // Check if control should be excluded from translation
                if (excludedControls.Contains(ctrl.Name))
                {
                    continue;
                }
                if (ctrl is Form)
                {
                    SetComponentLanguage(ctrl); // recursively call the function for nested forms
                }
                var obj = this.lang.SingleOrDefault(x => x.Key == ctrl.Name);
                ctrl.Text = obj.Value;
            }

            InitParams();
        }

        ///

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void settingsButton_MouseHover(object sender, EventArgs e)
        {
            settingsLabel.Visible = true;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsLabel.Visible = false;
        }

        private void addButtonLabel_MouseHover(object sender, EventArgs e)
        {
            addButtonLabel.Visible = true;
        }

        private void addButtonLabel_MouseLeave(object sender, EventArgs e)
        {
            addButtonLabel.Visible = false;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();

            if (Application.OpenForms["AboutForm"] == null)
            {
                about.Show();
            }

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Form settings = new Settings(this);

            if (Application.OpenForms["Settings"] == null)
            {
                settings.Show();
            }
        }

        private void arrowUpButton_Click(object sender, EventArgs e)
        {
            MessageList.BeginUpdate();

            foreach (ListViewItem selectedItem in MessageList.SelectedItems)
            {
                if (selectedItem.Index > 0)
                {
                    var index = selectedItem.Index - 1;
                    MessageList.Items.RemoveAt(selectedItem.Index);
                    MessageList.Items.Insert(index, selectedItem);
                }
            }

            MessageList.EndUpdate();
            SQLiteHandler.DeleteAllMessages();

            foreach (ListViewItem item in MessageList.Items)
            {
                var message = item.SubItems[0].Text;
                var createdAt = item.SubItems[1].Text;
                var messageList = new List<string>();
                messageList.Add(message);
                messageList.Add(createdAt);
                
                SQLiteHandler.InsertNewMessage(messageList);
            }
        }

        private void arrowDownButton_Click(object sender, EventArgs e)
        {

            MessageList.BeginUpdate();

            foreach (ListViewItem selectedItem in MessageList.SelectedItems)
            {
                if (selectedItem.Index >= 0 && selectedItem.Index < MessageList.Items.Count - 1)
                {
                    var index = selectedItem.Index + 1;
                    MessageList.Items.RemoveAt(selectedItem.Index);
                    MessageList.Items.Insert(index, selectedItem);
                }
            }

            MessageList.EndUpdate();
            SQLiteHandler.DeleteAllMessages();

            foreach (ListViewItem item in MessageList.Items)
            {
                var message = item.SubItems[0].Text;
                var createdAt = item.SubItems[1].Text;
                var messageList = new List<string>();
                messageList.Add(message);
                messageList.Add(createdAt);
                
                SQLiteHandler.InsertNewMessage(messageList);
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MessageList.Items)
            {
                MessageList.Items.Remove(item);
            }

            SQLiteHandler.DeleteAllMessages();
        }

        private void rotatingTime_ValueChanged(object sender, EventArgs e)
        {
            SQLiteHandler.UpdateRotatingTime(rotatingTime.Value);
        }
    }

}
