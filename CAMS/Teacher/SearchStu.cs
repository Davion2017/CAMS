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
    public partial class SearchStu : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
        public SearchStu()
        {
            InitializeComponent();
        }
        public SearchStu(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }

        private void SearchStu_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            Style.DgvUI(dataGridView1);
            
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strselect = "SELECT \n"+
                               " student.name 姓名, \n"+
                               "student.scode 学号, \n"+
                               "student.gender 性别, \n"+
                               "class.name 班级 \n"+
                               "FROM \n"+
                               "student,class \n"+
                               "WHERE student.class_id = class.id and"; 
            if (comboBox2.Text == "模糊")
            {
                if (comboBox1.Text == "学号")
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " student.scode like '%" + textBox1.Text.Trim() + "%'";
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " student.name like '%" + textBox1.Text.Trim() + "%'";
                    }
                }
            }
            else
            {
                if (comboBox1.Text == "学号")
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " student.scode = '" + textBox1.Text.Trim() + "'";
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " student.name = '" + textBox1.Text.Trim() + "'";
                    }
                }
            }
            if(!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
            {
                dataGridView1.DataSource = Dyy.GetFillData(strselect);
            }
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style.DgvBind(dataGridView1);
        }
    }
}
