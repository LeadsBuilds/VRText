using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NLog;

namespace VRText
{
    static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        
        static readonly Assembly ExecutingAssembly = Assembly.GetExecutingAssembly();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeFolders();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if  DEBUG
            // AllocConsole();
#endif
            LogManager.Setup().LoadConfiguration(builder => {
                builder.ForLogger().FilterMinLevel(LogLevel.Info).WriteToConsole();
                builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteToFile(fileName: "log.txt");
            });
            
            Application.Run(new MainForm());
        }

        static void InitializeFolders()
        {
            var appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            
            AppDomain.CurrentDomain.SetData("DataDirectory", appDataDirectory);

            var dllDirectory = appDataDirectory.Replace(@"\", "/") + "/VRText";

            string[] SQLiteDllFolders = { "x86", "x64" };
            
            foreach (var folder in SQLiteDllFolders) {
                bool exists = Directory.Exists($"{dllDirectory}/{folder}");
                if(!exists) Directory.CreateDirectory($"{dllDirectory}/{folder}");
            }
            
            MoveSqLiteDlls(SQLiteDllFolders, dllDirectory);
        }

        static void MoveSqLiteDlls(string[] folders, string dllDirectory)
        {
            foreach (var folder in folders)
            {
                var fileName = "SQLite.Interop.dll";
                var resourceName = ExecutingAssembly.GetManifestResourceNames().Where(x => x.EndsWith($"{folder}.{fileName}")).ToArray();
                using (var stream = ExecutingAssembly.GetManifestResourceStream(resourceName[0]))
                {
                    var fileDirectory = $"{dllDirectory}/{folder}";
                        
                    Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + fileDirectory);
                    stream.CopyTo(File.Create($"{fileDirectory}/{fileName}"));
                }
            }
        }
    }
}
