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
    public partial class FrmCourseAdd : Form
    {
        public FrmCourseAdd(Form owner)
        {
            InitializeComponent();
            this.Owner = owner;
        }

        private void FrmCourseAdd_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void FrmCourseAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int isdegree = 0;
            if (radiobtnIsDegree.Checked)
                isdegree = 1;



            if (combboxCate.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("请选择课程性质！");
            }
            else if(combboxProg.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("请选择培养方案！");
            }
            else if(txtboxCName.Text == "" || txtboxEName.Text == "")
            {
                MessageBox.Show("输入课程名！");
            }
            else if(txtNum.Text == "")
            {
                MessageBox.Show("输入课程号！");
            }
            else if( numudScore.Value == 0 || numudTChour.Value == 0 ||  numupdChour.Value == 0)
            {
                MessageBox.Show("请确认理论学时，学分已经全部选择！");
            }
            else
            {
                string sqlInsertCourse = "INSERT INTO [dbo].[course] ( [number], [cname], [ename], [score], [chour], [lhour], [tchour], [tlhour] )\n" +
                                   "VALUES\n" +
                                   "	( '" + txtNum.Text + "', '" + txtboxCName.Text + "', '" + txtboxEName.Text + "'," + numudScore.Text + ", " + numupdChour.Value + ", " + numudLhour.Value + ", " + numudTChour.Value + ", " + numudTChour.Value + " );";
                string sqlInsertcurriculum = "INSERT INTO [dbo].[curriculum]( [program_id], [course_id], [category_id], [semester], [isdegree]) VALUES ( 1, (SELECT id FROM course where number = '" + txtNum.Text + "'), " + (combboxCate.SelectedIndex+1) + ", " + numudSem.Value + ", " + isdegree + ");";



                string waringStr = "确认信息无误 添加？";
                DialogResult result = MessageBox.Show(waringStr, "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (DBHelper.GetExcuteNonQuery(sqlInsertCourse) == 1)
                    {
                        DBHelper.GetExcuteNonQuery(sqlInsertcurriculum);
                        MessageBox.Show("增加成功！");
                    }
                }
            }

           




        }
    }
}
