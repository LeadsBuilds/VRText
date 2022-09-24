using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VRText.Utils;
using VRText.Handlers;
using VRText.Spotify;
using VRText.Config;
using VRText.src.VRText.UI;
using System.Globalization;

namespace VRText
{
    public partial class MainForm : Form
    {
        Interval interval = new Interval();
        System.Timers.Timer intervalTimer;
        private string selectedMessage = "";

        public string language;

        public List<KeyValuePair<string, string>> lang;
        public MainForm()
        {
            CosturaUtility.Initialize();
            CultureInfo ci = CultureInfo.InstalledUICulture;
            ci = CultureInfo.CurrentUICulture;
            this.language = "DE";//ci.ToString();

            if (this.language != "pt-BR" && this.language != "en-US")
            {
                this.language = "en-US";
            }

            Console.WriteLine("Loaded default language: " + this.language);
            this.lang = new Lang(this.language).getCurrentLanguage();

            InitializeComponent();
            setComponentLanguage();
            initListView(MessageList);
            initParams();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string text = textInput.Text;

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
            Interval delay = new Interval();
            textInput.Enabled = false;
            sendButton.Enabled = false;
            sendAgainButton.Enabled = false;
            cooldownLabel.Visible = true;
            delay.setTimeout(() => this.coolDown(), 1000);
            textInput.Clear();

        }

        private void coolDown()
        {
            MessageHandler.invokeCtrl(textInput, () =>
            {
                textInput.Enabled = true;
                cooldownLabel.Visible = false;
                sendButton.Enabled = true;
                sendAgainButton.Enabled = true;
            });

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

        private void initListView(ListView listView)
        {
            listView.OwnerDraw = true;
            listView.Columns.Add("Message", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sent At", -2, HorizontalAlignment.Left);
    
            listView.BorderStyle = BorderStyle.FixedSingle;
            
            this.ResizeListViewColumns(listView);
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
                this.interval.Stop(intervalTimer);
                return;
            }

            if (spotifyCheckBox.Checked)
            {
                spotifyCheckBox.Checked = false;
                this.interval.Stop(this.intervalTimer);
            }

            this.intervalTimer = this.interval.Set(() => MessageHandler.rotate(MessageList), (int)rotatingTime.Value * 1000);
        }
        private void spotifyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            spotifyLabel.Visible = true;
            if (!spotifyCheckBox.Checked)
            {
                spotifyLabel.Visible = false;
                this.interval.Stop(intervalTimer);

                return;
            }

            if (rotateCheckBox.Checked)
            {
                rotateCheckBox.Checked = false;
                this.interval.Stop(this.intervalTimer);
            }

            Interval spotifyLabelInterval = new Interval();

            this.intervalTimer = this.interval.Set(() => SpotifyHandler.SendOverOSC(), (int)rotatingTime.Value * 100);
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            var remainder = MessageHandler.getMessageLength(textInput);

            TypingLabel.Text =  remainder + "/144 " + this.lang.SingleOrDefault(x => x.Key == "typing").Value;

            if (remainder > 125)
            {
                TypingLabel.Text = "";
            }
        }

        private void MessageList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string currentItem = e.Item.Text;
            this.selectedMessage = currentItem;
        }

        private void sendAgainButton_Click(object sender, EventArgs e)
        {
            MessageHandler.sendMessage(this.selectedMessage);
            Interval delay = new Interval();
            textInput.Enabled = false;
            sendButton.Enabled = false;
            sendAgainButton.Enabled = false;
            cooldownLabel.Visible = true;
            delay.setTimeout(() => this.coolDown(), 1000);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            MessageHandler.removeFromList(MessageList);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string text = textInput.Text;

            if (text == "\r\n" || text.Length <= 0)
            {
                textInput.Text = "";
                return;
            }

            MessageHandler.addToList(MessageList, textInput.Text);
        }

        private void initParams()
        {
            textInput.PlaceHolderText = this.lang.SingleOrDefault(x => x.Key == "placeHolder").Value;
            cooldownLabel.Text = this.lang.SingleOrDefault(x => x.Key == "cooldown").Value;
        }

        private void MessageList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            SolidBrush backColor = new SolidBrush(Color.FromArgb(16, 40, 47));
            SolidBrush selectedColor = new SolidBrush(Color.FromArgb(66, 113, 115));
            SolidBrush foreColor = new SolidBrush(Color.White);

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

        public void setComponentLanguage()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Name == "logoLabel" || ctrl.Name == "GitHub")
                {
                    continue;
                }

                if (ctrl.Text != null)
                {
                    KeyValuePair<string, string> obj = this.lang.SingleOrDefault(x => x.Key == ctrl.Name);
                    ctrl.Text = obj.Value;
                }
            }

            initParams();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageList.BeginUpdate();

            foreach (ListViewItem selectedItem in MessageList.SelectedItems)
            {
                if (selectedItem.Index > 0)
                {
                    int index = selectedItem.Index - 1;
                    MessageList.Items.RemoveAt(selectedItem.Index);
                    MessageList.Items.Insert(index, selectedItem);
                }
            }

            MessageList.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageList.BeginUpdate();

            foreach (ListViewItem selectedItem in MessageList.SelectedItems)
            {
                if (selectedItem.Index >= 0 && selectedItem.Index < MessageList.Items.Count - 1)
                {
                    int index = selectedItem.Index + 1;
                    MessageList.Items.RemoveAt(selectedItem.Index);
                    MessageList.Items.Insert(index, selectedItem);
                }
            }

            MessageList.EndUpdate();
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MessageList.Items)
            {
                MessageList.Items.Remove(item);
            }
        }
    }

}
