using CAMS.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAMS;
using System.Data.SqlClient;
using System.IO;

namespace CAMS.Student
{
    public partial class FrmStudent : Form
    {
        private string Account;
        StudentInfo Stu = new StudentInfo();
        public FrmStudent(string account)
        {
            InitializeComponent();
            this.Account = account;
            this.Stu.scode = Account;
        }
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            string sqlphoto = "select photo from student where scode = '" + this.Stu.scode + "';";
            SqlDataReader sqlData = YRHelper.GetDataReader(sqlphoto);
            sqlData.Read();
            string s = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
            FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
            fs.Dispose();
            pictureBox2.Image = Image.FromFile(Application.StartupPath.Replace("bin\\Debug", "") + "Resources\\images\\student\\timg.jpg");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StudentIfoQuery studentifoquery = new StudentIfoQuery(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(studentifoquery);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SearchTeacher searchteacher = new SearchTeacher(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(searchteacher);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            updateStuInfo updatestuinfo = new updateStuInfo(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(updatestuinfo);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            string sqlphoto = "select photo from student where scode = '" + this.Stu.scode + "';";
            SqlDataReader sqlData = YRHelper.GetDataReader(sqlphoto);
            sqlData.Read();
            string s = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
            pictureBox1.Image = Image.FromFile(s);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SearchStu searchstu = new SearchStu(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(searchstu);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SearchCourseInfo searchcourseinfo = new SearchCourseInfo(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(searchcourseinfo);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            EduPro edupro = new EduPro(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(edupro);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string sqlstatus1 = "select status from course_status where name = '预选' ;";
            SqlDataReader sqlData1 = YRHelper.GetDataReader(sqlstatus1);
            sqlData1.Read();
            string sqlstatus2 = "select status from course_status where name = '正选';";
            SqlDataReader sqlData2 = YRHelper.GetDataReader(sqlstatus2);
            sqlData2.Read();
            if (sqlData1["status"].ToString() == "1")
            {
                ChooseCoursePre choosecoursepre = new ChooseCoursePre(Account);
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(choosecoursepre);
            }
            else
            {
                MessageBox.Show("选课系统未开启");
            }
        }
    }
}
