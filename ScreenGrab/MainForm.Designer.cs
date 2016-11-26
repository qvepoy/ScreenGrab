namespace ScreenGrab {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCreateClip = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveToDisk = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveLink = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSavePictureToBuffer = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveToCloud = new System.Windows.Forms.CheckBox();
            this.textBoxScreen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.screenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateClip
            // 
            this.buttonCreateClip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.buttonCreateClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateClip.ForeColor = System.Drawing.Color.White;
            this.buttonCreateClip.Location = new System.Drawing.Point(132, 275);
            this.buttonCreateClip.Name = "buttonCreateClip";
            this.buttonCreateClip.Size = new System.Drawing.Size(81, 33);
            this.buttonCreateClip.TabIndex = 0;
            this.buttonCreateClip.Text = "Screen";
            this.buttonCreateClip.UseVisualStyleBackColor = false;
            this.buttonCreateClip.Click += new System.EventHandler(this.buttonCreateClip_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("OpenSymbol", 15F);
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 348);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxScreen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonCreateClip);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSaveToDisk);
            this.groupBox1.Controls.Add(this.checkBoxSaveLink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxSavePictureToBuffer);
            this.groupBox1.Controls.Add(this.checkBoxSaveToCloud);
            this.groupBox1.Location = new System.Drawing.Point(13, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 141);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Without Editing";
            // 
            // checkBoxSaveToDisk
            // 
            this.checkBoxSaveToDisk.AutoSize = true;
            this.checkBoxSaveToDisk.Location = new System.Drawing.Point(97, 31);
            this.checkBoxSaveToDisk.Name = "checkBoxSaveToDisk";
            this.checkBoxSaveToDisk.Size = new System.Drawing.Size(58, 24);
            this.checkBoxSaveToDisk.TabIndex = 5;
            this.checkBoxSaveToDisk.Text = "Disk";
            this.checkBoxSaveToDisk.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveLink
            // 
            this.checkBoxSaveLink.AutoSize = true;
            this.checkBoxSaveLink.Location = new System.Drawing.Point(97, 108);
            this.checkBoxSaveLink.Name = "checkBoxSaveLink";
            this.checkBoxSaveLink.Size = new System.Drawing.Size(55, 24);
            this.checkBoxSaveLink.TabIndex = 9;
            this.checkBoxSaveLink.Text = "Link";
            this.checkBoxSaveLink.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Save to:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Buffer:";
            // 
            // checkBoxSavePictureToBuffer
            // 
            this.checkBoxSavePictureToBuffer.AutoSize = true;
            this.checkBoxSavePictureToBuffer.Location = new System.Drawing.Point(97, 88);
            this.checkBoxSavePictureToBuffer.Name = "checkBoxSavePictureToBuffer";
            this.checkBoxSavePictureToBuffer.Size = new System.Drawing.Size(74, 24);
            this.checkBoxSavePictureToBuffer.TabIndex = 6;
            this.checkBoxSavePictureToBuffer.Text = "Picture";
            this.checkBoxSavePictureToBuffer.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveToCloud
            // 
            this.checkBoxSaveToCloud.AutoSize = true;
            this.checkBoxSaveToCloud.Location = new System.Drawing.Point(97, 52);
            this.checkBoxSaveToCloud.Name = "checkBoxSaveToCloud";
            this.checkBoxSaveToCloud.Size = new System.Drawing.Size(67, 24);
            this.checkBoxSaveToCloud.TabIndex = 7;
            this.checkBoxSaveToCloud.Text = "Cloud";
            this.checkBoxSaveToCloud.UseVisualStyleBackColor = true;
            // 
            // textBoxScreen
            // 
            this.textBoxScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxScreen.Location = new System.Drawing.Point(79, 16);
            this.textBoxScreen.MaxLength = 30;
            this.textBoxScreen.Multiline = true;
            this.textBoxScreen.Name = "textBoxScreen";
            this.textBoxScreen.Size = new System.Drawing.Size(244, 23);
            this.textBoxScreen.TabIndex = 3;
            this.textBoxScreen.Click += new System.EventHandler(this.textBoxScreen_Click);
            this.textBoxScreen.TextChanged += new System.EventHandler(this.textBoxScreen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "labelLog";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Collection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screenToolStripMenuItem,
            this.nothingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 70);
            this.contextMenuStrip.MouseCaptureChanged += new System.EventHandler(this.contextMenuStrip_MouseCaptureChanged);
            // 
            // screenToolStripMenuItem
            // 
            this.screenToolStripMenuItem.Name = "screenToolStripMenuItem";
            this.screenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.screenToolStripMenuItem.Text = "Screen";
            this.screenToolStripMenuItem.Click += new System.EventHandler(this.buttonCreateClip_Click);
            // 
            // nothingToolStripMenuItem
            // 
            this.nothingToolStripMenuItem.Name = "nothingToolStripMenuItem";
            this.nothingToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.nothingToolStripMenuItem.Text = "Nothing";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.pictureBoxClose.Image = global::ScreenGrab.Properties.Resources.cancel;
            this.pictureBoxClose.InitialImage = null;
            this.pictureBoxClose.Location = new System.Drawing.Point(310, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxClose_Paint);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBoxHead.Image = global::ScreenGrab.Properties.Resources.head;
            this.pictureBoxHead.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(350, 40);
            this.pictureBoxHead.TabIndex = 2;
            this.pictureBoxHead.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxHead);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonCreateClip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxHead;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nothingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSaveToCloud;
        private System.Windows.Forms.CheckBox checkBoxSavePictureToBuffer;
        private System.Windows.Forms.CheckBox checkBoxSaveToDisk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSaveLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

