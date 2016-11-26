using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenGrab {
    public class ScreenShoot {

        bool clickFirst, clickSecond, final;
        private int x1, y1, x2, y2;
        private int screenWeidth = 0, screenHeight = 0;
        private Bitmap picture;
        bool moveble = true;
        
        string datatime = "";
        public ScreenShoot() {
            // Booleans for doing screen 
            clickFirst = false;
            clickSecond = false;
            final = false;

            // Cycle for multiply screen
            for (int i = 0; i < Screen.AllScreens.Length; i++) {
                screenWeidth += Screen.AllScreens[i].Bounds.Width;
                if (screenHeight < Screen.AllScreens[i].Bounds.Height)
                    screenHeight = Screen.AllScreens[i].Bounds.Height;
            }

            datatime = DataTime();
        }

        public string DataTime() {
            return " " +
                DateTime.Now.Day + "-" +
                DateTime.Now.Month + "-" +
                DateTime.Now.Year + " - " +
                DateTime.Now.Hour + "-" +
                DateTime.Now.Minute + "-" +
                DateTime.Now.Second;
        }

        public void CreateScreen() {
            Graphics graph = null;
            picture = new Bitmap(screenWeidth, screenHeight);
            graph = Graphics.FromImage(picture);
            graph.CopyFromScreen(0, 0, 0, 0, picture.Size);
        }

        // Fit picture to pictureBox, optimize picbox size
        public void OptimizePictureBox(PictureBox pictureBox) {
            bool dontMovebleWidth = false, dontMovebleHeight = false;
            if (picture.Size.Width < pictureBox.Width) {
                pictureBox.Location = new Point(pictureBox.Location.X + (pictureBox.Size.Width - picture.Size.Width) / 2, pictureBox.Location.Y);
                pictureBox.Width = picture.Width;
                dontMovebleWidth = true;
            }

            if (picture.Size.Height < pictureBox.Height) {
                pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + (pictureBox.Size.Height - picture.Size.Height) / 2);
                pictureBox.Height = picture.Height;
                dontMovebleHeight = true;
            }

            if (dontMovebleHeight && dontMovebleWidth)
                Moveble = false;
        }

        public void SaveScreen(String name) {
            picture.Save(name + datatime + ".bmp");
        }

        public int ScreenWeidth {
            get {
                return screenWeidth;
            }

            set {
                screenWeidth = value;
            }
        }

        public int ScreenHeight {
            get {
                return screenHeight;
            }

            set {
                screenHeight = value;
            }
        }

        public Bitmap Bmp {
            get {
                return picture;
            }

            set {
                picture = value;
            }
        }

        public int X1 {
            get {
                return x1;
            }

            set {
                x1 = value;
            }
        }

        public int Y1 {
            get {
                return y1;
            }

            set {
                y1 = value;
            }
        }

        public int X2 {
            get {
                return x2;
            }

            set {
                x2 = value;
            }
        }

        public int Y2 {
            get {
                return y2;
            }

            set {
                y2 = value;
            }
        }

        public bool ClickFirst {
            get {
                return clickFirst;
            }

            set {
                clickFirst = value;
            }
        }

        public bool ClickSecond {
            get {
                return clickSecond;
            }

            set {
                clickSecond = value;
            }
        }

        public bool Final {
            get {
                return final;
            }

            set {
                final = value;
            }
        }

        public bool Moveble {
            get {
                return moveble;
            }

            set {
                moveble = value;
            }
        }

        public string Datatime {
            get {
                return datatime;
            }

            set {
                datatime = value;
            }
        }
    }
}
