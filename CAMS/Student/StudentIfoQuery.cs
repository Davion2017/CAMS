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

namespace CAMS.Student
{
    public partial class StudentIfoQuery : UserControl
    {
        string strCon = "Data Source=.;Initial Catalog=xk;Integrated Security=True";//定义数据库连接字符串
        SqlConnection sqlcon;//声明数据库连接对象
        SqlDataAdapter sqlda;//声明数据库适配器对象
        DataSet myds;//声明数据集对象
        StudentInfo stu=new StudentInfo();
        public StudentIfoQuery(string Account)
        {
            InitializeComponent();
            this.stu.scode = Account;
        }

        private void StudentIfoQuery_Load(object sender, EventArgs e)
        {
            string s = "select * from student where scode='" + stu.scode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(s);
            sqlData.Read();
            this.label5.Text = sqlData["name"].ToString();
            this.label6.Text = sqlData["scode"].ToString();
            this.label9.Text= sqlData["gender"].ToString();
            string l = "select class.name from class,student where class.id='" + sqlData["class_id"].ToString() + "' and student.class_id = class.id";
            SqlDataReader sqlData2 = DBHelper.GetDataReader(l);
            sqlData2.Read();
            this.label7.Text = sqlData2["name"].ToString();
            string k = "select major.name from class,major where class.id='" + sqlData["class_id"].ToString() + "' and major.id = class.major_id";
            SqlDataReader sqlData3 = DBHelper.GetDataReader(k);
            sqlData3.Read();
            this.label8.Text = sqlData3["name"].ToString();
            //显示学生个人信息

            sqlcon = new SqlConnection(strCon);//实例化数据库连接对象
            sqlda = new SqlDataAdapter("select * from class_student", sqlcon);//实例化数据库桥接器对象
            myds = new DataSet();//实例化数据集对象
            sqlda.Fill(myds);//填充数据集
            dataGridView1.DataSource = myds.Tables[0];//为dataGridView1指定数据源

        }
    }
}
