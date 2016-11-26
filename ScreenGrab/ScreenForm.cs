using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenGrab {
    public partial class ScreenForm : Form {

        private MainForm mainForm;
        public ScreenShoot screenFromMainForm;
        public ScreenForm() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            mainForm = this.Owner as MainForm;
            pictureBoxScreen.Image = (Image)screenFromMainForm.Bmp;
            pictureBoxScreen.Size = new Size(screenFromMainForm.Bmp.Size.Width, screenFromMainForm.Bmp.Size.Height);
            pictureBoxScreen.Location = new Point(0, 0);
            
            this.Size = new Size(screenFromMainForm.Bmp.Size.Width, screenFromMainForm.Bmp.Size.Height);
            this.Top = 0;
            this.Left = 0;

            this.TopMost = true;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                this.Close();
            if (screenFromMainForm.Final != true) {
                if (screenFromMainForm.ClickFirst == false) {
                    screenFromMainForm.X1 = MousePosition.X;
                    screenFromMainForm.Y1 = MousePosition.Y;
                    screenFromMainForm.ClickFirst = true;
                } else {
                    screenFromMainForm.X2 = MousePosition.X;
                    screenFromMainForm.Y2 = MousePosition.Y;
                    screenFromMainForm.ClickSecond = true;
                }
                
                if (screenFromMainForm.ClickSecond == true) {
                    if (screenFromMainForm.X1 > screenFromMainForm.X2) {
                        int temp = screenFromMainForm.X1;
                        screenFromMainForm.X1 = screenFromMainForm.X2;
                        screenFromMainForm.X2 = temp;
                    }

                    if (screenFromMainForm.Y1 > screenFromMainForm.Y2) {
                        int temp = screenFromMainForm.Y1;
                        screenFromMainForm.Y1 = screenFromMainForm.Y2;
                        screenFromMainForm.Y2 = temp;
                    }
                    
                    screenFromMainForm.Final = true;
                    // Resize picture after cropping
                    screenFromMainForm.Bmp = screenFromMainForm.Bmp.Clone(new Rectangle(screenFromMainForm.X1, screenFromMainForm.Y1, screenFromMainForm.X2 - screenFromMainForm.X1, screenFromMainForm.Y2 - screenFromMainForm.Y1), screenFromMainForm.Bmp.PixelFormat);
                    screenFromMainForm.SaveScreen("picture");

                    // Переход к форме EDIT
                    EditForm editForm = new EditForm();
                    editForm.screenFromScreenForm = screenFromMainForm;
                    editForm.Show();
                }
            }
        }

        private Point MousePoint = new Point();

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            MousePoint = e.Location;
            ((PictureBox)sender).Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawString(MousePoint.ToString(), this.Font, Brushes.Black,
                new Point(MousePoint.X, MousePoint.Y - 15));
        }

        private void ScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
    }
}
