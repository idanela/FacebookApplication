using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace FacebookAppUI
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        private const string k_AppsetiingXmlName = "\\AppSettings.xml";


        private AppSettings()
        {
            LastWindowLocation = new Point(50, 50);
            LastWindowSize = new Size(1100, 750);
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            if(File.Exists(Directory.GetCurrentDirectory() + k_AppsetiingXmlName))
            {
                using (Stream stream = new FileStream(Directory.GetCurrentDirectory() + k_AppsetiingXmlName, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(Directory.GetCurrentDirectory() + k_AppsetiingXmlName, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            
        }

        public static AppSettings CreateDefaultOrLoadDataFromFile()
        {
            AppSettings appSettings = null;

            if(File.Exists(Directory.GetCurrentDirectory() + k_AppsetiingXmlName))
            {
                using (Stream stream = new FileStream(Directory.GetCurrentDirectory() + k_AppsetiingXmlName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }
            
            return appSettings;      
        }
    }
}
