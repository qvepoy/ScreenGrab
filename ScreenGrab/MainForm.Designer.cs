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
            this.panelToBuffer = new System.Windows.Forms.Panel();
            this.radioButtonSaveLinkToBuffer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonSavePictureToBuffer = new System.Windows.Forms.RadioButton();
            this.panelSaveTo = new System.Windows.Forms.Panel();
            this.radioButtonSaveToCloud = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonSaveToDisk = new System.Windows.Forms.RadioButton();
            this.checkBoxSaveWithoutEdit = new System.Windows.Forms.CheckBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelToBuffer.SuspendLayout();
            this.panelSaveTo.SuspendLayout();
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
            this.tabControl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 348);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panelToBuffer);
            this.tabPage1.Controls.Add(this.panelSaveTo);
            this.tabPage1.Controls.Add(this.checkBoxSaveWithoutEdit);
            this.tabPage1.Controls.Add(this.textBoxScreen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonCreateClip);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelToBuffer
            // 
            this.panelToBuffer.Controls.Add(this.radioButtonSaveLinkToBuffer);
            this.panelToBuffer.Controls.Add(this.label4);
            this.panelToBuffer.Controls.Add(this.radioButtonSavePictureToBuffer);
            this.panelToBuffer.Enabled = false;
            this.panelToBuffer.Location = new System.Drawing.Point(49, 121);
            this.panelToBuffer.Name = "panelToBuffer";
            this.panelToBuffer.Size = new System.Drawing.Size(235, 32);
            this.panelToBuffer.TabIndex = 17;
            // 
            // radioButtonSaveLinkToBuffer
            // 
            this.radioButtonSaveLinkToBuffer.AutoSize = true;
            this.radioButtonSaveLinkToBuffer.Location = new System.Drawing.Point(162, 5);
            this.radioButtonSaveLinkToBuffer.Name = "radioButtonSaveLinkToBuffer";
            this.radioButtonSaveLinkToBuffer.Size = new System.Drawing.Size(51, 24);
            this.radioButtonSaveLinkToBuffer.TabIndex = 15;
            this.radioButtonSaveLinkToBuffer.TabStop = true;
            this.radioButtonSaveLinkToBuffer.Text = "Link";
            this.radioButtonSaveLinkToBuffer.UseVisualStyleBackColor = true;
            this.radioButtonSaveLinkToBuffer.CheckedChanged += new System.EventHandler(this.radioButtonSaveLinkToBuffer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Buffer:";
            // 
            // radioButtonSavePictureToBuffer
            // 
            this.radioButtonSavePictureToBuffer.AutoSize = true;
            this.radioButtonSavePictureToBuffer.Location = new System.Drawing.Point(86, 5);
            this.radioButtonSavePictureToBuffer.Name = "radioButtonSavePictureToBuffer";
            this.radioButtonSavePictureToBuffer.Size = new System.Drawing.Size(68, 24);
            this.radioButtonSavePictureToBuffer.TabIndex = 14;
            this.radioButtonSavePictureToBuffer.TabStop = true;
            this.radioButtonSavePictureToBuffer.Text = "Picture";
            this.radioButtonSavePictureToBuffer.UseVisualStyleBackColor = true;
            this.radioButtonSavePictureToBuffer.CheckedChanged += new System.EventHandler(this.radioButtonSavePictureToBuffer_CheckedChanged);
            // 
            // panelSaveTo
            // 
            this.panelSaveTo.Controls.Add(this.radioButtonSaveToCloud);
            this.panelSaveTo.Controls.Add(this.label3);
            this.panelSaveTo.Controls.Add(this.radioButtonSaveToDisk);
            this.panelSaveTo.Enabled = false;
            this.panelSaveTo.Location = new System.Drawing.Point(49, 83);
            this.panelSaveTo.Name = "panelSaveTo";
            this.panelSaveTo.Size = new System.Drawing.Size(235, 32);
            this.panelSaveTo.TabIndex = 16;
            // 
            // radioButtonSaveToCloud
            // 
            this.radioButtonSaveToCloud.AutoSize = true;
            this.radioButtonSaveToCloud.Location = new System.Drawing.Point(162, 5);
            this.radioButtonSaveToCloud.Name = "radioButtonSaveToCloud";
            this.radioButtonSaveToCloud.Size = new System.Drawing.Size(62, 24);
            this.radioButtonSaveToCloud.TabIndex = 13;
            this.radioButtonSaveToCloud.TabStop = true;
            this.radioButtonSaveToCloud.Text = "Cloud";
            this.radioButtonSaveToCloud.UseVisualStyleBackColor = true;
            this.radioButtonSaveToCloud.CheckedChanged += new System.EventHandler(this.radioButtonSaveToCloud_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Save to:";
            // 
            // radioButtonSaveToDisk
            // 
            this.radioButtonSaveToDisk.AutoSize = true;
            this.radioButtonSaveToDisk.Location = new System.Drawing.Point(86, 5);
            this.radioButtonSaveToDisk.Name = "radioButtonSaveToDisk";
            this.radioButtonSaveToDisk.Size = new System.Drawing.Size(53, 24);
            this.radioButtonSaveToDisk.TabIndex = 12;
            this.radioButtonSaveToDisk.TabStop = true;
            this.radioButtonSaveToDisk.Text = "Disc";
            this.radioButtonSaveToDisk.UseVisualStyleBackColor = true;
            this.radioButtonSaveToDisk.CheckedChanged += new System.EventHandler(this.radioButtonSaveToDisk_CheckedChanged);
            // 
            // checkBoxSaveWithoutEdit
            // 
            this.checkBoxSaveWithoutEdit.AutoSize = true;
            this.checkBoxSaveWithoutEdit.Location = new System.Drawing.Point(106, 53);
            this.checkBoxSaveWithoutEdit.Name = "checkBoxSaveWithoutEdit";
            this.checkBoxSaveWithoutEdit.Size = new System.Drawing.Size(129, 24);
            this.checkBoxSaveWithoutEdit.TabIndex = 11;
            this.checkBoxSaveWithoutEdit.Text = "Save without edit";
            this.checkBoxSaveWithoutEdit.UseVisualStyleBackColor = true;
            this.checkBoxSaveWithoutEdit.CheckedChanged += new System.EventHandler(this.checkBoxSaveWithoutEdit_CheckedChanged);
            // 
            // textBoxScreen
            // 
            this.textBoxScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxScreen.Location = new System.Drawing.Point(75, 164);
            this.textBoxScreen.MaxLength = 30;
            this.textBoxScreen.Multiline = true;
            this.textBoxScreen.Name = "textBoxScreen";
            this.textBoxScreen.Size = new System.Drawing.Size(244, 23);
            this.textBoxScreen.TabIndex = 3;
            this.textBoxScreen.Click += new System.EventHandler(this.textBoxScreen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "labelLog";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Collection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Screen Grab";
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
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.InitialImage = null;
            this.pictureBoxClose.Location = new System.Drawing.Point(310, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBoxHead.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHead.Image")));
            this.pictureBoxHead.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(350, 40);
            this.pictureBoxHead.TabIndex = 2;
            this.pictureBoxHead.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(96, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 401);
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
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelToBuffer.ResumeLayout(false);
            this.panelToBuffer.PerformLayout();
            this.panelSaveTo.ResumeLayout(false);
            this.panelSaveTo.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSaveWithoutEdit;
        private System.Windows.Forms.RadioButton radioButtonSaveLinkToBuffer;
        private System.Windows.Forms.RadioButton radioButtonSavePictureToBuffer;
        private System.Windows.Forms.RadioButton radioButtonSaveToCloud;
        private System.Windows.Forms.RadioButton radioButtonSaveToDisk;
        private System.Windows.Forms.Panel panelToBuffer;
        private System.Windows.Forms.Panel panelSaveTo;
        public System.Windows.Forms.Button button1;
    }
}

