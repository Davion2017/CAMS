namespace CAMS.Admin
{
    partial class FrmCourseSet
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
            this.dgvPlanCourse = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourseClass = new System.Windows.Forms.DataGridView();
            this.new_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_class_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.btnDelClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanCourse
            // 
            this.dgvPlanCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.cname,
            this.count});
            this.dgvPlanCourse.Location = new System.Drawing.Point(41, 82);
            this.dgvPlanCourse.Name = "dgvPlanCourse";
            this.dgvPlanCourse.RowTemplate.Height = 23;
            this.dgvPlanCourse.Size = new System.Drawing.Size(432, 150);
            this.dgvPlanCourse.TabIndex = 0;
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
            // count
            // 
            this.count.DataPropertyName = "s_count";
            this.count.HeaderText = "选课人数";
            this.count.Name = "count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "预选情况统计";
            // 
            // dgvCourseClass
            // 
            this.dgvCourseClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.new_number,
            this.new_cname,
            this.new_name,
            this.max_class_size});
            this.dgvCourseClass.Location = new System.Drawing.Point(41, 327);
            this.dgvCourseClass.Name = "dgvCourseClass";
            this.dgvCourseClass.RowTemplate.Height = 23;
            this.dgvCourseClass.Size = new System.Drawing.Size(468, 150);
            this.dgvCourseClass.TabIndex = 2;
            // 
            // new_number
            // 
            this.new_number.DataPropertyName = "number";
            this.new_number.HeaderText = "课程号";
            this.new_number.Name = "new_number";
            // 
            // new_cname
            // 
            this.new_cname.DataPropertyName = "cname";
            this.new_cname.HeaderText = "课程名称标识";
            this.new_cname.Name = "new_cname";
            // 
            // new_name
            // 
            this.new_name.DataPropertyName = "name";
            this.new_name.HeaderText = "授课教师";
            this.new_name.Name = "new_name";
            // 
            // max_class_size
            // 
            this.max_class_size.DataPropertyName = "max_class_size";
            this.max_class_size.HeaderText = "班级容量";
            this.max_class_size.Name = "max_class_size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文新魏", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(63, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "已开设班级";
            // 
            // btnNewClass
            // 
            this.btnNewClass.Font = new System.Drawing.Font("宋体", 14F);
            this.btnNewClass.Location = new System.Drawing.Point(353, 29);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(111, 31);
            this.btnNewClass.TabIndex = 4;
            this.btnNewClass.Text = "添加班级";
            this.btnNewClass.UseVisualStyleBackColor = true;
            this.btnNewClass.Click += new System.EventHandler(this.BtnNewClass_Click);
            // 
            // btnDelClass
            // 
            this.btnDelClass.Font = new System.Drawing.Font("宋体", 14F);
            this.btnDelClass.Location = new System.Drawing.Point(353, 271);
            this.btnDelClass.Name = "btnDelClass";
            this.btnDelClass.Size = new System.Drawing.Size(111, 31);
            this.btnDelClass.TabIndex = 5;
            this.btnDelClass.Text = "删除班级";
            this.btnDelClass.UseVisualStyleBackColor = true;
            this.btnDelClass.Click += new System.EventHandler(this.BtnDelClass_Click);
            // 
            // FrmCourseSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 560);
            this.Controls.Add(this.btnDelClass);
            this.Controls.Add(this.btnNewClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCourseClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPlanCourse);
            this.Name = "FrmCourseSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "排课";
            this.Load += new System.EventHandler(this.FrmCourseSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridView dgvCourseClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_class_size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Button btnDelClass;
    }
}