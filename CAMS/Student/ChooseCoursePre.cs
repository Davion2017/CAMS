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
    public partial class ChooseCoursePre : UserControl
    {
        StudentInfo stu = new StudentInfo();
        public ChooseCoursePre()
        {
            InitializeComponent();
        }
        public ChooseCoursePre(string Account)
        {
            InitializeComponent();
            this.stu = new StudentInfo(Account);
        }

        private void ChooseCoursePre_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string strdel = "delete from plan_study_course where id='" + id + "';";
            if (DialogResult.Yes == MessageBox.Show("您确定要删除该门课程?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (YRHelper.GetExcuteNonQuery(strdel) > 0)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strselect;
            if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
            {
                strselect = "select * from course where cname like '%" + textBox1.Text.Trim() + "%'";
                dataGridView1.DataSource = YRHelper.GetFillData(strselect);
            }
            else
            {
                MessageBox.Show("不可为空");
                textBox1.Clear();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string strselect = "select * from course";
            dataGridView1.DataSource = YRHelper.GetFillData(strselect);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sqlstatus = "select * from current_semester where status = '1';";
            SqlDataReader sqlData = YRHelper.GetDataReader(sqlstatus);
            sqlData.Read();
            string stradd = "insert(course_id,semester_id,student_id) into plan_study_course values('" + id + "','" + sqlstatus["id"] + "','" + stu.scode + "')";
            if (DialogResult.Yes == MessageBox.Show("您确定要增选该门课程?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (YRHelper.GetExcuteNonQuery(stradd) > 0)
                {
                    MessageBox.Show("增选成功");
                }
                else
                {
                    MessageBox.Show("增选失败");
                }
            }
        }
    }
}
