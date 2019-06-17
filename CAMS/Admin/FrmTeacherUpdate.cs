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

namespace CAMS.Admin
{
    public partial class FrmTeacherUpdate : Form
    {
        private string tcode;
        private string picPath;
        private string newPath;
        public FrmTeacherUpdate(string tcode)
        {
            InitializeComponent();
            this.tcode = tcode;
            InfoInit();
        }

        private void InfoInit()
        {
            cbxTitle.Items.Add("教授");
            cbxTitle.Items.Add("副教授");
            cbxTitle.Items.Add("讲师");
            cbxTitle.Items.Add("助教");
            cbxTitle.SelectedIndex = 0;
            cbxDegree.Items.Add("本科");
            cbxDegree.Items.Add("研究生");
            cbxDegree.Items.Add("硕士");
            cbxDegree.Items.Add("博士");
            cbxDegree.SelectedIndex = 0;
            string sql = "select * from teacher where tcode='" + this.tcode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(sql);
            if (sqlData.HasRows)
            {
                sqlData.Read();
                this.Text = sqlData["name"].ToString();
                txtName.Text = sqlData["name"].ToString();
                rtxtIntroduction.Text = sqlData["introduction"].ToString();
                this.picPath = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");

                FileStream fs = new FileStream(this.picPath, FileMode.Open, FileAccess.Read);
                picPhoto.Image = Image.FromStream(fs);
                fs.Close();
                fs.Dispose();

            }
            sqlData.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TeacherInfo CheckInfo()
        {
            TeacherInfo teacherInfo = new TeacherInfo();
            if(txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名！");
                return null;
            }
            else
            {
                teacherInfo.Name = txtName.Text;
            }
            if(rbtnMan.Checked)
            {
                teacherInfo.Gender = "男";
            }
            else
            {
                teacherInfo.Gender = "女";
            }
            teacherInfo.Degree = cbxDegree.Text;
            teacherInfo.Title = cbxTitle.Text;
            teacherInfo.Introduction = rtxtIntroduction.Text;
            return teacherInfo;
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg文件|*.jpg|gif文件|*.gif|bmp文件|*.bmp";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.newPath = Path.GetFullPath(openFileDialog.FileName);
                FileStream fs = new FileStream(this.newPath, FileMode.Open, FileAccess.Read);
                picPhoto.Image = Image.FromStream(fs);
                fs.Close();
                fs.Dispose();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            TeacherInfo teacherInfo = CheckInfo();
            if(teacherInfo != null)
            {
                if(this.newPath != this.picPath && newPath != null)
                {
                    File.Copy(newPath, picPath, true);
                }
                string sql = "UPDATE teacher SET name='" + teacherInfo.Name + "', gender='" + teacherInfo.Gender + "', degree='" + teacherInfo.Degree + "', title='" + teacherInfo.Title + "', introduction='" + teacherInfo.Introduction + "' WHERE tcode='" + this.tcode + "';";
                if(DBHelper.GetExcuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }
    }
}
