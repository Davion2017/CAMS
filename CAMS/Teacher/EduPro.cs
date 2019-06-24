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
    public partial class EduPro : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
        string strCon = "Data Source=.;Initial Catalog=xk;Integrated Security=True";//定义数据库连接字符串
        SqlConnection sqlcon;//声明数据库连接对象
        SqlDataAdapter sqlda;//声明数据库适配器对象
        DataSet myds;//声明数据集对象
        public EduPro()
        {
            InitializeComponent();
        }
        public EduPro(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode= Account;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string strselect = "select * from education_program where name = '" + comboBox2.Text + "' and publish_year = '" + comboBox1.Text + "'";
            sqlcon = new SqlConnection(strCon);//实例化数据库连接对象
            sqlda = new SqlDataAdapter(strselect, sqlcon);//实例化数据库桥接器对象
            myds = new DataSet();//实例化数据集对象
            sqlda.Fill(myds);//填充数据集
            dataGridView1.DataSource = myds.Tables[0];
        }

        private void EduPro_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            label5.Text = comboBox2.Text;
        }
    }
}

