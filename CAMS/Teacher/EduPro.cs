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
            string strselect = "SELECT \n" +
                               " education_program.name 专业, \n" +
                               " education_program.objective 培养目标, \n" +
                               " education_program.duration 标准学制, \n" +
                               " education_program.degree 授予学位, \n" +
                               " education_program.min_credit 毕业学分要求, \n" +
                               " education_program.publish_year 制定年份 \n" +
                                " FROM \n" +
                                "education_program \n" +
                                "WHERE name = '" + comboBox2.Text + "' and publish_year = '" + comboBox1.Text + "'";
            dataGridView1.DataSource = Dyy.GetFillData(strselect);
        }

        private void EduPro_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            label5.Text = comboBox2.Text;
        }
    }
}

