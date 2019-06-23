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
            SqlDataReader sqlData = DBHelper.GetDataReader(sqlphoto);
            sqlData.Read();
            string s = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
            pictureBox1.Image = Image.FromFile(s);
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
    }
}
