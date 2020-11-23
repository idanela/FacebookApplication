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

        private AppSettings()
        {
            LastWindowLocation = new Point(50, 50);
            LastWindowSize = new Size(1100, 750);
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;

            if(File.Exists(@"D:\appSettings.xml"))
            {
                    using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        appSettings = serializer.Deserialize(stream) as AppSettings;
                    }
            }
            else
            {
                Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Create);
                appSettings = new AppSettings();
            }

            return appSettings;      
        }
    }
}
