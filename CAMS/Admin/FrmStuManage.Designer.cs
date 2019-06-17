namespace CAMS.Admin
{


    partial class FrmStuManage
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
            this.dgvStu = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetails = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelScode = new System.Windows.Forms.Label();
            this.picboxStu = new System.Windows.Forms.PictureBox();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnDelStu = new System.Windows.Forms.Button();
            this.tbnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStu
            // 
            this.dgvStu.AllowUserToAddRows = false;
            this.dgvStu.AllowUserToDeleteRows = false;
            this.dgvStu.AllowUserToResizeColumns = false;
            this.dgvStu.AllowUserToResizeRows = false;
            this.dgvStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.scode,
            this.name,
            this.password,
            this.gender,
            this.class_id,
            this.major});
            this.dgvStu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStu.Location = new System.Drawing.Point(0, 0);
            this.dgvStu.MultiSelect = false;
            this.dgvStu.Name = "dgvStu";
            this.dgvStu.ReadOnly = true;
            this.dgvStu.RowTemplate.Height = 23;
            this.dgvStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStu.Size = new System.Drawing.Size(903, 459);
            this.dgvStu.TabIndex = 0;
            this.dgvStu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStu_CellEnter);
            this.dgvStu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvStu_CellFormatting);
            this.dgvStu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvStu_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 42;
            // 
            // scode
            // 
            this.scode.DataPropertyName = "学号";
            this.scode.HeaderText = "学号";
            this.scode.Name = "scode";
            this.scode.ReadOnly = true;
            this.scode.Width = 54;
            // 
            // name
            // 
            this.name.DataPropertyName = "姓名";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 54;
            // 
            // password
            // 
            this.password.DataPropertyName = "密码";
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 54;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "性别";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 54;
            // 
            // class_id
            // 
            this.class_id.DataPropertyName = "班级";
            this.class_id.HeaderText = "班级";
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Width = 54;
            // 
            // major
            // 
            this.major.DataPropertyName = "专业";
            this.major.HeaderText = "专业";
            this.major.Name = "major";
            this.major.ReadOnly = true;
            this.major.Width = 54;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(759, 168);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 32);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "详细信息";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 11F);
            this.labelName.Location = new System.Drawing.Point(722, 117);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 15);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "姓名";
            // 
            // labelScode
            // 
            this.labelScode.AutoSize = true;
            this.labelScode.Font = new System.Drawing.Font("宋体", 12F);
            this.labelScode.Location = new System.Drawing.Point(777, 117);
            this.labelScode.Name = "labelScode";
            this.labelScode.Size = new System.Drawing.Size(40, 16);
            this.labelScode.TabIndex = 9;
            this.labelScode.Text = "学号";
            // 
            // picboxStu
            // 
            this.picboxStu.Location = new System.Drawing.Point(759, 12);
            this.picboxStu.Name = "picboxStu";
            this.picboxStu.Size = new System.Drawing.Size(75, 89);
            this.picboxStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxStu.TabIndex = 5;
            this.picboxStu.TabStop = false;
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(759, 228);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(75, 32);
            this.btnAddStu.TabIndex = 10;
            this.btnAddStu.Text = "增加学生";
            this.btnAddStu.UseVisualStyleBackColor = true;
            // 
            // btnDelStu
            // 
            this.btnDelStu.Location = new System.Drawing.Point(759, 285);
            this.btnDelStu.Name = "btnDelStu";
            this.btnDelStu.Size = new System.Drawing.Size(75, 32);
            this.btnDelStu.TabIndex = 11;
            this.btnDelStu.Text = "删除学生";
            this.btnDelStu.UseVisualStyleBackColor = true;
            // 
            // tbnExit
            // 
            this.tbnExit.BackColor = System.Drawing.Color.Black;
            this.tbnExit.Font = new System.Drawing.Font("宋体", 11F);
            this.tbnExit.ForeColor = System.Drawing.Color.White;
            this.tbnExit.Location = new System.Drawing.Point(759, 367);
            this.tbnExit.Name = "tbnExit";
            this.tbnExit.Size = new System.Drawing.Size(75, 44);
            this.tbnExit.TabIndex = 12;
            this.tbnExit.Text = "关闭系统";
            this.tbnExit.UseVisualStyleBackColor = false;
            this.tbnExit.Click += new System.EventHandler(this.TbnExit_Click);
            // 
            // FrmStuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 459);
            this.Controls.Add(this.tbnExit);
            this.Controls.Add(this.btnDelStu);
            this.Controls.Add(this.btnAddStu);
            this.Controls.Add(this.labelScode);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.picboxStu);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvStu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStuManage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStuManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmStuManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStu;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn scode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScode;
        private System.Windows.Forms.PictureBox picboxStu;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnDelStu;
        private System.Windows.Forms.Button tbnExit;
    }
}