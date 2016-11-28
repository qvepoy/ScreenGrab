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
        int x1 = 0, y1 = 0;

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
            // Click action
            if (screenFromMainForm.Final != true && e.Button == MouseButtons.Left) {
                if (screenFromMainForm.ClickFirst == false) {
                    screenFromMainForm.X1 = MousePosition.X;
                    screenFromMainForm.Y1 = MousePosition.Y;
                    screenFromMainForm.ClickFirst = true;

                    // FOR ALPHA CHANNEL
                    x1 = screenFromMainForm.X1;
                    y1 = screenFromMainForm.Y1;
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

                    // Go to edit form
                    EditForm editForm = new EditForm();
                    editForm.screenFromScreenForm = screenFromMainForm;
                    editForm.Show();
                }
            }

            // Go back if right button
            if (e.Button == MouseButtons.Right) {
                if (screenFromMainForm.ClickFirst == true)
                    screenFromMainForm.ClickFirst = false;
                else
                    this.Close();
            }
        }

        private void ScreenForm_MouseUp(object sender, MouseEventArgs e) {
            // Drag and drop action 
            screenFromMainForm.X2 = MousePosition.X;
            screenFromMainForm.Y2 = MousePosition.Y;

            if (screenFromMainForm.X2 != screenFromMainForm.X1 &&
                screenFromMainForm.Y2 != screenFromMainForm.Y1) {
                screenFromMainForm.ClickSecond = true;

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

                // Go to edit form
                EditForm editForm = new EditForm();
                editForm.screenFromScreenForm = screenFromMainForm;
                editForm.Show();
            }
        }

        private Point MousePoint = new Point();

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            MousePoint = e.Location;
            ((PictureBox)sender).Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            // Coordinates 
            e.Graphics.DrawString(MousePoint.ToString(), this.Font, Brushes.Black,
                new Point(MousePoint.X, MousePoint.Y - 15));
            e.Graphics.DrawString(MousePoint.ToString(), this.Font, Brushes.White,
                new Point(MousePoint.X-1, MousePoint.Y - 16));

            // Draw four gray blocks with alpha channel
            int minx, miny, maxx, maxy;
            if (x1 < MousePoint.X) {
                minx = x1;
                maxx = MousePoint.X;
            } else {
                minx = MousePoint.X;
                maxx = x1;
            }

            if (y1 < MousePoint.Y) {
                miny = y1;
                maxy = MousePoint.Y;
            } else {
                miny = MousePoint.Y;
                maxy = y1;
            }
            
            SolidBrush Brush = new SolidBrush(Color.FromArgb(60, 0, 0, 0));
            
            if (screenFromMainForm.ClickFirst == true) {
                e.Graphics.FillRectangle(Brush, 0, 0, pictureBoxScreen.Size.Width, miny);
                e.Graphics.FillRectangle(Brush, 0, miny, minx, pictureBoxScreen.Size.Height);
                e.Graphics.FillRectangle(Brush, maxx, miny, pictureBoxScreen.Size.Width, pictureBoxScreen.Size.Height);
                e.Graphics.FillRectangle(Brush, minx, maxy, maxx-minx, pictureBoxScreen.Size.Height);
            } else {
                e.Graphics.FillRectangle(Brush, 0, 0, pictureBoxScreen.Size.Width, pictureBoxScreen.Size.Height);
            }

            // Lupa 
            Point point = MousePoint;
            point.X += 20; point.Y += 20;
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
