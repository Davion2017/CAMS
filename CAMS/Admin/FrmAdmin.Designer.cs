namespace CAMS.Admin
{
    partial class FrmAdmin
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
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnStu = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("宋体", 10F);
            this.labelAccount.ForeColor = System.Drawing.Color.Red;
            this.labelAccount.Location = new System.Drawing.Point(22, 273);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(35, 14);
            this.labelAccount.TabIndex = 1;
            this.labelAccount.Text = "账号";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("宋体", 10F);
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(96, 273);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 14);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "时间";
            // 
            // btnStu
            // 
            this.btnStu.Font = new System.Drawing.Font("宋体", 11F);
            this.btnStu.Location = new System.Drawing.Point(80, 56);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(75, 36);
            this.btnStu.TabIndex = 3;
            this.btnStu.Text = "学生管理";
            this.btnStu.UseVisualStyleBackColor = true;
            this.btnStu.Click += new System.EventHandler(this.BtnStu_Click);
            // 
            // btnTea
            // 
            this.btnTea.Font = new System.Drawing.Font("宋体", 11F);
            this.btnTea.Location = new System.Drawing.Point(80, 123);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(75, 36);
            this.btnTea.TabIndex = 4;
            this.btnTea.Text = "教师管理";
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.BtnTea_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("宋体", 11F);
            this.btnCourse.Location = new System.Drawing.Point(80, 186);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(75, 36);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "课程管理";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.BtnCourse_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 296);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnTea);
            this.Controls.Add(this.btnStu);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员";
            this.Activated += new System.EventHandler(this.FrmAdmin_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnCourse;
    }
}