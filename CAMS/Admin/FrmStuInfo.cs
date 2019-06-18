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
using System.IO;
using CAMS.Common;
namespace CAMS.Admin
{


    public partial class FrmStuInfo : Form
    {

        StudentInfo stu = new StudentInfo();

        public FrmStuInfo(Form parent, string scode)
        {
            InitializeComponent();
            this.Owner = parent;
            this.stu.scode = scode;
        }

        private void FrmStuInfo_Load(object sender, EventArgs e)
        {


            string sqlInque = "select * from stu_cla_maj where 学号 = '" + this.stu.scode + "' ;";

            SqlDataReader sqlData = DBHelper.GetDataReader(sqlInque);

            sqlData.Read();

            txtboxScode.Text = this.stu.scode;
            txtboxName.Text = sqlData[2].ToString();
            txtPassword.Text = sqlData[3].ToString();
            cbboxGender.Text = sqlData[4].ToString();
            cbboxClass.Text = sqlData[5].ToString();
            txtboxMajor.Text = sqlData[6].ToString();

            Style.DgvUI(dgvCourse);

            string inquire = "SELECT\n" +
                    "	course.number 课程号,\n" +
                    "	course.cname 课程中文名,\n" +
                    "	course.ename 课程英文名,\n" +
                    "	teacher.name 任课教师,\n" +
                    "	semester.name 学期,\n" +
                    "	class_student.gpa_score gpa成绩,\n" +
                    "	class_student.paper_score 笔试成绩,\n" +
                    "	class_student.practice_score 实践成绩,\n" +
                    "	class_student.score 总成绩 \n" +
                    "FROM\n" +
                    "	class_student,\n" +
                    "	stu_cla_maj,\n" +
                    "	course,\n" +
                    "	course_class,\n" +
                    "	teacher,\n" +
                    "	semester \n" +
                    "WHERE\n" +
                    "	class_student.student_id = stu_cla_maj.id \n" +
                    "	AND class_student.course_class_id = course_class.id \n" +
                    "	AND course_class.course_id = course.id \n" +
                    "	AND teacher.id = course_class.teacher_id \n" +
                    "	AND stu_cla_maj.[学号] = '" + this.stu.scode +
                    "'  \nAND course_class.semester_id = semester.id;";

            DataTable dtable = DBHelper.GetFillData(inquire);
            dgvCourse.DataSource = dtable;

            string sqlphoto = "select photo from student where scode = '" + this.stu.scode + "';";

            SqlDataReader sqldata = DBHelper.GetDataReader(sqlphoto);
            if (sqldata.HasRows)
            {
                sqldata.Read();
                this.stu.photo = sqldata[0].ToString().Replace("~", Application.StartupPath.Replace("\\bin\\Debug", "\\Resources"));

                FileStream fileStream = File.Open(this.stu.photo, FileMode.Open, FileAccess.Read);
                picboxPhoto.Image = Image.FromStream(fileStream);

                fileStream.Close();
                fileStream.Dispose();

                //MessageBox.Show(this.stu.photo);
            }

            

        }

        


        private void FrmStuInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }



        private void DgvCourse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style.DgvBind(dgvCourse);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            txtboxName.Enabled = true;
            cbboxClass.Enabled = true;
            cbboxGender.Enabled = true;
            txtPassword.Enabled = true;
        }
    }
}
