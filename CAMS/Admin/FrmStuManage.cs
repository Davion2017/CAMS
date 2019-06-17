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

namespace CAMS.Admin
{

    

    public partial class FrmStuManage : Form
    {
        public struct Stu
        {
            public string name;
            public string scode;
            public string gender;
            public string photo;
            public string class_id;
        }
        public Stu stu = new Stu();

        

        public FrmStuManage(Form parent)
        {
            InitializeComponent();
            this.Owner = parent;
        }



        

        private void FrmStuManage_Load(object sender, EventArgs e)
        {
            dgvStu.AllowUserToResizeColumns = false;
            dgvStu.RowHeadersVisible = false;

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
            inquire.Clone();


            
        }


        //使单元格中的字符串居中
        private void DgvStu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        // 防止背景颜色因为排序后消失
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

        //窗口关闭回到 FrmAdmin界面
        private void FrmStuManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
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
                picboxStu.Image = Image.FromFile(this.stu.photo);

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
    }
}
