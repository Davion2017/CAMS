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

namespace CAMS.Student
{
    public partial class EduPro : UserControl
    {
        string strCon = "Data Source=DESKTOP-R5GQMVG\\SQLEXPRESS;Initial Catalog=xk;Integrated Security=True";//定义数据库连接字符串
        SqlConnection sqlcon;//声明数据库连接对象
        SqlDataAdapter sqlda;//声明数据库适配器对象
        DataSet myds;//声明数据集对象
        StudentInfo stu = new StudentInfo();
        public EduPro()
        {
            InitializeComponent();
        }
        public EduPro(string Account)
        {
            InitializeComponent();
            this.stu.scode = Account;
        }

        private void EduPro_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            label5.Text = comboBox1.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strselect = "select * from education_program where name = '" + comboBox1.Text + "' and publish_year = '" + comboBox2.Text + "'";
            sqlcon = new SqlConnection(strCon);//实例化数据库连接对象
            sqlda = new SqlDataAdapter(strselect, sqlcon);//实例化数据库桥接器对象
            myds = new DataSet();//实例化数据集对象
            sqlda.Fill(myds);//填充数据集
            dataGridView1.DataSource = myds.Tables[0];
        }
    }
}
