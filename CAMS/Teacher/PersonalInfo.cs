using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CAMS.Admin;

namespace CAMS.Teacher
{
    public partial class PersonalInfo : UserControl
    {
       
        TeacherInfo Tea = new TeacherInfo();
        public PersonalInfo()
        {
            InitializeComponent();        
        }
        public PersonalInfo(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            string s = "select * from teacher where tcode='" +Tea.Tcode + "';";
            SqlDataReader sqlData = Dyy.GetDataReader(s);
            sqlData.Read();
            this.label2.Text = sqlData["name"].ToString();
            this.label4.Text = sqlData["gender"].ToString();
            this.label12.Text = sqlData["tcode"].ToString();
            this.label6.Text = sqlData["degree"].ToString();
            this.label8.Text = sqlData["title"].ToString();
            this.label10.Text = sqlData["introduction"].ToString();
            //显示教师个人信息


        }
    }
}
