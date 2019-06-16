namespace CAMS.Admin
{
    partial class FrmTeacherInfo
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
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtIntroduction = new System.Windows.Forms.RichTextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labDegree = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(31, 114);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(124, 161);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(239, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(519, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(519, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "职称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(239, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "学位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(239, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "教学简介：";
            // 
            // rtxtIntroduction
            // 
            this.rtxtIntroduction.Font = new System.Drawing.Font("宋体", 12F);
            this.rtxtIntroduction.Location = new System.Drawing.Point(334, 249);
            this.rtxtIntroduction.Name = "rtxtIntroduction";
            this.rtxtIntroduction.ReadOnly = true;
            this.rtxtIntroduction.Size = new System.Drawing.Size(320, 163);
            this.rtxtIntroduction.TabIndex = 6;
            this.rtxtIntroduction.Text = "";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 12F);
            this.labName.Location = new System.Drawing.Point(301, 62);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(56, 16);
            this.labName.TabIndex = 7;
            this.labName.Text = "姓名：";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("宋体", 12F);
            this.labGender.Location = new System.Drawing.Point(581, 62);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(56, 16);
            this.labGender.TabIndex = 8;
            this.labGender.Text = "姓名：";
            // 
            // labDegree
            // 
            this.labDegree.AutoSize = true;
            this.labDegree.Font = new System.Drawing.Font("宋体", 12F);
            this.labDegree.Location = new System.Drawing.Point(301, 160);
            this.labDegree.Name = "labDegree";
            this.labDegree.Size = new System.Drawing.Size(56, 16);
            this.labDegree.TabIndex = 9;
            this.labDegree.Text = "姓名：";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("宋体", 12F);
            this.labTitle.Location = new System.Drawing.Point(581, 160);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(56, 16);
            this.labTitle.TabIndex = 10;
            this.labTitle.Text = "姓名：";
            // 
            // FrmTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labDegree);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.rtxtIntroduction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPhoto);
            this.Name = "FrmTeacherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeacherInfo";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtIntroduction;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labDegree;
        private System.Windows.Forms.Label labTitle;
    }
}