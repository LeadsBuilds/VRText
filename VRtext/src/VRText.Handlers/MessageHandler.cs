using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VRText.Config;
using OscMessage = VRText.SharpOSC.OscMessage;
using UDPSender = VRText.SharpOSC.UDPSender;

namespace VRText.Handlers
{
    public static class MessageHandler
    {
        delegate void MultiThreadCallBack();

        private static int increment = 0;
        public static void invokeCtrl(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;

            if (control.InvokeRequired)
            {
                control.Invoke(new MultiThreadCallBack(() => invokeCtrl(control, function)));
                return;
            }
            function();
        }

        public static void saveLog(ListView listView, string message)
        {
            var createdAt = DateTime.Now.ToString("m/d/y HH:mm:ss.fff");
            var item = new ListViewItem(new[] { message, createdAt});
            var messageArray = new List<string>();
            messageArray.Add(message);
            messageArray.Add(createdAt);
            
            listView.Items.Add(item);
            SQLiteHandler.InsertNewMessage(messageArray);
        }

        public static void sendMessage(string message)
        {
            var inputMessage = new OscMessage(OSC.getChatEndpoint(), message, true);
            var sendMessage = new UDPSender(OSC.getAddress(), OSC.getAddressPort());
            
            try
            {
                sendMessage.Send(inputMessage);
            }
            catch (Exception e)
            {
                var handler = new ErrorHandler();
                handler.Show("Error: " + e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error, false);
            }
        }
        
        // implement this, currently cant do that until placeholder text code is more firmly understood
        public static void SendTypingIndicator(bool state)
        {
            var inputMessage = new OscMessage(OSC.getTypingEndPoint(), state);
            var sendMessage = new UDPSender(OSC.getAddress(), OSC.getAddressPort());
            sendMessage.Send(inputMessage);
            
        }

        private static void sendTypingStatus()
        {
            Console.WriteLine("Typing");
        }

        public static int getMessageLength(TextBox text)
        {
            var maxLength = 144;
            var currentLength = text.Text.Length;
            var remainder = 144;

            if (currentLength >= 0)
            {
                remainder = remainder - currentLength - 1;
            }

            if (currentLength <= maxLength)
            {
                remainder++;
            }

            return remainder;
        }

        public static void addToList(ListView listView, string message)
        {
            var createdAt = DateTime.Now.ToString("M/d/y HH:mm:ss.fff");
            var item = new ListViewItem(new[] { message, createdAt });
            
            var messageArray = new List<string>();
            
            messageArray.Add(message);
            messageArray.Add(createdAt);
            SQLiteHandler.InsertNewMessage(messageArray);
            
            listView.Items.Add(item);
        }

        public static void removeFromList(ListView listView)
        {

            foreach (ListViewItem item in listView.SelectedItems)
            {
                var previousIndex = 0;

                if (item.Index > 0)
                {
                    previousIndex = item.Index - 1;
                }

                if (!listView.Items.ContainsKey(listView.Items[previousIndex].Name))
                {
                    listView.Items[previousIndex].Selected = true;
                    listView.Items.Remove(item);

                    var message = new List<string>();
                    message.Add(item.SubItems[0].Text);
                    message.Add(item.SubItems[1].Text);
                    
                    SQLiteHandler.DeleteSingleMessage(message);
                }
            }

        }

        private delegate ListView GetItems(ListView lstview);

        private static ListView getListViewItems(ListView lstview)
        {
            var temp = new ListView();
            if (!lstview.InvokeRequired)
            {
                foreach (ListViewItem item in lstview.Items)
                    temp.Items.Add((ListViewItem)item.Clone());
                return temp;
            }
            else
                return (ListView)lstview.Invoke(new GetItems(getListViewItems), new object[] { lstview });
        }
        public static void Rotate(ListView listView)
        {
            var rotatingListView = getListViewItems(listView);
            rotatingListView.Sorting = SortOrder.Ascending;
            var totalItems = rotatingListView.Items.Count - 1;

            if (totalItems == -1) 
            {
                return;
            }

            var text = rotatingListView.Items[increment].Text;

            if (increment == totalItems)
            {
                increment = -1;
            }

            if (increment <= totalItems)
            {
                increment++;
                sendMessage(text);
            }

        }
    }
}
