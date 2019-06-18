namespace CAMS.Admin
{
    partial class FrmStuInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.课程号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程中文名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程英文名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.任课教师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.笔试成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实践成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.txtboxScode = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.cbboxGender = new System.Windows.Forms.ComboBox();
            this.txtboxMajor = new System.Windows.Forms.TextBox();
            this.picboxPhoto = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbboxClass = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 11F);
            this.btnUpdate.Location = new System.Drawing.Point(476, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "修改信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCourse);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 243);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程列表";
            // 
            // dgvCourse
            // 
            this.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程号,
            this.课程中文名,
            this.课程英文名,
            this.任课教师,
            this.学期,
            this.GPA成绩,
            this.笔试成绩,
            this.实践成绩,
            this.总成绩});
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourse.Location = new System.Drawing.Point(3, 17);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourse.Size = new System.Drawing.Size(809, 223);
            this.dgvCourse.TabIndex = 0;
            this.dgvCourse.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvCourse_DataBindingComplete);
            // 
            // 课程号
            // 
            this.课程号.DataPropertyName = "课程号";
            this.课程号.HeaderText = "课程号";
            this.课程号.Name = "课程号";
            this.课程号.Width = 66;
            // 
            // 课程中文名
            // 
            this.课程中文名.DataPropertyName = "课程中文名";
            this.课程中文名.HeaderText = "课程中文名";
            this.课程中文名.Name = "课程中文名";
            this.课程中文名.Width = 90;
            // 
            // 课程英文名
            // 
            this.课程英文名.DataPropertyName = "课程英文名";
            this.课程英文名.HeaderText = "课程英文名";
            this.课程英文名.Name = "课程英文名";
            this.课程英文名.Width = 90;
            // 
            // 任课教师
            // 
            this.任课教师.DataPropertyName = "任课教师";
            this.任课教师.HeaderText = "任课教师";
            this.任课教师.Name = "任课教师";
            this.任课教师.Width = 78;
            // 
            // 学期
            // 
            this.学期.DataPropertyName = "学期";
            this.学期.HeaderText = "学期";
            this.学期.Name = "学期";
            this.学期.Width = 54;
            // 
            // GPA成绩
            // 
            this.GPA成绩.DataPropertyName = "gpa成绩";
            this.GPA成绩.HeaderText = "GPA成绩";
            this.GPA成绩.Name = "GPA成绩";
            this.GPA成绩.Width = 72;
            // 
            // 笔试成绩
            // 
            this.笔试成绩.DataPropertyName = "笔试成绩";
            this.笔试成绩.HeaderText = "笔试成绩";
            this.笔试成绩.Name = "笔试成绩";
            this.笔试成绩.Width = 78;
            // 
            // 实践成绩
            // 
            this.实践成绩.DataPropertyName = "实践成绩";
            this.实践成绩.HeaderText = "实践成绩";
            this.实践成绩.Name = "实践成绩";
            this.实践成绩.Width = 78;
            // 
            // 总成绩
            // 
            this.总成绩.DataPropertyName = "总成绩";
            this.总成绩.HeaderText = "总成绩";
            this.总成绩.Name = "总成绩";
            this.总成绩.Width = 66;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSave.Location = new System.Drawing.Point(476, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(135, 138);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(62, 25);
            this.btnPhoto.TabIndex = 18;
            this.btnPhoto.Text = "选择照片";
            this.btnPhoto.UseVisualStyleBackColor = true;
            // 
            // txtboxScode
            // 
            this.txtboxScode.Enabled = false;
            this.txtboxScode.Location = new System.Drawing.Point(333, 19);
            this.txtboxScode.Name = "txtboxScode";
            this.txtboxScode.Size = new System.Drawing.Size(92, 21);
            this.txtboxScode.TabIndex = 13;
            this.txtboxScode.Text = "学号";
            // 
            // txtboxName
            // 
            this.txtboxName.Enabled = false;
            this.txtboxName.Location = new System.Drawing.Point(238, 19);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(78, 21);
            this.txtboxName.TabIndex = 11;
            this.txtboxName.Text = "姓名";
            // 
            // cbboxGender
            // 
            this.cbboxGender.Enabled = false;
            this.cbboxGender.FormattingEnabled = true;
            this.cbboxGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbboxGender.Location = new System.Drawing.Point(381, 58);
            this.cbboxGender.Name = "cbboxGender";
            this.cbboxGender.Size = new System.Drawing.Size(44, 20);
            this.cbboxGender.TabIndex = 17;
            // 
            // txtboxMajor
            // 
            this.txtboxMajor.Enabled = false;
            this.txtboxMajor.Location = new System.Drawing.Point(238, 111);
            this.txtboxMajor.Name = "txtboxMajor";
            this.txtboxMajor.Size = new System.Drawing.Size(187, 21);
            this.txtboxMajor.TabIndex = 16;
            this.txtboxMajor.Text = "专业";
            // 
            // picboxPhoto
            // 
            this.picboxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxPhoto.Location = new System.Drawing.Point(126, 19);
            this.picboxPhoto.Name = "picboxPhoto";
            this.picboxPhoto.Size = new System.Drawing.Size(86, 113);
            this.picboxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPhoto.TabIndex = 14;
            this.picboxPhoto.TabStop = false;
            this.picboxPhoto.Tag = "";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(238, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 21);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "密码";
            // 
            // cbboxClass
            // 
            this.cbboxClass.Enabled = false;
            this.cbboxClass.FormattingEnabled = true;
            this.cbboxClass.Items.AddRange(new object[] {
            "17级软件工程(商务软件应用与开发方向)1班 ",
            "17级软件工程(软件测试方向)班 ",
            "17级软件工程(软件技术方向)1班 ",
            "17级软件工程(移动终端)2班 "});
            this.cbboxClass.Location = new System.Drawing.Point(238, 85);
            this.cbboxClass.Name = "cbboxClass";
            this.cbboxClass.Size = new System.Drawing.Size(187, 20);
            this.cbboxClass.TabIndex = 19;
            this.cbboxClass.Text = "班级";
            // 
            // FrmStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 406);
            this.Controls.Add(this.cbboxClass);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.txtboxScode);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.cbboxGender);
            this.Controls.Add(this.txtboxMajor);
            this.Controls.Add(this.picboxPhoto);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStuInfo";
            this.ShowIcon = false;
            this.Text = "详细信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStuInfo_FormClosed);
            this.Load += new System.EventHandler(this.FrmStuInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程中文名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程英文名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 任课教师;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学期;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 笔试成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实践成绩;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总成绩;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.TextBox txtboxScode;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.ComboBox cbboxGender;
        private System.Windows.Forms.TextBox txtboxMajor;
        private System.Windows.Forms.PictureBox picboxPhoto;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbboxClass;
    }
}