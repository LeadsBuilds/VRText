using System.Diagnostics;
using System.Linq;
using VRText.Handlers;

namespace VRText.Spotify
{
    class SpotifyHandler
    {
        private static string currentSong = "";
        private static string prefix = "Spotify:";
        private static string GetSpotifyTrackInfo()
        {
            var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null)
            {
                return "";
            }

            return proc.MainWindowTitle;
        }

        public static void SendOverOSC()
        {
            if (GetSpotifyTrackInfo() == "" || GetSpotifyTrackInfo() == "Spotify" || GetSpotifyTrackInfo() == "Spotify Premium")
            {
                return;
            }

            if (GetSpotifyTrackInfo() == currentSong) return;
            MessageHandler.sendMessage(prefix + " " + GetSpotifyTrackInfo());
            currentSong = GetSpotifyTrackInfo();
        }

        public static string getCurrentSong()
        {
            currentSong = GetSpotifyTrackInfo();
            return currentSong;
        }

        public static void setPrefix(string definePrefix)
        {
            prefix = definePrefix;
        }

        public static string getPrefix()
        {
            return prefix;
        }


    }
}
