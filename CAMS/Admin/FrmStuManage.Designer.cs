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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStu = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelScode = new System.Windows.Forms.Label();
            this.picboxStu = new System.Windows.Forms.PictureBox();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnDelStu = new System.Windows.Forms.Button();
            this.tbnExit = new System.Windows.Forms.Button();
            this.labelNameTip = new System.Windows.Forms.Label();
            this.labelScodeTip = new System.Windows.Forms.Label();
            this.labelGenderTip = new System.Windows.Forms.Label();
            this.labelClassTip = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxScode = new System.Windows.Forms.TextBox();
            this.combboxGender = new System.Windows.Forms.ComboBox();
            this.combboxClass = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.scode,
            this.name,
            this.password,
            this.gender,
            this.class_id,
            this.major});
            this.dgvStu.Location = new System.Drawing.Point(23, 117);
            this.dgvStu.MultiSelect = false;
            this.dgvStu.Name = "dgvStu";
            this.dgvStu.ReadOnly = true;
            this.dgvStu.RowTemplate.Height = 23;
            this.dgvStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStu.Size = new System.Drawing.Size(609, 342);
            this.dgvStu.TabIndex = 0;
            this.dgvStu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStu_CellEnter);
            this.dgvStu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvStu_DataBindingComplete);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(675, 168);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 32);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "详细信息";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 11F);
            this.labelName.Location = new System.Drawing.Point(638, 117);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 15);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "姓名";
            // 
            // labelScode
            // 
            this.labelScode.AutoSize = true;
            this.labelScode.Font = new System.Drawing.Font("宋体", 12F);
            this.labelScode.Location = new System.Drawing.Point(693, 117);
            this.labelScode.Name = "labelScode";
            this.labelScode.Size = new System.Drawing.Size(40, 16);
            this.labelScode.TabIndex = 9;
            this.labelScode.Text = "学号";
            // 
            // picboxStu
            // 
            this.picboxStu.Location = new System.Drawing.Point(675, 12);
            this.picboxStu.Name = "picboxStu";
            this.picboxStu.Size = new System.Drawing.Size(75, 89);
            this.picboxStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxStu.TabIndex = 5;
            this.picboxStu.TabStop = false;
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(675, 228);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(75, 32);
            this.btnAddStu.TabIndex = 10;
            this.btnAddStu.Text = "增加学生";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.BtnAddStu_Click);
            // 
            // btnDelStu
            // 
            this.btnDelStu.Location = new System.Drawing.Point(675, 285);
            this.btnDelStu.Name = "btnDelStu";
            this.btnDelStu.Size = new System.Drawing.Size(75, 32);
            this.btnDelStu.TabIndex = 11;
            this.btnDelStu.Text = "删除学生";
            this.btnDelStu.UseVisualStyleBackColor = true;
            this.btnDelStu.Click += new System.EventHandler(this.BtnDelStu_Click);
            // 
            // tbnExit
            // 
            this.tbnExit.BackColor = System.Drawing.Color.Black;
            this.tbnExit.Font = new System.Drawing.Font("宋体", 11F);
            this.tbnExit.ForeColor = System.Drawing.Color.White;
            this.tbnExit.Location = new System.Drawing.Point(675, 367);
            this.tbnExit.Name = "tbnExit";
            this.tbnExit.Size = new System.Drawing.Size(75, 44);
            this.tbnExit.TabIndex = 12;
            this.tbnExit.Text = "关闭系统";
            this.tbnExit.UseVisualStyleBackColor = false;
            this.tbnExit.Click += new System.EventHandler(this.TbnExit_Click);
            // 
            // labelNameTip
            // 
            this.labelNameTip.AutoSize = true;
            this.labelNameTip.Font = new System.Drawing.Font("宋体", 12F);
            this.labelNameTip.Location = new System.Drawing.Point(76, 28);
            this.labelNameTip.Name = "labelNameTip";
            this.labelNameTip.Size = new System.Drawing.Size(56, 16);
            this.labelNameTip.TabIndex = 13;
            this.labelNameTip.Text = "姓名：";
            // 
            // labelScodeTip
            // 
            this.labelScodeTip.AutoSize = true;
            this.labelScodeTip.Font = new System.Drawing.Font("宋体", 12F);
            this.labelScodeTip.Location = new System.Drawing.Point(254, 28);
            this.labelScodeTip.Name = "labelScodeTip";
            this.labelScodeTip.Size = new System.Drawing.Size(56, 16);
            this.labelScodeTip.TabIndex = 14;
            this.labelScodeTip.Text = "学号：";
            // 
            // labelGenderTip
            // 
            this.labelGenderTip.AutoSize = true;
            this.labelGenderTip.Font = new System.Drawing.Font("宋体", 12F);
            this.labelGenderTip.Location = new System.Drawing.Point(76, 79);
            this.labelGenderTip.Name = "labelGenderTip";
            this.labelGenderTip.Size = new System.Drawing.Size(56, 16);
            this.labelGenderTip.TabIndex = 15;
            this.labelGenderTip.Text = "性别：";
            // 
            // labelClassTip
            // 
            this.labelClassTip.AutoSize = true;
            this.labelClassTip.Font = new System.Drawing.Font("宋体", 12F);
            this.labelClassTip.Location = new System.Drawing.Point(192, 79);
            this.labelClassTip.Name = "labelClassTip";
            this.labelClassTip.Size = new System.Drawing.Size(56, 16);
            this.labelClassTip.TabIndex = 16;
            this.labelClassTip.Text = "班级：";
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtboxName.Location = new System.Drawing.Point(129, 25);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(119, 26);
            this.txtboxName.TabIndex = 18;
            // 
            // txtboxScode
            // 
            this.txtboxScode.Font = new System.Drawing.Font("宋体", 12F);
            this.txtboxScode.Location = new System.Drawing.Point(302, 25);
            this.txtboxScode.Name = "txtboxScode";
            this.txtboxScode.Size = new System.Drawing.Size(136, 26);
            this.txtboxScode.TabIndex = 19;
            // 
            // combboxGender
            // 
            this.combboxGender.Font = new System.Drawing.Font("宋体", 12F);
            this.combboxGender.FormattingEnabled = true;
            this.combboxGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.combboxGender.Location = new System.Drawing.Point(129, 76);
            this.combboxGender.Name = "combboxGender";
            this.combboxGender.Size = new System.Drawing.Size(57, 24);
            this.combboxGender.TabIndex = 20;
            // 
            // combboxClass
            // 
            this.combboxClass.Font = new System.Drawing.Font("宋体", 12F);
            this.combboxClass.FormattingEnabled = true;
            this.combboxClass.Items.AddRange(new object[] {
            "17级软件工程(商务软件应用与开发方向)1班 ",
            "17级软件工程(软件测试方向)班 ",
            "17级软件工程(软件技术方向)1班 ",
            "17级软件工程(移动终端)2班 "});
            this.combboxClass.Location = new System.Drawing.Point(253, 76);
            this.combboxClass.Name = "combboxClass";
            this.combboxClass.Size = new System.Drawing.Size(185, 24);
            this.combboxClass.TabIndex = 21;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 16F);
            this.btnSelect.Location = new System.Drawing.Point(498, 38);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 44);
            this.btnSelect.TabIndex = 23;
            this.btnSelect.Text = "筛选";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 42;
            // 
            // scode
            // 
            this.scode.DataPropertyName = "学号";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.scode.DefaultCellStyle = dataGridViewCellStyle3;
            this.scode.HeaderText = "学号";
            this.scode.Name = "scode";
            this.scode.ReadOnly = true;
            this.scode.Width = 54;
            // 
            // name
            // 
            this.name.DataPropertyName = "姓名";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.name.DefaultCellStyle = dataGridViewCellStyle4;
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 54;
            // 
            // password
            // 
            this.password.DataPropertyName = "密码";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.password.DefaultCellStyle = dataGridViewCellStyle5;
            this.password.HeaderText = "密码";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 54;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "性别";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gender.DefaultCellStyle = dataGridViewCellStyle6;
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 54;
            // 
            // class_id
            // 
            this.class_id.DataPropertyName = "班级";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.class_id.DefaultCellStyle = dataGridViewCellStyle7;
            this.class_id.HeaderText = "班级";
            this.class_id.MaxInputLength = 10;
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.class_id.Width = 54;
            // 
            // major
            // 
            this.major.DataPropertyName = "专业";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.major.DefaultCellStyle = dataGridViewCellStyle8;
            this.major.HeaderText = "专业";
            this.major.Name = "major";
            this.major.ReadOnly = true;
            this.major.Width = 54;
            // 
            // FrmStuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 459);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.combboxClass);
            this.Controls.Add(this.combboxGender);
            this.Controls.Add(this.txtboxScode);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.labelClassTip);
            this.Controls.Add(this.labelGenderTip);
            this.Controls.Add(this.labelScodeTip);
            this.Controls.Add(this.labelNameTip);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理";
            this.Activated += new System.EventHandler(this.FrmStuManage_Activated);
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
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScode;
        private System.Windows.Forms.PictureBox picboxStu;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnDelStu;
        private System.Windows.Forms.Button tbnExit;
        private System.Windows.Forms.Label labelNameTip;
        private System.Windows.Forms.Label labelScodeTip;
        private System.Windows.Forms.Label labelGenderTip;
        private System.Windows.Forms.Label labelClassTip;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxScode;
        private System.Windows.Forms.ComboBox combboxGender;
        private System.Windows.Forms.ComboBox combboxClass;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn scode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn major;
    }
}