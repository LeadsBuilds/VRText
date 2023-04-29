using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using VRText.Handlers;

namespace VRText.Config
{
    public class Lang
    {
        ErrorHandler errorHandlerLang = new ErrorHandler();
        private List<KeyValuePair<string, string>> currentLanguage;

        public Lang(string lang)
        {
            var language = GetLanguage(lang);
            if (language == null)
            {
                errorHandlerLang.Show("Language selected doesnt exist", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
            }
            else
            {
                currentLanguage = language;
            }
        }

        private List<KeyValuePair<string, string>> GetLanguage(string lang)
        {
            try
            {
                var resourceName = $"VRText.Localization.{lang}.txt";

                var assembly = Assembly.GetExecutingAssembly();
                var resourceStream = assembly.GetManifestResourceStream(resourceName);

                if (resourceStream == null)
                {
                    errorHandlerLang.Show($"Resource {resourceName} not found in assembly or has not been implemented.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                using (var reader = new StreamReader(resourceStream))
                {
                    var language = new List<KeyValuePair<string, string>>();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                        {
                            continue;
                        }

                        var parts = line.Split('=');
                        if (parts.Length != 2)
                        {
                            errorHandlerLang.Show($"Invalid language file format: {line}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }

                        language.Add(new KeyValuePair<string, string>(parts[0], parts[1]));
                    }

                    return language;
                }
            }
            catch (Exception e)
            {
                errorHandlerLang.Show($"Exception at GetLanguage TryCatch {e}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<KeyValuePair<string, string>> GetCurrentLanguage()
        {
            return this.currentLanguage;
        }
    }
}