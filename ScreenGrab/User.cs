using System;
using System.Collections.Generic;
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

        bool saveToDiskInstant = false;
        bool saveToCloudInstant = false;
        bool savePictureToBuffer = false;
        bool saveLink = false;

        bool withoutEditing = false;

        public User() {
            // Opening file with settings

            // Loading settings from file 

            language = "Russian"; 
        }

        public void UserUpdate() {

        }
    }
}
