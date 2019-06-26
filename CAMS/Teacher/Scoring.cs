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

namespace CAMS.Teacher
{
    public partial class Scoring : UserControl
    {
        TeacherInfo Tea = new TeacherInfo();
        private string string1;
        public string String1
        {
            set
            {
                string1 = value;
            }
        }
        public Scoring()
        {
            InitializeComponent();
        }
        public Scoring(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strsql = "Update" +
                " class_student set gpa_score='" + textBox3.Text.Trim() + "'," +
                "paper_score='" + textBox4.Text.Trim() + "',practice_score='" + textBox5.Text.Trim() + "'," +
                "score='" + textBox6.Text.Trim() + "' " +
                "where course_class_id='" + textBox1.Text.Trim() + "' and student_id='" + textBox2.Text.Trim() + "'";
          
            try
            {

                if (Dyy.GetExcuteNonQuery(strsql) > 0)
                {
                    MessageBox.Show("评定成功");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                else
                {
                    MessageBox.Show("班级学生信息不存在");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改错误，错误原因:" + ex.Message);
            }
            finally
            {
                string sqlstr = " SELECT \n" +
                             " class_student.course_class_id 课程ID, \n" +
                             " class_student.student_id 学生ID, \n" +
                             " class_student.gpa_score 平时表现成绩, \n" +
                             " class_student.paper_score 理论考试成绩, \n" +
                             " class_student.practice_score 实践考核成绩, \n" +
                             " class_student.score 总评成绩 \n" +
                             " FROM class_student";
                dataGridView1.DataSource = Dyy.GetFillData(sqlstr);
            }
            
           
        }

        private void Scoring_Load(object sender, EventArgs e)
        {
            string sqlstr = " SELECT \n"+
                             " class_student.course_class_id 课程ID, \n"+
                             " class_student.student_id 学生ID, \n"+
                             " class_student.gpa_score 平时表现成绩, \n"+
                             " class_student.paper_score 理论考试成绩, \n"+
                             " class_student.practice_score 实践考核成绩, \n"+
                             " class_student.score 总评成绩 \n"+
                             " FROM class_student";
            dataGridView1.DataSource = Dyy.GetFillData(sqlstr);
        }
        //若已经评定的成绩有错，可由重做按钮进行修改
        private void Button2_Click(object sender, EventArgs e)
        {
            string strsql= "Update" +
                " class_student set gpa_score=NULL," +
                "paper_score=NULL,practice_score=NULL," +
                "score=NULL " +
                "where course_class_id='" + textBox1.Text.Trim() + "' and student_id='" + textBox2.Text.Trim() + "'";            
            try
            {
             
                if (Dyy.GetExcuteNonQuery(strsql)>0)
                {
                    MessageBox.Show("修改成功，请重新评定");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("修改失败");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改错误，错误原因:" + ex.Message);
            }
            finally
            {
                string sqlstr = " SELECT \n" +
                             " class_student.course_class_id 课程ID, \n" +
                             " class_student.student_id 学生ID, \n" +
                             " class_student.gpa_score 平时表现成绩, \n" +
                             " class_student.paper_score 理论考试成绩, \n" +
                             " class_student.practice_score 实践考核成绩, \n" +
                             " class_student.score 总评成绩 \n" +
                             " FROM class_student";
                dataGridView1.DataSource = Dyy.GetFillData(sqlstr);
            }
           
        }
    }
}
