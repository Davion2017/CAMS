namespace CAMS.Admin
{
    partial class FrmTeacherAdd
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
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.cbxDegree = new System.Windows.Forms.ComboBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.rtxtIntroduction = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtRePasswd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTitle
            // 
            this.cbxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTitle.Font = new System.Drawing.Font("宋体", 14F);
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Location = new System.Drawing.Point(294, 164);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(143, 27);
            this.cbxTitle.TabIndex = 33;
            // 
            // cbxDegree
            // 
            this.cbxDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDegree.Font = new System.Drawing.Font("宋体", 14F);
            this.cbxDegree.FormattingEnabled = true;
            this.cbxDegree.Location = new System.Drawing.Point(697, 96);
            this.cbxDegree.Name = "cbxDegree";
            this.cbxDegree.Size = new System.Drawing.Size(143, 27);
            this.cbxDegree.TabIndex = 32;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnFemale.Location = new System.Drawing.Point(386, 97);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(42, 20);
            this.rbtnFemale.TabIndex = 31;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Checked = true;
            this.rbtnMan.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnMan.Location = new System.Drawing.Point(294, 97);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(42, 20);
            this.rbtnMan.TabIndex = 30;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "男";
            this.rbtnMan.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCancel.Location = new System.Drawing.Point(561, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(244, 429);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 31);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "确认添加";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Font = new System.Drawing.Font("宋体", 12F);
            this.btnPhoto.Location = new System.Drawing.Point(24, 330);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(92, 31);
            this.btnPhoto.TabIndex = 27;
            this.btnPhoto.Text = "选择头像";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(12, 123);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(124, 161);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 26;
            this.picPhoto.TabStop = false;
            // 
            // rtxtIntroduction
            // 
            this.rtxtIntroduction.Font = new System.Drawing.Font("宋体", 14F);
            this.rtxtIntroduction.Location = new System.Drawing.Point(697, 172);
            this.rtxtIntroduction.Name = "rtxtIntroduction";
            this.rtxtIntroduction.Size = new System.Drawing.Size(248, 216);
            this.rtxtIntroduction.TabIndex = 25;
            this.rtxtIntroduction.Text = "";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 14F);
            this.txtName.Location = new System.Drawing.Point(697, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 29);
            this.txtName.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(572, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "教学简介：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F);
            this.label5.Location = new System.Drawing.Point(169, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(572, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "学位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(169, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "职称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(572, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(169, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "教工号：";
            // 
            // txtTcode
            // 
            this.txtTcode.Font = new System.Drawing.Font("宋体", 14F);
            this.txtTcode.Location = new System.Drawing.Point(294, 26);
            this.txtTcode.Name = "txtTcode";
            this.txtTcode.Size = new System.Drawing.Size(143, 29);
            this.txtTcode.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14F);
            this.label7.Location = new System.Drawing.Point(169, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "密码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14F);
            this.label8.Location = new System.Drawing.Point(169, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "确认密码：";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Font = new System.Drawing.Font("宋体", 14F);
            this.txtPasswd.Location = new System.Drawing.Point(294, 237);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '●';
            this.txtPasswd.Size = new System.Drawing.Size(143, 29);
            this.txtPasswd.TabIndex = 38;
            // 
            // txtRePasswd
            // 
            this.txtRePasswd.Font = new System.Drawing.Font("宋体", 14F);
            this.txtRePasswd.Location = new System.Drawing.Point(294, 308);
            this.txtRePasswd.Name = "txtRePasswd";
            this.txtRePasswd.PasswordChar = '●';
            this.txtRePasswd.Size = new System.Drawing.Size(143, 29);
            this.txtRePasswd.TabIndex = 39;
            // 
            // FrmTeacherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 527);
            this.Controls.Add(this.txtRePasswd);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTitle);
            this.Controls.Add(this.cbxDegree);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.rtxtIntroduction);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmTeacherAdd";
            this.Text = "添加教师";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTitle;
        private System.Windows.Forms.ComboBox cbxDegree;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.RichTextBox rtxtIntroduction;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtRePasswd;
    }
}