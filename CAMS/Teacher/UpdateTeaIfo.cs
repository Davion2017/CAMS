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
using System.IO;

namespace CAMS.Teacher
{
    public partial class UpdateTeaIfo : UserControl
    {
       
        TeacherInfo Tea = new TeacherInfo();
        SqlConnection con;
        public UpdateTeaIfo()
        {
            InitializeComponent();
        }
        public UpdateTeaIfo(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }
        private void UpdateTeaIfo_Load(object sender, EventArgs e)
        {
            string s = "select * from teacher where tcode='" + Tea.Tcode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(s);
            sqlData.Read();
            this.label2.Text = sqlData["name"].ToString();
            this.label4.Text = sqlData["gender"].ToString();
            this.label12.Text = sqlData["tcode"].ToString();
            this.label6.Text = sqlData["degree"].ToString();
            this.label8.Text = sqlData["title"].ToString();
            //显示教师个人信息
        }

        //密码修改及验证
        private void Button1_Click(object sender, EventArgs e)
        {
            string SqlStr = "Data Source=ECHO\\SQLEXPRESS;Initial Catalog=xk;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            string s = "select * from teacher where tcode='" + Tea.Tcode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(s);
            sqlData.Read();
            string strsql = "Update teacher set password ='" + textBox1.Text.Trim() + "' where tcode='" + sqlData["tcode"].ToString() + "'";
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
                }              
                else { MessageBox.Show("修改失败"); }            }
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
        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg文件(*jpg)|*.jpg|bmp文件(*bmp)|*.bmp|gif文件(*gif)|*.gif";
            op.ShowDialog();
            string FileName = op.FileName;
            this.textBox2.Text = FileName;
            pictureBox1.Image = Image.FromFile(FileName);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            string Path = this.textBox2.Text;
            string SqlStr = "Data Source=ECHO\\SQLEXPRESS;Initial Catalog=xk;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            string s = Path.Replace("C:\\Users\\lenovo\\source\\repos\\Davion2017\\CAMS\\CAMS\\Resources", "~");
            string strsql = "Update teacher set photo ='" + s + "' where tcode='" + Tea.Tcode + "'";
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
                    textBox2.Clear();
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
            this.button3.Text = "完成";
          


        }
      
    }
}

