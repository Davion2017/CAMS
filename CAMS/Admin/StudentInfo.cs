using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAMS.Admin
{
    class StudentInfo
    {

        public string name { get; set; }
        public string scode { get; set; }
        public string gender { get; set; }
        public string photo { get; set; }
        public int class_id { get; set; }
        public string password { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public StudentInfo()
        {

        }

        /// <summary>
        /// 有参构造函数，根据学号初始化学生信息
        /// </summary>
        /// <param name="scode"></param>
        public StudentInfo(string scode)
        {
            string sql = "select * from student where scode='" + scode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);

            name = sqlData["name"].ToString();
            this.scode = scode;
            password = sqlData["password"].ToString();
            gender = sqlData["gender"].ToString();
            class_id = Convert.ToInt32(sqlData["class_id"].ToString());
            photo = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");

            sqlData.Close();
        }

    }
}
