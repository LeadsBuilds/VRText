using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VRText.Handlers;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if  DEBUG
            // AllocConsole();
#endif
            try
            {
                InitializeFolders();
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                new ErrorHandler().Show(e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Error: " + e.Message);
            }
        }

        static void InitializeFolders()
        {
            var appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\VRText";
            
            AppDomain.CurrentDomain.SetData("DataDirectory", appDataDirectory);

            var dllDirectory = appDataDirectory.Replace(@"\", "/");

            string[] SQLiteDllFolders = { "x86", "x64" };
            
            foreach (var folder in SQLiteDllFolders) {
                var pathDir = $"{appDataDirectory}\\{folder}";
                Environment.SetEnvironmentVariable("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + pathDir);
                
                bool exists = Directory.Exists($"{dllDirectory}/{folder}");
                if(!exists) Directory.CreateDirectory($"{dllDirectory}/{folder}");
            }
            
            CreateResources(SQLiteDllFolders, dllDirectory);
        }

        static void CreateResources(string[] folders, string dllDirectory)
        {
            foreach (var folder in folders)
            {
                var fileName = "SQLite.Interop.dll";
                var resourceName = ExecutingAssembly.GetManifestResourceNames().Where(x => x.EndsWith($"{folder}.{fileName}")).ToArray();
                using (var stream = ExecutingAssembly.GetManifestResourceStream(resourceName[0]))
                {
                    var fileDirectory = $"{dllDirectory}/{folder}";
                    if (!File.Exists($"{fileDirectory}/{fileName}")) {
                        stream.CopyTo(File.Create($"{fileDirectory}/{fileName}"));

                        if (folder == "x64")
                        {
                            Application.Restart();
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
