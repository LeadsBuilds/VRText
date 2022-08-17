using System;
using System.Windows.Forms;
using VRText.Config;
using SharpOSC;
using VRText.Utils;

namespace VRText.Handlers
{
    public static class MessageHandler
    {
        delegate void MultiThreadCallBack();

        private static int increment = 0;

        private static Interval cooldown = new Interval();

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
            var item = new ListViewItem(new[] { message, DateTime.Now.ToString("HH:mm:ss") });
            listView.Items.Add(item);
        }

        public static void sendMessage(string message)
        {
            var inputMessage = new OscMessage(OSC.getChatEndpoint(), message, true);
            var sendMessage = new UDPSender(OSC.getAddress(), OSC.getAddressPort());
            sendMessage.Send(inputMessage);
            
        }

        private static void sendTypingStatus()
        {
            Console.WriteLine("Typing");
        }

        public static int getMessageLength(TextBox text)
        {
            int maxLength = 144;
            int currentLength = text.Text.Length;
            int remainder = 144;

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
            var item = new ListViewItem(new[] { message, DateTime.Now.ToString("HH:mm:ss") });
            listView.Items.Add(item);
        }

        public static void removeFromList(ListView listView)
        {

            foreach (ListViewItem item in listView.SelectedItems)
            {
                listView.Items.Remove(item);
            }

        }

        private delegate ListView GetItems(ListView lstview);

        private static ListView getListViewItems(ListView lstview)
        {
            ListView temp = new ListView();
            if (!lstview.InvokeRequired)
            {
                foreach (ListViewItem item in lstview.Items)
                    temp.Items.Add((ListViewItem)item.Clone());
                return temp;
            }
            else
                return (ListView)lstview.Invoke(new GetItems(getListViewItems), new object[] { lstview });
        }
        public static void rotate(ListView listView)
        {
            ListView rotatingListView = getListViewItems(listView);
            rotatingListView.Sorting = SortOrder.Ascending;
            int totalItems = rotatingListView.Items.Count - 1;

            if (totalItems == -1) 
            {
                return;
            }

            string text = rotatingListView.Items[increment].Text;

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
