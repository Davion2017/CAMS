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
    public partial class Resourse : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
       
        public Resourse()
        {
            InitializeComponent();
        }
        public Resourse(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;DataBase=xk;Integrated Security=True");
            string strsql = "insert into course_resource(course_id,name,resource_url) " +
                "values('" + textBox1.Text.Trim() + "', '" + textBox2.Text.Trim() + "', '" + textBox3.Text.Trim() + "')";
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
                    MessageBox.Show("上传成功");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("上传失败，失败原因:" + ex.Message);
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
            SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=xk;Integrated Security=True");
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand jud = new SqlCommand("select * from course_resource where name='" + textBox4.Text.Trim() + "'", sqlcon);
            SqlDataReader da = jud.ExecuteReader();
            if (da.HasRows)
            {
                da.Close();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from course_resource where name like '%" + textBox4.Text.Trim() + "%'",
                sqlcon);
                DataSet myds = new DataSet();
                sqlda.Fill(myds);
                dataGridView1.DataSource = myds.Tables[0];
            }
            else
            {
                MessageBox.Show("不存在该课程资源！");
                textBox4.Text = "";
            }
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
            
        }

       
    }
}
