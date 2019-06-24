namespace CAMS.Admin
{
    partial class FrmClassAdd
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
            this.labNumber = new System.Windows.Forms.Label();
            this.labCname = new System.Windows.Forms.Label();
            this.cbxTeacherList = new System.Windows.Forms.ComboBox();
            this.txtClassSize = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("宋体", 14F);
            this.labNumber.Location = new System.Drawing.Point(48, 53);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(66, 19);
            this.labNumber.TabIndex = 0;
            this.labNumber.Text = "课程号";
            // 
            // labCname
            // 
            this.labCname.AutoSize = true;
            this.labCname.Font = new System.Drawing.Font("宋体", 14F);
            this.labCname.Location = new System.Drawing.Point(172, 53);
            this.labCname.Name = "labCname";
            this.labCname.Size = new System.Drawing.Size(123, 19);
            this.labCname.TabIndex = 1;
            this.labCname.Text = "课程名称标识";
            // 
            // cbxTeacherList
            // 
            this.cbxTeacherList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTeacherList.Font = new System.Drawing.Font("宋体", 14F);
            this.cbxTeacherList.FormattingEnabled = true;
            this.cbxTeacherList.Location = new System.Drawing.Point(376, 52);
            this.cbxTeacherList.Name = "cbxTeacherList";
            this.cbxTeacherList.Size = new System.Drawing.Size(151, 27);
            this.cbxTeacherList.TabIndex = 2;
            // 
            // txtClassSize
            // 
            this.txtClassSize.Font = new System.Drawing.Font("宋体", 14F);
            this.txtClassSize.Location = new System.Drawing.Point(602, 50);
            this.txtClassSize.Name = "txtClassSize";
            this.txtClassSize.Size = new System.Drawing.Size(132, 29);
            this.txtClassSize.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 14F);
            this.btnOK.Location = new System.Drawing.Point(480, 115);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认添加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 14F);
            this.btnClose.Location = new System.Drawing.Point(623, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmClassAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 198);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtClassSize);
            this.Controls.Add(this.cbxTeacherList);
            this.Controls.Add(this.labCname);
            this.Controls.Add(this.labNumber);
            this.Name = "FrmClassAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加班级";
            this.Load += new System.EventHandler(this.FrmClassAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labCname;
        private System.Windows.Forms.ComboBox cbxTeacherList;
        private System.Windows.Forms.TextBox txtClassSize;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}