using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRText.Handlers;
using VRText.Config;

namespace VRText.Spotify
{
    class SpotifyHandler
    {
        private static string currentSong = "";
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

            if (GetSpotifyTrackInfo() != currentSong)
            {
                MessageHandler.sendMessage("#" + GetSpotifyTrackInfo());
                currentSong = GetSpotifyTrackInfo();

            }
                return;
        }

        public static string getCurrentSong()
        {
            currentSong = GetSpotifyTrackInfo();
            return currentSong;
        }


    }
}
