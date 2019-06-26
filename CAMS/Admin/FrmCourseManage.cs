using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAMS.Common;

namespace CAMS.Admin
{
    public partial class FrmCourseManage: Form
    {
        public FrmCourseManage()
        {
            InitializeComponent();
        }


        private string course_num;
        private string course_name;
        
        private void FrmCourseManage_Load(object sender, EventArgs e)
        {
            Style.DgvUI(this.dgvCourse);
            
            
        }

        private void DgvCourse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style.DgvBind(this.dgvCourse);
        }

        private void LinkCourse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://jwc.jxnu.edu.cn/MyControl/All_Display.aspx?UserControl=kcdg_print.ascx&kcmlh=" + this.dgvCourse.CurrentRow.Cells[1].Value.ToString();
            Process.Start("chrome.exe", url);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string waringStr = "确认删除课程？\n课程号为：" + this.course_num + "\n课程名为：" + this.course_name;
            string delSql = "DELETE \n" +
                            "FROM\n" +
                            "	curriculum \n" +
                            "WHERE\n" +
                            "	course_id IN ( SELECT id FROM course WHERE number = '"+this.course_num+"' );\n" +
                            "DELETE \n" +
                            "FROM\n" +
                            "	course \n" +
                            "WHERE\n" +
                            "	number = '"+this.course_num+"';";

            //MessageBox.Show(waringStr);
            DialogResult result = MessageBox.Show(waringStr, "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(delSql);
                if (DBHelper.GetExcuteNonQuery(delSql) > 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
         }

        private void DgvCourse_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            course_num = dgvCourse.Rows[dgvCourse.CurrentCell.RowIndex].Cells[1].Value.ToString();
            course_name = dgvCourse.Rows[dgvCourse.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }

        private void FrmCourseManage_Activated(object sender, EventArgs e)
        {
            string sql = "select category_course.name, course.number, course.cname, curriculum.isdegree, course.score, course.chour, course.lhour, course.tchour, course.tlhour, curriculum.semester from course, curriculum, category_course where course.id=curriculum.course_id and curriculum.category_id=category_course.id order by semester;";
            DataTable table = DBHelper.GetFillData(sql);
            this.dgvCourse.DataSource = table;
            for (int i = 0; i < this.dgvCourse.ColumnCount; i++)
            {
                this.dgvCourse.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form frmAdd = new FrmCourseAdd(this);
            frmAdd.ShowDialog();
        }
    }
}
