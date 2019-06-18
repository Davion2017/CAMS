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
using CAMS.Admin;
namespace CAMS.Admin
{

    



    public partial class FrmStuManage : Form
    {


        StudentInfo stu = new StudentInfo();

        

        public FrmStuManage(Form parent)
        {
            InitializeComponent();
            this.Owner = parent;
        }      
        private void FrmStuManage_Load(object sender, EventArgs e)
        {
            dgvStu.AllowUserToResizeColumns = false;
            dgvStu.RowHeadersVisible = false;

                       
        }


        //使单元格中的字符串居中
        private void DgvStu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        //窗口关闭回到 FrmAdmin界面
        private void FrmStuManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Owner.Refresh();
        }


        
        
        //定位到光标所在行
        private void DgvStu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.stu.scode = dgvStu.Rows[dgvStu.CurrentCell.RowIndex].Cells[1].Value.ToString();

            this.stu.name = dgvStu.Rows[dgvStu.CurrentCell.RowIndex].Cells[2].Value.ToString();
            labelScode.Text = this.stu.scode;
            labelName.Text = this.stu.name;


            string sqlphoto = "select photo from student where scode = '" + this.stu.scode + "';";

            SqlDataReader sqldata = DBHelper.GetDataReader(sqlphoto);
            if (sqldata.HasRows)
            {
                sqldata.Read();
                this.stu.photo = sqldata[0].ToString().Replace("~", Application.StartupPath.Replace("\\bin\\Debug", "\\Resources"));   
                
                FileStream fileStream = File.Open(this.stu.photo, FileMode.Open, FileAccess.Read);
                picboxStu.Image = Image.FromStream(fileStream);

                fileStream.Close();
                fileStream.Dispose();

                //MessageBox.Show(this.stu.photo);
            }

            labelScode.BackColor = this.BackColor;
            labelName.BackColor = this.BackColor;

        }

        private void TbnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出系统？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if(labelScode.Text == "" || labelScode.Text == "学号")
            {
                MessageBox.Show("没有学生, 操作失败!");
                
            }
            else
            {
                //MessageBox.Show(labelScode.Text);
                FrmStuInfo fsi = new FrmStuInfo(this, this.stu.scode);
                fsi.Show();
                this.Hide();

            }
            

        }

        private void DgvStu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dgvStu.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dgvStu.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dgvStu.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void FrmStuManage_Activated(object sender, EventArgs e)
        {
            string inquire = "SELECT * FROM stu_cla_maj;";

            DataTable dtable = DBHelper.GetFillData(inquire);
            dgvStu.DataSource = dtable;
            foreach (DataGridViewRow dgvRow in dgvStu.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dgvStu.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dgvStu.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void BtnAddStu_Click(object sender, EventArgs e)
        {
            FrmStuAdd stuAdd = new FrmStuAdd(this);
            stuAdd.Show();
            this.Hide();
        }

        private void BtnDelStu_Click(object sender, EventArgs e)
        {
            string delphoto = this.stu.photo;
            string waringStr = "确认删除\n学号为：" + this.stu.scode + "\n姓名为：" + this.stu.name + "的学生吗?";
            string delSql = "DELETE FROM student where scode = '" +labelScode.Text+ "';";
            //MessageBox.Show(delSql);
            DialogResult result = MessageBox.Show(waringStr, "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
                File.Delete(delphoto);
                DBHelper.GetExcuteNonQuery(delSql);
                FrmStuManage_Activated(sender, e);

                if(dgvStu.RowCount == 0)
                {
                    labelName.Text = "无学生";
                    labelScode.Text = "";
                    picboxStu.Image = null;
                }
            }
        }
    }
}
