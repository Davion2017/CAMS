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



namespace CAMS.Teacher
{
    public partial class FrmTeacher : Form
    {
        private string Account;
        TeacherInfo Tea = new TeacherInfo();
        public FrmTeacher(string account)
        {
            InitializeComponent();
            this.Account = account;
            this.Tea.Tcode = Account;
        }
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            string sqlphoto = "select photo from teacher where tcode = '" + this.Tea.Tcode + "';";
            SqlDataReader sqlData = Dyy.GetDataReader(sqlphoto);
            sqlData.Read();
            string s = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
            FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
            fs.Dispose();
            pictureBox2.Image = Image.FromFile(Application.StartupPath.Replace("bin\\Debug", "") + "Resources\\images\\teacher\\999.jpg");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PersonalInfo personalInfo = new PersonalInfo(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(personalInfo);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateTeaIfo updateteaifo = new UpdateTeaIfo(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(updateteaifo);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SearchStu searchstu = new SearchStu(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(searchstu);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SearchTea searchtea = new SearchTea(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(searchtea);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SearchCourse searchcourse = new SearchCourse(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(searchcourse);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Scoring scoring = new Scoring(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(scoring);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Resourse resourse = new Resourse(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(resourse);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            EduPro edupro = new EduPro(Account);
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(edupro);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            string sqlphoto = "select photo from teacher where tcode = '" + this.Tea.Tcode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sqlphoto);
            sqlData.Read();
            string s = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
            pictureBox1.Image = Image.FromFile(s);
        }
    }
}
