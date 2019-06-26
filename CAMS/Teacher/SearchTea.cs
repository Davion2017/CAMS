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

namespace CAMS.Teacher
{
    public partial class SearchTea : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
        public SearchTea()
        {
            InitializeComponent();
        }
        public SearchTea(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string strselect = " SELECT\n" +
                "teacher.name 姓名,\n" +
                "teacher.tcode 工号,\n" +
                "teacher.gender 性别,\n" +
                "teacher.degree 学位,\n" +
                "teacher.title 职称 \n" +
                "FROM\n" +
                "teacher\n" +
                "WHERE ";
            if (comboBox2.Text == "模糊")
            {
                if (comboBox1.Text == "工号")
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " tcode like '%" + textBox1.Text.Trim() + "%'";
                        
                        
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " name like '%" + textBox1.Text.Trim() + "%'";
                       
                       
                    }
                }
            }
            else
            {
                if (comboBox1.Text == "工号")
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " tcode = '" + textBox1.Text.Trim() + "'";
                        
                        
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                    {
                        strselect += " name = '" + textBox1.Text.Trim() + "'";
                        
                        
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
            string intro = "select * from teacher where";
            if (comboBox1.Text == "姓名")
            {
                intro += " name = '" + textBox1.Text.Trim() + "' ";
            }
            else
            {
                intro += " tcode= '" + textBox1.Text.Trim() + "'";
            }

            SqlDataReader reader = Dyy.GetDataReader(intro);
            if (reader.HasRows)
            {
                reader.Read();
                richTextBox1.Text = reader["introduction"].ToString();
            }
            else
            {
                richTextBox1.Clear();
                MessageBox.Show("查询条件模糊，个人简介失败");
            }


        }

        private void SearchTea_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
