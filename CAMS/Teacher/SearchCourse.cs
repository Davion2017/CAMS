using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAMS.Admin;
using System.Data.SqlClient;
using CAMS.Common;

namespace CAMS.Teacher
{
    
    public partial class SearchCourse : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
        public SearchCourse()
        {
            InitializeComponent();
        }
        public SearchCourse(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strselect = "SELECT \n"+
                               " course.number 课程号, \n"+
                               " course.cname 课程中文名, \n"+
                               " course.ename 课程英文名, \n"+
                               " course.score 学分, \n"+
                               " course.chour 周理论学时, \n"+
                               " course.lhour 周实验学时, \n"+
                               " course.tchour 理论总学时, \n"+
                               " course.tlhour 实验总学时 \n"+
                               " FROM course \n"+
                               " WHERE";
            if (comboBox2.Text == "模糊查询")
            {
                if (comboBox1.Text == "课程号")
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " number like '%" + textBox1.Text.Trim() + "%'";
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " cname like '%" + textBox1.Text.Trim() + "%'";
                    }
                }
            }
            else
            {
                if (comboBox1.Text == "课程号")
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " number = '" + textBox1.Text.Trim() + "'";
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " cname = '" + textBox1.Text.Trim() + "'";
                    }
                }

            }
            if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
            {
                dataGridView1.DataSource = Dyy.GetFillData(strselect);
            }
            else
            {
                MessageBox.Show("不可为空");
                textBox1.Clear();
            }
        }

        private void SearchCourse_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            Style.DgvUI(dataGridView1);
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style.DgvBind(dataGridView1);
        }
    }
}
