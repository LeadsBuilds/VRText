using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace VRText.Config
{
    public class Lang
    {
        private List<KeyValuePair<string, string>> currentLanguage;

        public Lang(string lang)
        {
            this.currentLanguage = this.GetLanguage(lang);
        }

        private List<KeyValuePair<string, string>> GetLanguage(string lang)
        {
            string resourceName = $"VRText.Localization.{lang}.txt";

            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream resourceStream = assembly.GetManifestResourceStream(resourceName);

            if (resourceStream == null)
            {
                MessageBox.Show($"Resource {resourceName} not found in assembly\nor has not been implemented.");
                throw new ArgumentException($"Resource {resourceName} not found in assembly.");
            }

            using (StreamReader reader = new StreamReader(resourceStream))
            {
                List<KeyValuePair<string, string>> language = new List<KeyValuePair<string, string>>();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    {
                        continue;
                    }

                    string[] parts = line.Split('=');
                    if (parts.Length != 2)
                    {
                        throw new ArgumentException($"Invalid language file format: {line}");
                    }

                    language.Add(new KeyValuePair<string, string>(parts[0], parts[1]));
                }

                return language;
            }
        }

        public List<KeyValuePair<string, string>> GetCurrentLanguage()
        {
            return this.currentLanguage;
        }
    }
}