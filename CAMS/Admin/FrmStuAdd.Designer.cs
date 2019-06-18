namespace CAMS.Admin
{
    partial class FrmStuAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbboxClass = new System.Windows.Forms.ComboBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.cbboxGender = new System.Windows.Forms.ComboBox();
            this.txtboxMajor = new System.Windows.Forms.TextBox();
            this.picboxPhoto = new System.Windows.Forms.PictureBox();
            this.txtboxPwd = new System.Windows.Forms.TextBox();
            this.labelScode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F);
            this.btnAdd.Location = new System.Drawing.Point(119, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "确认添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cbboxClass
            // 
            this.cbboxClass.Font = new System.Drawing.Font("宋体", 12F);
            this.cbboxClass.FormattingEnabled = true;
            this.cbboxClass.Items.AddRange(new object[] {
            "17级软件工程(商务软件应用与开发方向)1班 ",
            "17级软件工程(软件测试方向)班 ",
            "17级软件工程(软件技术方向)1班 ",
            "17级软件工程(移动终端)2班 "});
            this.cbboxClass.Location = new System.Drawing.Point(196, 133);
            this.cbboxClass.Name = "cbboxClass";
            this.cbboxClass.Size = new System.Drawing.Size(99, 24);
            this.cbboxClass.TabIndex = 28;
            this.cbboxClass.Text = "班级";
            this.cbboxClass.SelectedIndexChanged += new System.EventHandler(this.CbboxClass_SelectedIndexChanged);
            this.cbboxClass.MouseEnter += new System.EventHandler(this.CbboxClass_MouseEnter);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(65, 163);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(62, 25);
            this.btnPhoto.TabIndex = 27;
            this.btnPhoto.Text = "选择照片";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtboxName.Location = new System.Drawing.Point(196, 40);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(78, 26);
            this.txtboxName.TabIndex = 21;
            this.txtboxName.Text = "姓名";
            // 
            // cbboxGender
            // 
            this.cbboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxGender.Font = new System.Drawing.Font("宋体", 12F);
            this.cbboxGender.FormattingEnabled = true;
            this.cbboxGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbboxGender.Location = new System.Drawing.Point(196, 72);
            this.cbboxGender.Name = "cbboxGender";
            this.cbboxGender.Size = new System.Drawing.Size(48, 24);
            this.cbboxGender.TabIndex = 26;
            // 
            // txtboxMajor
            // 
            this.txtboxMajor.Enabled = false;
            this.txtboxMajor.Font = new System.Drawing.Font("宋体", 12F);
            this.txtboxMajor.Location = new System.Drawing.Point(196, 163);
            this.txtboxMajor.Name = "txtboxMajor";
            this.txtboxMajor.Size = new System.Drawing.Size(99, 26);
            this.txtboxMajor.TabIndex = 25;
            this.txtboxMajor.Text = "专业";
            // 
            // picboxPhoto
            // 
            this.picboxPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picboxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxPhoto.Location = new System.Drawing.Point(55, 45);
            this.picboxPhoto.Name = "picboxPhoto";
            this.picboxPhoto.Size = new System.Drawing.Size(86, 113);
            this.picboxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPhoto.TabIndex = 24;
            this.picboxPhoto.TabStop = false;
            this.picboxPhoto.Tag = "";
            // 
            // txtboxPwd
            // 
            this.txtboxPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.txtboxPwd.Location = new System.Drawing.Point(196, 102);
            this.txtboxPwd.Name = "txtboxPwd";
            this.txtboxPwd.Size = new System.Drawing.Size(99, 26);
            this.txtboxPwd.TabIndex = 22;
            this.txtboxPwd.Text = "密码";
            // 
            // labelScode
            // 
            this.labelScode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScode.AutoSize = true;
            this.labelScode.Font = new System.Drawing.Font("宋体", 18F);
            this.labelScode.Location = new System.Drawing.Point(141, 9);
            this.labelScode.Name = "labelScode";
            this.labelScode.Size = new System.Drawing.Size(58, 24);
            this.labelScode.TabIndex = 29;
            this.labelScode.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "学号：";
            // 
            // FrmStuAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 265);
            this.Controls.Add(this.labelScode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbboxClass);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.cbboxGender);
            this.Controls.Add(this.txtboxMajor);
            this.Controls.Add(this.picboxPhoto);
            this.Controls.Add(this.txtboxPwd);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStuAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学生";
            this.Activated += new System.EventHandler(this.FrmStuAdd_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStuAdd_FormClosed);
            this.Load += new System.EventHandler(this.FrmStuAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbboxClass;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.ComboBox cbboxGender;
        private System.Windows.Forms.TextBox txtboxMajor;
        private System.Windows.Forms.PictureBox picboxPhoto;
        private System.Windows.Forms.TextBox txtboxPwd;
        private System.Windows.Forms.Label labelScode;
        private System.Windows.Forms.Label label1;
    }
}