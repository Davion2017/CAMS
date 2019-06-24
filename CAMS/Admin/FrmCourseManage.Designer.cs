namespace CAMS.Admin
{
    partial class FrmCourseManage
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
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isdegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tchour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.linkCourse = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourse
            // 
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.number,
            this.cname,
            this.isdegree,
            this.score,
            this.chour,
            this.lhour,
            this.tchour,
            this.tlhour,
            this.semester});
            this.dgvCourse.Location = new System.Drawing.Point(12, 12);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.Size = new System.Drawing.Size(850, 273);
            this.dgvCourse.TabIndex = 0;
            this.dgvCourse.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvCourse_DataBindingComplete);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "课程性质";
            this.name.Name = "name";
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "课程号";
            this.number.Name = "number";
            // 
            // cname
            // 
            this.cname.DataPropertyName = "cname";
            this.cname.HeaderText = "课程名称标识";
            this.cname.Name = "cname";
            // 
            // isdegree
            // 
            this.isdegree.DataPropertyName = "isdegree";
            this.isdegree.HeaderText = "学位课程";
            this.isdegree.Name = "isdegree";
            // 
            // score
            // 
            this.score.DataPropertyName = "score";
            this.score.HeaderText = "学分";
            this.score.Name = "score";
            // 
            // chour
            // 
            this.chour.DataPropertyName = "chour";
            this.chour.HeaderText = "周课堂学时";
            this.chour.Name = "chour";
            // 
            // lhour
            // 
            this.lhour.DataPropertyName = "lhour";
            this.lhour.HeaderText = "周实验学时";
            this.lhour.Name = "lhour";
            // 
            // tchour
            // 
            this.tchour.DataPropertyName = "tchour";
            this.tchour.HeaderText = "课堂总学时";
            this.tchour.Name = "tchour";
            // 
            // tlhour
            // 
            this.tlhour.DataPropertyName = "tlhour";
            this.tlhour.HeaderText = "实践总学时";
            this.tlhour.Name = "tlhour";
            // 
            // semester
            // 
            this.semester.DataPropertyName = "semester";
            this.semester.HeaderText = "开课时间";
            this.semester.Name = "semester";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(209, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 43);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改课程";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDelete.Location = new System.Drawing.Point(450, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除课程";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F);
            this.btnAdd.Location = new System.Drawing.Point(671, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加课程";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // linkCourse
            // 
            this.linkCourse.AutoSize = true;
            this.linkCourse.Font = new System.Drawing.Font("宋体", 14F);
            this.linkCourse.Location = new System.Drawing.Point(21, 321);
            this.linkCourse.Name = "linkCourse";
            this.linkCourse.Size = new System.Drawing.Size(85, 19);
            this.linkCourse.TabIndex = 9;
            this.linkCourse.TabStop = true;
            this.linkCourse.Text = "课程信息";
            this.linkCourse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCourse_LinkClicked);
            // 
            // FrmCourseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 411);
            this.Controls.Add(this.linkCourse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvCourse);
            this.Name = "FrmCourseManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.Load += new System.EventHandler(this.FrmCourseManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn isdegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn chour;
        private System.Windows.Forms.DataGridViewTextBoxColumn lhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tchour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel linkCourse;
    }
}