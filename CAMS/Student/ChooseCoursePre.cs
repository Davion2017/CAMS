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
using CAMS.Common;

namespace CAMS.Student
{
    public partial class ChooseCoursePre : UserControl
    {
        StudentInfo stu;
        string semester_id = DBHelper.ExecuteScalar<int>("select id from current_semester where status='1';").ToString();
        public ChooseCoursePre()
        {
            InitializeComponent();
        }
        public ChooseCoursePre(string Account)
        {
            InitializeComponent();
            this.stu = new StudentInfo(Account);
            stu.scode = Account;
        }

        private void ChooseCoursePre_Load(object sender, EventArgs e)
        {
            Style.DgvUI(dataGridView1);
            Style.DgvUI(dataGridView2);
            CourseInfo_Update();
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string student_id = DBHelper.ExecuteScalar<int>("select id from student where scode='" + this.stu.scode + "';").ToString();
            string strdel = "delete from plan_study_course where course_id='" + id + "' and student_id='" + student_id + "';";
            if (DialogResult.Yes == MessageBox.Show("您确定要删除该门课程?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
            CourseInfo_Update();
        }

        private void CourseInfo_Update()
        {
            this.dataGridView1.DataSource = DBHelper.GetFillData("select * from course;");

            string selectid = "select id from student where scode = '" + stu.scode + "';";
            SqlDataReader sqlData1 = YRHelper.GetDataReader(selectid);
            sqlData1.Read();
            string strselect = "select course.id,cname,ename,score from plan_study_course,course where course.id=plan_study_course.course_id and student_id = '" + sqlData1["id"] + "' and semester_id='" + semester_id + "';";
            dataGridView2.DataSource = YRHelper.GetFillData(strselect);
            sqlData1.Close();
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
            string course_id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string course_name = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            DialogResult result = MessageBox.Show("确定要选择" + course_name, "提醒", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                string sql = "INSERT INTO plan_study_course(course_id, semester_id, student_id) VALUES('"+course_id+"','"+semester_id+"','"+this.stu.id.ToString()+"');";
                if(DBHelper.GetExcuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("增选成功");
                }
                else
                {
                    MessageBox.Show("增选失败");
                }
            }
            CourseInfo_Update();
            //string cno = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
            //string sqlstatus = "select * from current_semester where status = '1';";
            //SqlDataReader sqlData = YRHelper.GetDataReader(sqlstatus);
            //sqlData.Read();
            ////获取semester_id做准备
            //string selectid = "select id from student where scode = '" + stu.scode + "';";
            //SqlDataReader sqlData1 = YRHelper.GetDataReader(selectid);
            //sqlData1.Read();
            ////获取student_id做准备
            //if (sqlData.HasRows)
            //{
            //    string stradd = "insert into plan_study_course(course_id,semester_id,student_id) values('" + cno + "','" + sqlData["id"] + "','" + sqlData1["id"] + "')";
            //    if (DialogResult.Yes == MessageBox.Show("您确定要增选该门课程?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //    {
            //        string sqlstr = "select course_id,student_id from plan_study_course where student_id = '" + sqlData1["id"] + "';";
            //        SqlDataReader sqlData2 = YRHelper.GetDataReader(sqlstr);
            //        sqlData2.Read();
            //        //获取已选课程中点中课程的course_id、student_id做准备
            //        string sqlstr1 = "Select * from plan_study_course where course_id = '" + cno + "' and student_id = '" + sqlData1["id"] + "';";
            //        SqlDataReader sqlData3 = YRHelper.GetDataReader(sqlstr1);
            //        sqlData3.Read();
            //        if (!sqlData3.HasRows)
            //        {
            //            string sqlstr2 = "Select * from plan_study_course where course_id = '" + cno + "' and course_id in(Select course_id from curriculum where semester = '" + sqlData["id"] + "')";
            //            SqlDataReader sqlData4 = YRHelper.GetDataReader(sqlstr2);
            //            sqlData4.Read();
            //            if (sqlData4.HasRows)
            //            {
            //                if (YRHelper.GetExcuteNonQuery(stradd) > 0)
            //                {
            //                    MessageBox.Show("增选成功");
            //                }
            //                else
            //                {
            //                    MessageBox.Show("增选失败");
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("该学期不可选此门课");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("该课已选");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("未选中行");
            //}
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string selectid = "select id from student where scode = '" + stu.scode + "';";
            SqlDataReader sqlData1 = YRHelper.GetDataReader(selectid);
            sqlData1.Read();
            string strselect = "select course.id,cname,ename,score from plan_study_course,course where course.id=plan_study_course.course_id and student_id = '" + sqlData1["id"] + "' and semester_id='" + semester_id + "';";
            dataGridView2.DataSource = YRHelper.GetFillData(strselect);
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style.DgvBind(dataGridView1);
        }

        private void DataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style.DgvBind(dataGridView1);
        }
    }
}
