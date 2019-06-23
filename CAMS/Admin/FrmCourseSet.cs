using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAMS.Common;

namespace CAMS.Admin
{
    public partial class FrmCourseSet : Form
    {
        string semester;
        public FrmCourseSet()
        {
            InitializeComponent();
        }
        public FrmCourseSet(string semester)
        {
            InitializeComponent();
            this.semester = semester;
        }

        private void FrmCourseSet_Load(object sender, EventArgs e)
        {
            Style.DgvUI(dgvPlanCourse);
            Style.DgvUI(dgvCourseClass);
            UpdateCourse();
        }

        private void UpdateCourse()
        {
            dgvPlanCourse.DataSource = DBHelper.GetFillData("select (select number from course where id=course_id)" +
                " as number, (select cname from course where id=course_id) as cname, count(student_id)" +
                " as s_count from plan_study_course where semester_id='" + this.semester + "' GROUP BY course_id;");
            dgvCourseClass.DataSource = DBHelper.GetFillData("select course.number, course.cname, teacher.name," +
                " max_class_size from course_class, course, teacher where course_class.course_id=course.id and" +
                " course_class.teacher_id=teacher.id and semester_id='" + this.semester + "';");
        }

        private void BtnNewClass_Click(object sender, EventArgs e)
        {
            if(CheckNewClass())
            {
                string number = dgvPlanCourse.CurrentRow.Cells[0].Value.ToString();
                string cname = dgvPlanCourse.CurrentRow.Cells[1].Value.ToString();
                FrmClassAdd frmClassAdd = new FrmClassAdd(number, cname, semester);
                frmClassAdd.ShowDialog();
                UpdateCourse();
            }
        }

        private bool CheckNewClass()
        {

            string course_id = DBHelper.ExecuteScalar<int>("select id from course where" +
                " number='" + dgvPlanCourse.CurrentRow.Cells[0].Value.ToString() + "'").ToString();
            string sql = "select sum(max_class_size) from course_class where course_id='" + course_id + "' and" +
                " semester_id='" + semester + "';";

            //课程预选时的总人数
            int needSize = Convert.ToInt32(dgvPlanCourse.CurrentRow.Cells[2].Value.ToString());
            //课程已开班的容量
            int currentSize = DBHelper.ExecuteScalar<int>(sql);
            if(currentSize >= needSize)
            {
                MessageBox.Show("该课程已有足够容量，无需再添加班级！");
                return false;
            }
            return true;
        }

        private void BtnDelClass_Click(object sender, EventArgs e)
        {
            string teacher_id = DBHelper.ExecuteScalar<int>("select id from teacher where" +
                " name='"+dgvCourseClass.CurrentRow.Cells[2].Value.ToString()+"'").ToString();
            string course_id = DBHelper.ExecuteScalar<int>("select id from course where" +
                " number='"+dgvCourseClass.CurrentRow.Cells[0].Value.ToString()+"'").ToString();
            string sql = "DELETE FROM course_class WHERE teacher_id='" + teacher_id + "' and course_id=" +
                "'" + course_id + "';";
            if(DBHelper.GetExcuteNonQuery(sql) > 0)
            {
                MessageBox.Show("删除成功！！！");
            }
            else
            {
                MessageBox.Show("删除失败！！！");
            }
            UpdateCourse();
        }
    }
}
