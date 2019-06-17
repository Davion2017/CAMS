using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Admin
{
    public partial class FrmTeacherAdd : Form
    {
        string newPath;
        public FrmTeacherAdd()
        {
            InitializeComponent();
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
        }

        private TeacherInfo CheckInfo()
        {
            TeacherInfo teacherInfo = new TeacherInfo();
            //教工号验证
            if(txtTcode.Text.Trim() == "")
            {
                MessageBox.Show("请输入教工号！");
                txtTcode.Focus();
                return null;
            }
            else if (txtTcode.Text.Trim() == "")
            {
                MessageBox.Show("教工号只能为十位以内的数字，请重新输入！");
                txtTcode.Focus();
                return null;
            }

            //姓名验证
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名！");
                txtName.Focus();
                return null;
            }
            else
            {
                teacherInfo.Name = txtName.Text;
            }

            //判定性别
            if (rbtnMan.Checked)
            {
                teacherInfo.Gender = "男";
            }
            else
            {
                teacherInfo.Gender = "女";
            }

            //密码验证
            string passWd = this.txtPasswd.Text.Trim();
            string rePassWd = this.txtRePasswd.Text.Trim();
            if(passWd == "")
            {
                MessageBox.Show("请输入密码！");
                txtPasswd.Focus();
                return null;
            }
            if(rePassWd == "")
            {
                MessageBox.Show("请再输一遍密码！");
                txtRePasswd.Focus();
                return null;
            }
            if(passWd == rePassWd)
            {
                teacherInfo.Password = passWd;
            }
            else
            {
                MessageBox.Show("两次密码不等，请重新输入！");
                txtPasswd.Focus();
                return null;
            }

            //获取其他信息
            teacherInfo.Tcode = txtTcode.Text.Trim();
            teacherInfo.Degree = cbxDegree.Text;
            teacherInfo.Title = cbxTitle.Text;
            teacherInfo.Introduction = rtxtIntroduction.Text;
            return teacherInfo;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            TeacherInfo teacherInfo = CheckInfo();
            if(teacherInfo != null)
            {
                teacherInfo.Photo = "~\\images\\teacher\\" + teacherInfo.Tcode + ".jpg";
                string sql = "insert into teacher(tcode, name, password, gender, degree, title, introduction, photo) values('" + teacherInfo.Tcode + "', '" + teacherInfo.Name + "', '" + teacherInfo.Password + "', '" + teacherInfo.Gender + "', '" + teacherInfo.Degree + "', '" + teacherInfo.Title + "', '" + teacherInfo.Introduction + "', '" + teacherInfo.Photo + "');";
                if (DBHelper.GetExcuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("添加成功！");
                    if (picPhoto.Image != null)
                    {
                        string picPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Resources\\images\\teacher\\" + teacherInfo.Tcode + ".jpg";
                        File.Copy(this.newPath, picPath, true);
                    }
                    this.Close();
                }
            }
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg文件|*.jpg|gif文件|*.gif|bmp文件|*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPath = Path.GetFullPath(openFileDialog.FileName);
                FileStream fs = new FileStream(newPath, FileMode.Open, FileAccess.Read);
                picPhoto.Image = Image.FromStream(fs);
                fs.Close();
                fs.Dispose();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
