using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Admin
{
    public partial class FrmClassAdd : Form
    {
        public FrmClassAdd()
        {
            InitializeComponent();
        }

        private string number, cname, semester;
        public FrmClassAdd(string number, string cname, string semester)
        {
            InitializeComponent();
            this.number = number;
            this.cname = cname;
            this.semester = semester;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isRight()
        {
            string course_id = DBHelper.ExecuteScalar<int>("select id from course where number='" + number + "';").ToString();
            string teacher_id = DBHelper.ExecuteScalar<int>("select id from teacher where name='"
                    + cbxTeacherList.Text + "';").ToString();
            string sql = "select count(*) from course_class WHERE course_id='" + course_id + "' and teacher_id='" + teacher_id + "';";
            if(DBHelper.ExecuteScalar<int>(sql) > 0)
            {
                MessageBox.Show("该教师已开设此课程，请选择其他教师！！");
                return false;
            }
            return true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(txtClassSize.Text.Trim() == "")
            {
                MessageBox.Show("请输入班级容量！");
            }
            else
            {
                if (isRight())
                {
                    string course_id = DBHelper.ExecuteScalar<int>("select id from course where number='" + number + "';").ToString();
                    string teacher_id = DBHelper.ExecuteScalar<int>("select id from teacher where name='"
                        + cbxTeacherList.Text + "';").ToString();
                    string sql = "INSERT INTO course_class(course_id, teacher_id, max_class_size, semester_id)" +
                        " VALUES('" + course_id + "', '" + teacher_id + "', '" + txtClassSize.Text.Trim() + "'," +
                        " '" + semester + "');";
                    if (DBHelper.GetExcuteNonQuery(sql) > 0)
                    {
                        MessageBox.Show("添加成功！！！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！！！");
                    }
                }
            }
        }

        private void FrmClassAdd_Load(object sender, EventArgs e)
        {
            labNumber.Text = number;
            labCname.Text = cname;

            string sql = "select id, name from teacher;";
            DataTable table = DBHelper.GetFillData(sql);
            cbxTeacherList.DataSource = table;
            cbxTeacherList.DisplayMember = "name";
            cbxTeacherList.ValueMember = "id";
        }

    }
}
