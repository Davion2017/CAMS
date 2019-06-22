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
        public static Image GetByteToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);

            Image img = Image.FromStream(ms, true, false);
            return img;
        }
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            string sqlphoto = "select photo from student where scode = '" + this.Stu.scode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sqlphoto);
            sqlData.Read();
            string s = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
            pictureBox1.Image = Image.FromFile(s);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
