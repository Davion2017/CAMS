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

            Dgvmsg(sender, e);

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

        private void Dgvmsg(object sender, EventArgs e)
        {
            dgvCourse.AllowUserToResizeColumns = false;
            dgvCourse.RowHeadersVisible = false;
            
            

            // 单元格颜色设置
            foreach (DataGridViewRow dgvRow in dgvCourse.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dgvCourse.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dgvCourse.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }


            // 单元格宽度调整
            int width = 0;
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < this.dgvCourse.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                this.dgvCourse.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += this.dgvCourse.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，
            //则将DataGridView的列自动调整模式设置为显示的列即可，
            //如果是小于原来设定的宽度，将模式改为填充。
            if (width > this.dgvCourse.Size.Width)
            {
                this.dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                this.dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1，2
            dgvCourse.Columns[1].Frozen = true;

        }


        private void FrmStuInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }


        //单元格文本居中
        private void DgvCourse_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void DgvCourse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dgvCourse.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dgvCourse.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dgvCourse.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }
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
