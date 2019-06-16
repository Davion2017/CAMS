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
        }

    }
}
