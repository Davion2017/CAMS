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

namespace CAMS.Student
{
    public partial class updateStuInfo : UserControl
    {
        StudentInfo stu = new StudentInfo();
        SqlConnection con;
        public updateStuInfo(string Account)
        {
            InitializeComponent();
            this.stu.scode = Account;
        }
        public updateStuInfo()
        {
            InitializeComponent();
        }

        private void UpdateStuInfo_Load(object sender, EventArgs e)
        {
            string s = "select * from student where scode='" + stu.scode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(s);
            sqlData.Read();
            this.label5.Text = sqlData["name"].ToString();
            this.label6.Text = sqlData["scode"].ToString();
            this.label9.Text = sqlData["gender"].ToString();
            string l = "select class.name from class,student where class.id='" + sqlData["class_id"].ToString() + "' and student.class_id = class.id";
            SqlDataReader sqlData2 = DBHelper.GetDataReader(l);
            sqlData2.Read();
            this.label7.Text = sqlData2["name"].ToString();
            string k = "select major.name from class,major where class.id='" + sqlData["class_id"].ToString() + "' and major.id = class.major_id";
            SqlDataReader sqlData3 = DBHelper.GetDataReader(k);
            sqlData3.Read();
            this.label8.Text = sqlData3["name"].ToString();
            //显示学生个人信息

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string SqlStr = "Data Source=DESKTOP-R5GQMVG;Initial Catalog=xk;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            string s = "select * from student where scode='" + stu.scode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(s);
            sqlData.Read();
            string strsql = "Update student set password ='" + textBox3.Text.Trim() + "' where scode='" + sqlData["scode"].ToString() + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("修改成功");
                    textBox1.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("班级学生信息不存在");
                    textBox1.Clear();
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改错误，错误原因:" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
