using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Admin
{
    class TeacherInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Degree { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public string Tcode { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public TeacherInfo()
        {

        }

        /// <summary>
        /// 有参构造函数，根据教工号初始化属性
        /// </summary>
        /// <param name="tcode"></param>
        public TeacherInfo(string tcode)
        {
            string sql = "select * from teacher where tcode='" + tcode + "'";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            sqlData.Read();

            Id = Convert.ToInt32(sqlData["id"].ToString());
            Name = sqlData["name"].ToString();
            Gender = sqlData["gender"].ToString();
            Degree = sqlData["degree"].ToString();
            Title = sqlData["title"].ToString();
            Introduction = sqlData["introduction"].ToString();
            Password = sqlData["password"].ToString();
            Tcode = tcode;
            Photo = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");

            sqlData.Close();
        }
    }
}
