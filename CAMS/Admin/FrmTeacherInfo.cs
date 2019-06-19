using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CAMS.Common;

namespace CAMS.Admin
{
    public partial class FrmTeacherInfo : Form
    {
        string tcode;
        public FrmTeacherInfo(string tcode)
        {
            InitializeComponent();
            this.tcode = tcode;
            InfoShow();
        }

        private void InfoShow()
        {
            string sql = "select * from teacher where tcode='" + this.tcode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            if(sqlData.HasRows)
            {
                sqlData.Read();
                this.Text = sqlData["name"].ToString();
                labName.Text = sqlData["name"].ToString();
                labGender.Text = sqlData["gender"].ToString();
                labDegree.Text = sqlData["degree"].ToString();
                labTitle.Text = sqlData["title"].ToString();
                rtxtIntroduction.Text = sqlData["introduction"].ToString();

                string picPath = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
                picPhoto.Image = Image.FromFile(picPath);

            }
            sqlData.Close();
            this.ClassShow();
        }

        private void ClassShow()
        {
            Style.DgvUI(dgvCourseLIst);
            string sql = "select number, cname, score from course where id in (select course_id from course_class where teacher_id=(select id from teacher where tcode='" + this.tcode + "'))";
            DataTable table = DBHelper.GetFillData(sql);
            dgvCourseLIst.DataSource = table;
        }
    }
}
