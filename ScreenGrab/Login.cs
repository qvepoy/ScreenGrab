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
    public partial class Login : Form {
		
		int pas, login;
		
        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2,
                                     Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Login_Deactivate(object sender, EventArgs e) {
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
