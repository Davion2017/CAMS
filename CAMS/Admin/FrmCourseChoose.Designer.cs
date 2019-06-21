namespace CAMS.Admin
{
    partial class FrmCourseChoose
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
            this.btnOrganize = new System.Windows.Forms.Button();
            this.btnOffical = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labSemester = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrganize
            // 
            this.btnOrganize.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOrganize.Location = new System.Drawing.Point(132, 378);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(95, 43);
            this.btnOrganize.TabIndex = 13;
            this.btnOrganize.Text = "排课";
            this.btnOrganize.UseVisualStyleBackColor = true;
            // 
            // btnOffical
            // 
            this.btnOffical.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOffical.Location = new System.Drawing.Point(108, 300);
            this.btnOffical.Name = "btnOffical";
            this.btnOffical.Size = new System.Drawing.Size(145, 43);
            this.btnOffical.TabIndex = 12;
            this.btnOffical.Text = "开启/关闭正选";
            this.btnOffical.UseVisualStyleBackColor = true;
            // 
            // btnPlan
            // 
            this.btnPlan.Font = new System.Drawing.Font("宋体", 12F);
            this.btnPlan.Location = new System.Drawing.Point(108, 213);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(145, 43);
            this.btnPlan.TabIndex = 11;
            this.btnPlan.Text = "开启/关闭预选";
            this.btnPlan.UseVisualStyleBackColor = true;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("宋体", 14F);
            this.labStatus.Location = new System.Drawing.Point(220, 75);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(47, 19);
            this.labStatus.TabIndex = 10;
            this.labStatus.Text = "状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(91, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "当前状态为：";
            // 
            // cbxSemester
            // 
            this.cbxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSemester.Font = new System.Drawing.Font("宋体", 14F);
            this.cbxSemester.FormattingEnabled = true;
            this.cbxSemester.Location = new System.Drawing.Point(38, 137);
            this.cbxSemester.Name = "cbxSemester";
            this.cbxSemester.Size = new System.Drawing.Size(128, 27);
            this.cbxSemester.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(91, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "当前学期为：";
            // 
            // labSemester
            // 
            this.labSemester.AutoSize = true;
            this.labSemester.Font = new System.Drawing.Font("宋体", 14F);
            this.labSemester.Location = new System.Drawing.Point(220, 23);
            this.labSemester.Name = "labSemester";
            this.labSemester.Size = new System.Drawing.Size(47, 19);
            this.labSemester.TabIndex = 16;
            this.labSemester.Text = "学期";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14F);
            this.button1.Location = new System.Drawing.Point(224, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "重置学期";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmCourseChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSemester);
            this.Controls.Add(this.btnOrganize);
            this.Controls.Add(this.btnOffical);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.label1);
            this.Name = "FrmCourseChoose";
            this.Text = "选课管理";
            this.Load += new System.EventHandler(this.FrmCourseChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Button btnOffical;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSemester;
        private System.Windows.Forms.Button button1;
    }
}