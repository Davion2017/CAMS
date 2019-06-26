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
        string newPath;
        StudentInfo stu = new StudentInfo();


        public FrmStuInfo(Form parent, string scode)
        {
            InitializeComponent();

            this.Owner = parent;
            this.stu.scode = scode;
        }


        private void FrmStuInfo_Load(object sender, EventArgs e)
        {
            Style.DgvUI(dgvCourse);
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
            if (btnUpdate.Text == "修改信息")
            {
                btnUpdate.Text = "取消";
                txtboxName.Enabled = true;
                cbboxClass.Enabled = true;
                cbboxGender.Enabled = true;
                txtPassword.Enabled = true;
                btnPhoto.Visible = true;
                btnSave.Enabled =true;
            }
            else
            {
                btnUpdate.Text = "修改信息";
                btnSave.Enabled = false;
                string sqlInque = "select * from stu_cla_maj where 学号 = '" + this.stu.scode + "' ;";
                SqlDataReader sqlData = DBHelper.GetDataReader(sqlInque);
                sqlData.Read();

                txtboxScode.Text = this.stu.scode;
                this.stu.name = txtboxName.Text = sqlData[2].ToString();
                this.stu.password = txtPassword.Text = sqlData[3].ToString();
                this.stu.gender = cbboxGender.Text = sqlData[4].ToString();
                cbboxClass.Text = sqlData[5].ToString();
                txtboxMajor.Text = sqlData[6].ToString();

                sqlData.Close();

                txtboxName.Enabled = false;
                cbboxClass.Enabled = false;
                cbboxGender.Enabled = false;
                txtPassword.Enabled = false;
                btnPhoto.Visible = false;

                FileStream fileStream = File.Open(this.stu.photo, FileMode.Open, FileAccess.Read);
                picboxPhoto.Image = Image.FromStream(fileStream);

                fileStream.Close();
                fileStream.Dispose();
            }

            
        }


        private void BtnPhoto_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg文件|*.jpg|gif文件|*.gif|bmp文件|*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPath = Path.GetFullPath(openFileDialog.FileName);
                FileStream fs = new FileStream(newPath, FileMode.Open, FileAccess.Read);
                picboxPhoto.Image = Image.FromStream(fs);
                
                fs.Close();
                fs.Dispose();
               
            }
            btnSave.Enabled = true;

        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 判断是否有history文件夹
            string historyPath = Application.StartupPath.Replace("bin\\Debug", "Resources\\images\\history");
            if (!Directory.Exists(historyPath))
            {
                Directory.CreateDirectory(historyPath);
            }

            //备份文件路径 
            string backupPath = this.stu.photo.Replace(".jpg", "_" + DateTime.Now.ToString().Replace("/", "_").Replace(" ", "_").Replace(":", "") + ".jpg").Replace("student","history");

            //将原头像保存至hitory文件夹，选择的头像替换到student文件夹中
            if (this.newPath != this.stu.photo && this.newPath != null)
            {
                //File.Replace( this.stu.photo, newPath, backupPath );
                FileInfo file = new FileInfo(this.stu.photo);

                if(!File.Exists(backupPath)  )
                {
                    file.MoveTo(backupPath);
                    
                }

                if(!File.Exists(this.stu.photo))
                {
                    File.Copy(this.newPath, this.stu.photo);
                }               
            }

            this.stu.name = txtboxName.Text;
            this.stu.password = txtPassword.Text;
            this.stu.gender = cbboxGender.Text;
            this.stu.class_id = cbboxClass.SelectedIndex + 1;


            //MessageBox.Show(this.stu.class_id.ToString());
            // 将非文件信息存储至数据库中
            string sqlUpdate = "UPDATE student \n" +
                "SET student.name = '" + this.stu.name+"',\n" +
                "student.gender = '"+this.stu.gender+"',\n" +
                "student.password = '"+this.stu.password+"',\n" +
                "student.class_id = "+this.stu.class_id+" \n" +
                "WHERE\n" +
                "	student.scode = '"+this.stu.scode+"';";

            DBHelper.GetExcuteNonQuery(sqlUpdate);

        }


        


        private void FrmStuInfo_Activated(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            string sqlInque = "select * from stu_cla_maj where 学号 = '" + this.stu.scode + "' ;";
            SqlDataReader sqlData = DBHelper.GetDataReader(sqlInque);
            sqlData.Read();
            txtboxScode.Text = this.stu.scode;
            this.stu.name = txtboxName.Text = sqlData[2].ToString();
            this.stu.password = txtPassword.Text = sqlData[3].ToString();
            this.stu.gender = cbboxGender.Text = sqlData[4].ToString();
            cbboxClass.Text = sqlData[5].ToString();
            txtboxMajor.Text = sqlData[6].ToString();
            sqlData.Close();

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

            sqldata.Close();
        }

        private void CbboxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtboxScode_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbboxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtboxMajor_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicboxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
