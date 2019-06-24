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
        string strCon = "Data Source=.;Initial Catalog=xk;Integrated Security=True";//定义数据库连接字符串
        SqlConnection sqlcon;//声明数据库连接对象
        SqlDataAdapter sqlda;//声明数据库适配器对象
        DataSet myds;//声明数据集对象
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
            string strselect = "select * from teacher where";
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
                sqlcon = new SqlConnection(strCon);//实例化数据库连接对象
                sqlda = new SqlDataAdapter(strselect, sqlcon);//实例化数据库桥接器对象
                myds = new DataSet();//实例化数据集对象
                sqlda.Fill(myds);//填充数据集
                dataGridView1.DataSource = myds.Tables[0];
            }
            else
            {
                MessageBox.Show("不可为空");
                textBox1.Clear();
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
