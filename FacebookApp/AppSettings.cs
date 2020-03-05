using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace C19_Ex01_Maayan_313353161_Eden_315855049
{
    public class AppSettings
    {
        private const string            k_FileName = "\\appSettings.xml";

        private AppSettings()
        {
            this.RememberMe = false;
            this.LastAccessToken = null;  
        }

        public bool RememberMe { get; set; }

        public string LastAccessToken { get; set; }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();
            string pathOfSettingsFile = Environment.CurrentDirectory;
            pathOfSettingsFile += k_FileName;

            try
            {
                if (File.Exists(pathOfSettingsFile) && new FileInfo(pathOfSettingsFile).Length > 0)
                {
                    using (Stream stream = new FileStream(pathOfSettingsFile, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        appSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            FileMode fileMode;
            string pathOfSettingsFile = Environment.CurrentDirectory;

            pathOfSettingsFile += k_FileName;
            fileMode = File.Exists(pathOfSettingsFile) ? FileMode.Truncate : FileMode.CreateNew;

            if (!this.RememberMe)
            {
                this.LastAccessToken = null;
            }

            using (Stream stream = new FileStream(pathOfSettingsFile, fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}
