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
    public partial class Scoring : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
        private string string1;
        public string String1
        {
            set
            {
                string1 = value;
            }
        }
        SqlConnection con;
        public Scoring()
        {
            InitializeComponent();
        }
        public Scoring(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strsql = "Update" +
                " class_student set gpa_score='" + textBox3.Text.Trim() + "'," +
                "paper_score='" + textBox4.Text.Trim() + "',practice_score='" + textBox5.Text.Trim() + "'," +
                "score='" + textBox6.Text.Trim() + "' " +
                "where course_class_id='" + textBox1.Text.Trim() + "' and student_id='" + textBox2.Text.Trim() + "'";
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
                    MessageBox.Show("评定成功");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                else
                {
                    MessageBox.Show("班级学生信息不存在");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
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
            SqlDataAdapter com = new SqlDataAdapter("select * from class_student", con);
            DataSet mds = new DataSet();
            com.Fill(mds);
            dataGridView1.DataSource = mds.Tables[0];
        }

        private void Scoring_Load(object sender, EventArgs e)
        {
            string sqlstr = "server=.;DataBase=xk;Integrated Security=True";
            con = new SqlConnection(sqlstr);
            SqlDataAdapter com = new SqlDataAdapter("select * from class_student", con);
            DataSet mds = new DataSet();
            com.Fill(mds);
            dataGridView1.DataSource = mds.Tables[0];
        }
        //若已经评定的成绩有错，可由重做按钮进行修改
        private void Button2_Click(object sender, EventArgs e)
        {string strsql= "Update" +
                " class_student set gpa_score=NULL," +
                "paper_score=NULL,practice_score=NULL," +
                "score=NULL " +
                "where course_class_id='" + textBox1.Text.Trim() + "' and student_id='" + textBox2.Text.Trim() + "'";
     
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
                    MessageBox.Show("修改成功，请重新评定");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("修改失败");
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
        }
    }
}
