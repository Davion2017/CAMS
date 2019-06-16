namespace CAMS.Admin
{
    partial class FrmTeacherUpdate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtxtIntroduction = new System.Windows.Forms.RichTextBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.cbxDegree = new System.Windows.Forms.ComboBox();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(169, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(169, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "职称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(169, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "学位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F);
            this.label5.Location = new System.Drawing.Point(169, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F);
            this.label6.Location = new System.Drawing.Point(169, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "教学简介：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 14F);
            this.txtName.Location = new System.Drawing.Point(294, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 29);
            this.txtName.TabIndex = 6;
            // 
            // rtxtIntroduction
            // 
            this.rtxtIntroduction.Font = new System.Drawing.Font("宋体", 14F);
            this.rtxtIntroduction.Location = new System.Drawing.Point(294, 293);
            this.rtxtIntroduction.Name = "rtxtIntroduction";
            this.rtxtIntroduction.Size = new System.Drawing.Size(324, 103);
            this.rtxtIntroduction.TabIndex = 10;
            this.rtxtIntroduction.Text = "";
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(12, 81);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(124, 161);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 11;
            this.picPhoto.TabStop = false;
            // 
            // btnPhoto
            // 
            this.btnPhoto.Font = new System.Drawing.Font("宋体", 12F);
            this.btnPhoto.Location = new System.Drawing.Point(24, 288);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(92, 31);
            this.btnPhoto.TabIndex = 12;
            this.btnPhoto.Text = "选择头像";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.BtnPhoto_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(159, 421);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 31);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "确认修改";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCancel.Location = new System.Drawing.Point(427, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Checked = true;
            this.rbtnMan.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnMan.Location = new System.Drawing.Point(294, 102);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(42, 20);
            this.rbtnMan.TabIndex = 15;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "男";
            this.rbtnMan.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbtnFemale.Location = new System.Drawing.Point(386, 102);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(42, 20);
            this.rbtnFemale.TabIndex = 16;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // cbxDegree
            // 
            this.cbxDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDegree.Font = new System.Drawing.Font("宋体", 14F);
            this.cbxDegree.FormattingEnabled = true;
            this.cbxDegree.Location = new System.Drawing.Point(294, 159);
            this.cbxDegree.Name = "cbxDegree";
            this.cbxDegree.Size = new System.Drawing.Size(143, 27);
            this.cbxDegree.TabIndex = 17;
            // 
            // cbxTitle
            // 
            this.cbxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTitle.Font = new System.Drawing.Font("宋体", 14F);
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Location = new System.Drawing.Point(294, 223);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(143, 27);
            this.cbxTitle.TabIndex = 18;
            // 
            // FrmTeacherUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 475);
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
            this.Name = "FrmTeacherUpdate";
            this.Text = "修改信息";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtxtIntroduction;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.ComboBox cbxDegree;
        private System.Windows.Forms.ComboBox cbxTitle;
    }
}