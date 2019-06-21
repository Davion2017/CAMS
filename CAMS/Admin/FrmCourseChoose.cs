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
    public partial class FrmCourseChoose : Form
    {
        public FrmCourseChoose()
        {
            InitializeComponent();
        }

        private void FrmCourseChoose_Load(object sender, EventArgs e)
        {
            this.cbxSemester.Items.Add("第1学期");
            this.cbxSemester.Items.Add("第2学期");
            this.cbxSemester.Items.Add("第3学期");
            this.cbxSemester.Items.Add("第4学期");
            this.cbxSemester.Items.Add("第5学期");
            this.cbxSemester.Items.Add("第6学期");
            this.cbxSemester.Items.Add("第7学期");
            this.cbxSemester.Items.Add("第8学期");
            this.cbxSemester.SelectedIndex = 0;
            InitStatus();
        }

        private void InitStatus()
        {
            string sql = "select name from course_status where status='0';";
            this.labStatus.Text = DBHelper.ExecuteScalar<string>(sql);
            sql = "select name from current_semester where status='1';";
            this.labSemester.Text = DBHelper.ExecuteScalar<string>(sql);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string selectName = this.cbxSemester.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("确定要重置为"+ selectName + "吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                string sql = "UPDATE course_status SET status='0';";
                DBHelper.GetExcuteNonQuery(sql);
                sql = "UPDATE current_semester SET status='0' WHERE name='" + this.labSemester.Text + "'; UPDATE current_semester SET status='1' WHERE name='" + selectName + "'; ";
                DBHelper.GetExcuteNonQuery(sql);
            }
            InitStatus();
        }
    }
}
