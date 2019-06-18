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
    public partial class FrmStuAdd : Form
    {
        string photoPath;
        public FrmStuAdd(Form parent)
        {
            InitializeComponent();
            this.Owner = parent;
        }

        private void FrmStuAdd_Load(object sender, EventArgs e)
        {

        }

        private void FrmStuAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            StudentInfo student = CheckInfo();
            if(student != null)
            {
                string str = "INSERT INTO [dbo].[student]([scode], [name], [password], [gender], [photo], [class_id]) VALUES ( '" + student.scode + "', '" + student.name + "', '" + student.password + "', '" + student.gender + "', '" + student.photo + "', " + student.class_id + ");";


                if (DBHelper.GetExcuteNonQuery(str) > 0)
                {
                    MessageBox.Show("添加成功！");
                    if (picboxPhoto.Image != null)
                    {
                        string picPath = Application.StartupPath.Replace("\\bin\\Debug", "\\Resources") + student.photo.Replace("~", "");
                        File.Copy(photoPath, picPath, true);
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
                photoPath = Path.GetFullPath(openFileDialog.FileName);
                FileStream fs = new FileStream(photoPath, FileMode.Open, FileAccess.Read);
                picboxPhoto.Image = Image.FromStream(fs);

                fs.Close();
                fs.Dispose();
                
            }

        }




        private void FrmStuAdd_Activated(object sender, EventArgs e)
        {
            string sqlSelect = "select max(scode) from student;";
            SqlDataReader sqlData = DBHelper.GetDataReader(sqlSelect);
            if(sqlData.HasRows)
            {
                sqlData.Read();
                if(sqlData[0].ToString() == "")
                {
                    labelScode.Text = "201726705000";
                }
                else
                {
                    //MessageBox.Show((Convert.ToInt64(sqlData[0].ToString()) + 1).ToString());
                    labelScode.Text = (Convert.ToInt64(sqlData[0].ToString()) + 1).ToString();
                }
                //MessageBox.Show((Convert.ToInt64(sqlData[0].ToString()) + 1).ToString());
                //labelScode.Text = (Convert.ToInt64(sqlData[0].ToString()) + 1).ToString();
                sqlData.Close();
            }
            else
            {
                labelScode.Text = "201726705000";
            }
           

            cbboxClass.SelectedIndex = 0;
            cbboxGender.SelectedIndex = 0;

        }



        private void CbboxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "SELECT major.name\n" +
                         "FROM class, major\n" +
                         "where major.id = class.major_id AND class.id = "+(cbboxClass.SelectedIndex+1)+";";

            SqlDataReader sqlData = DBHelper.GetDataReader(str);
            sqlData.Read();

            txtboxMajor.Text = sqlData[0].ToString();
            sqlData.Close();

            cbboxClass.Enabled = false;
            cbboxClass.Enabled = true;


        }

        private void CbboxClass_MouseEnter(object sender, EventArgs e)
        {
            
        }


        private StudentInfo CheckInfo()
        {
            StudentInfo studentInfo = new StudentInfo();

            //姓名验证
            if (txtboxName.Text.IndexOf(" ") >= 0 || txtboxName.Text == "")
            {
                MessageBox.Show("不可有空格！");
                txtboxName.Focus();
                return null;
            }

            if (txtboxPwd.Text == "" || txtboxPwd.Text.IndexOf(" ") >= 0)
            {
                MessageBox.Show("不可有空格！");
                txtboxPwd.Focus();
                return null;
            }

            if (picboxPhoto.Image == null)
            {
                MessageBox.Show("请选择照片！");
                btnPhoto.Focus();
                return null;
            }

            studentInfo.scode = labelScode.Text;
            studentInfo.name = txtboxName.Text;
            studentInfo.password = txtboxPwd.Text;
            studentInfo.gender = cbboxGender.Text;
            studentInfo.photo = "~\\images\\student\\" + studentInfo.scode + ".jpg";
            studentInfo.class_id = cbboxClass.SelectedIndex + 1;

            return studentInfo;
        }
    }
}
