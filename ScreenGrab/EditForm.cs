using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ScreenGrab
{
    public partial class EditForm : Form     {

        public ScreenShoot screenFromScreenForm;
        public EditForm()
        {
            InitializeComponent();
            ScreenForm.ActiveForm.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // Design
            pictureBoxClose.Image = new Bitmap("icon/cross.png");
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Подгон размера pictureBox под размер картинки и его центрирование
            pictureBox.Image = screenFromScreenForm.Bmp;
            screenFromScreenForm.OptimizePictureBox(pictureBox);
            
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonCopyToClipboard_Click(object sender, EventArgs e) {
            Clipboard.SetImage(pictureBox.Image);
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e) {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BMP Image (*.bmp)|*.bmp|JPG Image (*.jpg)|*.jpg";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "picture " + screenFromScreenForm.Datatime;
            ImageFormat format = ImageFormat.Bmp;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string ext = Path.GetExtension(saveFileDialog.FileName);
                switch (ext) {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                pictureBox.Image.Save(saveFileDialog.FileName, format);
            }

            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e) {
            // ПОТЕНЦИАЛЬНЫЙ КОД
        }
        

        //int lx = 0, ly = 0, cx = 0, cy = 0;
        //private void pictureBox_Paint(object sender, PaintEventArgs e) {
        //    e.Graphics.DrawImageUnscaled(pictureBox.Image, cx, cy);
        //}

        //private void pictureBox_MouseDown(object sender, MouseEventArgs e) {
        //    lx = e.X;
        //    ly = e.Y;
        //}

        //private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
        //    if (pictureBox.Capture) {
        //        int dx = e.X - lx;
        //        int dy = e.Y - ly;
        //        cx += dx;
        //        cy += dy;
        //        lx = e.X;
        //        ly = e.Y;
        //        pictureBox.Invalidate();
        //    }
        //}
    }
}
