using System;
using System.Text.RegularExpressions;
using VRText.Handlers;

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

        public static string GetAddress()
        {
            return settings[0];
        }

        public static int GetAddressPort()
        {
            if (Int32.TryParse(settings[1], out var addressPort))
            {
                return addressPort;
            }

            return 0;
        }

        public static string GetChatEndpoint()
        {
            return endpoints[0];
        }

        public static string GetTypingEndPoint()
        {
            return endpoints[1];
        }

        public static void SetNewAddress(string address, string port)
        {
            settings[0] = address;
            settings[1] = port;

            SQLiteHandler.UpdateOSCSettings(address, port);
        }
        
        public static bool IsValidateIp(string ip)    
        {
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex check = new Regex(pattern);

            if (string.IsNullOrEmpty(ip))
            {
                return false;
            }

            return check.IsMatch(ip, 0);
        }   
    }
}
