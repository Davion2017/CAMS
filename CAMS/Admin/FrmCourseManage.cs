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

        private void FrmCourseManage_Load(object sender, EventArgs e)
        {
            Style.DgvUI(this.dgvCourse);
            string sql = "select category_course.name, course.number, course.cname, curriculum.isdegree, course.score, course.chour, course.lhour, course.tchour, course.tlhour, curriculum.semester from course, curriculum, category_course where course.id=curriculum.course_id and curriculum.category_id=category_course.id order by semester;";
            DataTable table = DBHelper.GetFillData(sql);
            this.dgvCourse.DataSource = table;
            for (int i = 0; i < this.dgvCourse.ColumnCount; i++)
            {
                this.dgvCourse.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
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
    }
}
