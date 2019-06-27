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
using CAMS.Common;

namespace CAMS.Student
{
    public partial class ChooseCoursePost : UserControl
    {
        StudentInfo stu;
        string semester_id = DBHelper.ExecuteScalar<int>("select id from current_semester where status='1';").ToString();
        public ChooseCoursePost()
        {
            InitializeComponent();
        }
        public ChooseCoursePost(string Account)
        {
            InitializeComponent();
            this.stu = new StudentInfo(Account);
        }

        private void MsgInit()
        {
            //string sql = "select course_class.id, course.number, course.cname, teacher.name, course_class.max_class_size from course_class, course, teacher where semester_id='"+semester_id+"' and course_class.course_id=course.id and course_class.teacher_id=teacher.id;";
            string sql = "select course_class.id, course.number, course.cname, teacher.name, course_class.max_class_size, course_class.max_class_size-(select count(*) from class_student where course_class_id=course_class.id) as surplus from course_class, course, teacher where semester_id='" + semester_id + "' and course_class.course_id=course.id and course_class.teacher_id=teacher.id;";
            dataGridView1.DataSource = DBHelper.GetFillData(sql);
            sql = "SELECT course_class.id, course.number, course.cname, teacher.name FROM course_class, course, teacher WHERE course_class.id in (SELECT course_class_id FROM class_student WHERE student_id='" + this.stu.id + "') and course_class.course_id=course.id and course_class.teacher_id=teacher.id";
            dataGridView2.DataSource = DBHelper.GetFillData(sql);
        }

        private void ChooseCoursePost_Load(object sender, EventArgs e)
        {
            Style.DgvUI(dataGridView1);
            Style.DgvUI(dataGridView2);
            MsgInit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string class_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string course_number = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string student_count = dataGridView1.CurrentRow.Cells["surplus"].Value.ToString();
            if(Convert.ToInt32(student_count) <= 0)
            {
                MessageBox.Show("该班级人数已满,请选择其他班级");
                return;
            }
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if(item.Cells[1].Value.ToString() == course_number)
                {
                    MessageBox.Show("你已选择该课程,无需再选");
                    return;
                }
            }
            DialogResult result = MessageBox.Show("确定要选择该班级?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                string sql = "INSERT INTO class_student(course_class_id, student_id) VALUES('" + class_id + "', '" + this.stu.id + "');";
                if(DBHelper.GetExcuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("选课成功");
                }
                else
                {
                    MessageBox.Show("选课失败");
                }
            }
            MsgInit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string class_id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("确定要取消选择该班级吗?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                string sql = "DELETE FROM class_student WHERE course_class_id='" + class_id + "' AND student_id='" + this.stu.id + "'";
                if(DBHelper.GetExcuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            MsgInit();
        }
    }
}
