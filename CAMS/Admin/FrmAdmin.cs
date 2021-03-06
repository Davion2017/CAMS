﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Admin
{
    public partial class FrmAdmin : Form
    {
        private string Account;
        public FrmAdmin(string account)
        {
            InitializeComponent();
            this.Account = account;
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmAdmin_Activated(object sender, EventArgs e)
        {
            labelAccount.Text = this.Account;
            labelAccount.ForeColor = Color.Red;
            labelTime.Text = DateTime.Now.ToString();
            labelTime.ForeColor = Color.Red;
        }

        private void BtnStu_Click(object sender, EventArgs e)
        {
            FrmStuManage fsm = new FrmStuManage(this);
            fsm.Show();
            this.Hide();
        }

        private void BtnTea_Click(object sender, EventArgs e)
        {
            FrmAdminTeacher adminTeacher = new FrmAdminTeacher();
            adminTeacher.ShowDialog();
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            FrmCourseManage frmCourseManage = new FrmCourseManage();
            frmCourseManage.Show();
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            FrmCourseChoose frmCourseChoose = new FrmCourseChoose();
            frmCourseChoose.Show();
        }
    }
}
