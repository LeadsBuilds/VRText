using System;
using System.IO;
using System.Windows.Forms;

namespace VRText.Handlers
{
    /// <summary>
    /// Provides an error handling mechanism.
    /// </summary>
    public class ErrorHandler
    {
        private static readonly string logFilePath = "VRText.log";
        private static readonly object lockObject = new object();

        /// <summary>
        /// Displays an error dialog box with the specified message, button and icon, and writes the error message along with the current date and time to a log file.
        /// </summary>
        /// <param name="message">The message to display in the error dialog box and write to the log file.</param>
        /// <param name="button">The set of buttons to be displayed in the message box.</param>
        /// <param name="icon">The icon to be displayed in the top-right corner of the message box.</param>
        /// <param name="showuser">Whether or not the MessageBox should be shown to the user or just logged to console. Default is true.</param>
        public void Show(string message, MessageBoxButtons button, MessageBoxIcon icon, bool? showuser = true)
        {
            // Set the message box content
            if (showuser == true)
            {
                MessageBox.Show(message, @"VRText", button, icon);
            }

            // Write the message to the log file
            lock (lockObject)
            {
                using (var writer = File.AppendText(logFilePath))
                {
                    // Print the current date and time if the writer is being used for the first time
                    if (writer.BaseStream.Length == 0)
                    {
                        writer.WriteLine($"{DateTime.Now}: ------Beginning new log-set------");
                    }

                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
        }

    }
}