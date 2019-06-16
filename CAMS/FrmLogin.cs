﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAMS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            skinEngine1.SkinFile = Application.StartupPath.Replace("bin\\Debug", "") + @"/Resources/Skins/mp10.ssk";
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            txtAccount.Focus();
            rbtnStudent.Checked = true;
        }

        /// <summary>
        /// 验证输入合法性
        /// </summary>
        /// <returns></returns>
        private bool CheckTxt()
        {
            bool pass = true;

            if(txtAccount.Text == string.Empty)
            {
                MessageBox.Show("请输入账号！！！");
                pass = false;
            }
            else if(txtPassword.Text == string.Empty)
            {
                MessageBox.Show("请输入密码！！！");
                pass = false;
            }

            return pass;
        }

        private void OpenForm(string sql, string type)
        {
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            if (sqlData.HasRows)
            {
                switch(type)
                {
                    case "student":

                        break;
                    case "teacher":

                        break;
                    case "admin":

                        break;
                }
            }
            else
            {
                MessageBox.Show("登录失败，请检查账号或密码！");
            }
            sqlData.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(CheckTxt())
            {
                if(rbtnStudent.Checked)
                {
                    string sql = "select * from student where scode='" + this.txtAccount.Text.Trim() + "' and password='" + this.txtPassword.Text.Trim() + "';";
                    this.OpenForm(sql, "student");
                }
                else if(rbtnTeacher.Checked)
                {
                    string sql = "select * from teacher where tcode='" + this.txtAccount.Text.Trim() + "' and password='" + this.txtPassword.Text.Trim() + "';";
                    this.OpenForm(sql,"teacher");
                }
                else if(rbtnAdmin.Checked)
                {
                    string sql = "select * from admin where password='" + this.txtPassword.Text + "';";
                    this.OpenForm(sql,"admin");
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnAdmin.Checked)
            {
                txtAccount.Text = "admin";
                txtAccount.ReadOnly = true;
            }
            else
            {
                txtAccount.ReadOnly = false;
            }
        }
    }
}
