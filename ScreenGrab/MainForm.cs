using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenGrab {
    public partial class MainForm : Form {
        
        // Resourses
        //private Image pictureBoxCloseImage = new Bitmap("icon/cross.png");

        // Keys for screen
        Keys screen = Keys.X; bool shift = true, ctrl = true, alt = false;
        KeyboardHook kh = new KeyboardHook(true);

        int leftCorner;

        public MainForm() {
            InitializeComponent();

            this.Visible = false;
            this.IsVisibilityChangeAllowed = false;
            
            notifyIcon.Text = "Screen Grab";

            //KeyboardHooks int z = selection=="+"? (x+y) : (x-y);
            kh.KeyDown += Kh_KeyDown;
            kh.KeyUp += Kh_KeyUp;
            textBoxScreen.Text = alt == true ? "Alt + " : "";
            textBoxScreen.Text += ctrl == true ? "Ctrl + " : "";
            textBoxScreen.Text += shift == true ? "Shift + " : "";
            textBoxScreen.Text += screen;

            //pictureBoxClose.Image = pictureBoxCloseImage;
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;

            foreach (Screen screen in Screen.AllScreens) {
                if (!screen.Primary)
                    leftCorner = screen.Bounds.Location.X;
            }

            if (leftCorner > 0)
                leftCorner = 0;
        }

        bool IsVisibilityChangeAllowed { get; set; }

        protected override void SetVisibleCore(bool value) {
            if (this.IsVisibilityChangeAllowed) {
                base.SetVisibleCore(value);
            }
        }

        private void CreateScreenShot() {
            ScreenShoot screenShot = new ScreenShoot();
            screenShot.CreateScreen(leftCorner);

            ScreenForm screenForm = new ScreenForm();
            screenForm.screenFromMainForm = screenShot;
            screenForm.Show(this);
        }

        private void buttonCreateClip_Click(object sender, EventArgs e) {
            CreateScreenShot();
        }

        private void buttonCreateClip_Click() {
            CreateScreenShot();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - 35,
                                      Screen.PrimaryScreen.Bounds.Height - this.Height - 50);
            
            notifyIcon.Visible = true;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e) {
            this.Hide();
        }
        
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.IsVisibilityChangeAllowed = true;
                this.Show();
            }

            if (e.Button == MouseButtons.Right) {
                this.Hide();
                contextMenuStrip.Hide();
                contextMenuStrip.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Application.Exit();
        }
        
        private void MainForm_Deactivate(object sender, EventArgs e) {
            contextMenuStrip.Hide();
            this.Hide();
        }
        
        private void textBoxScreen_Click(object sender, EventArgs e) {

            textBoxScreen.Enabled = false;
        }
        
        private void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt) {
            label1.Text = "The Key: " + key + Shift + Ctrl + Alt;

            if (key == screen && Shift == shift && Ctrl == ctrl && Alt == alt && textBoxScreen.Enabled == true) {
                buttonCreateClip_Click();
            }

            label1.Text += leftCorner ;



        }

        private void Kh_KeyUp(Keys key, bool Shift, bool Ctrl, bool Alt) {
            if (textBoxScreen.Enabled == false) {

                if (key != Keys.Shift && key != Keys.LControlKey && key != Keys.LMenu &&
                    key != Keys.RShiftKey && key != Keys.RControlKey && key != Keys.RMenu &&
                    key != Keys.LShiftKey) {
                    screen = key;
                    shift = Shift;
                    ctrl = Ctrl;
                    alt = Alt;

                    textBoxScreen.Text = alt == true ? "Alt + " : "";
                    textBoxScreen.Text += ctrl == true ? "Ctrl + " : "";
                    textBoxScreen.Text += shift == true ? "Shift + " : "";
                    textBoxScreen.Text += screen;
                }

                textBoxScreen.Enabled = true;
            }
        }
    }
}
