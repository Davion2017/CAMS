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
    public partial class UpdateTeaIfo : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
        public UpdateTeaIfo(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }
        private void PersonalInfo_Load(object sender, EventArgs e)
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
    }
}

