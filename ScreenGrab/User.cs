using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenGrab
{
    public class User {

        // User properties
        string username;
        string password;

        // Settings
        bool firstLaunch = false;
        string language;

        bool saveWithoutEdit = false;
        bool saveToDiskInstant = false;
        bool saveToCloudInstant = false;
        bool savePictureToBuffer = false;
        bool saveLinkToBuffer = false;

        public User() {
            LoadSettings();
        }

        public void UserUpdate() {

        }

        void LoadSettings() {
            string path = "settings.ini";
            try {

                if (File.Exists(path)) {
                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path)) {
                        string s = "";
                        while ((s = sr.ReadLine()) != null) {
                            Console.WriteLine(s);
                        }
                    }
                } else {
                    // Create the file.
                    using (FileStream fs = File.Create(path)) {
                        Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                }
            }

            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
