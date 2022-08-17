using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRText.Config
{
    static class OSC
    {
        private static string[] settings =
                {
                    "127.0.0.1",
                    "9000"
                };

        private static string[] endpoints =
                {
                    "/chatbox/input",
                    "/chatbox/typing"
                };

        public static string getAddress()
        {
            return settings[0];
        }

        public static int getAddressPort()
        {
            if (Int32.TryParse(settings[1], out int addressPort))
            {
                return addressPort;
            }

            return 0;
        }

        public static string getChatEndpoint()
        {
            return endpoints[0];
        }

        public static string getTypingEndPoint()
        {
            return endpoints[1];
        }

        public static void setNewAddress(string address, string port)
        {
            settings[0] = address;
            settings[1] = port;
        }
    }
}
