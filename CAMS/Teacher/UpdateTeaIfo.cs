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
using System.IO;

namespace CAMS.Teacher
{
    public partial class UpdateTeaIfo : UserControl
    {
       
        TeacherInfo Tea = new TeacherInfo();
        SqlConnection con;
        string newPath;
        string picPath;
        public UpdateTeaIfo()
        {
            InitializeComponent();
        }
        public UpdateTeaIfo(string Account)
        {
            InitializeComponent();
            this.Tea.Tcode = Account;
        }
        private void UpdateTeaIfo_Load(object sender, EventArgs e)
        {
            string s = "select * from teacher where tcode='" + Tea.Tcode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(s);
            sqlData.Read();
            this.label2.Text = sqlData["name"].ToString();
            this.label4.Text = sqlData["gender"].ToString();
            this.label12.Text = sqlData["tcode"].ToString();
            this.label6.Text = sqlData["degree"].ToString();
            this.label8.Text = sqlData["title"].ToString();
            //显示教师个人信息
        }

        //密码修改及验证
        private void Button1_Click(object sender, EventArgs e)
        {
            string SqlStr = "Data Source=ECHO\\SQLEXPRESS;Initial Catalog=xk;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            string s = "select * from teacher where tcode='" + Tea.Tcode + "';";
            SqlDataReader sqlData = DBHelper.GetDataReader(s);
            sqlData.Read();
            string strsql = "Update teacher set password ='" + textBox1.Text.Trim() + "' where tcode='" + sqlData["tcode"].ToString() + "'";
            SqlCommand cmd = new SqlCommand(strsql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("修改成功");
                    textBox1.Clear();
                }              
                else { MessageBox.Show("修改失败"); }            }
            catch (Exception ex)
            {
                MessageBox.Show("修改错误，错误原因:" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg文件(*jpg)|*.jpg|bmp文件(*bmp)|*.bmp|gif文件(*gif)|*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.newPath = Path.GetFullPath(op.FileName);
                FileStream fs = new FileStream(this.newPath, FileMode.Open, FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                textBox2.Text = this.newPath;
                fs.Close();
                fs.Dispose();
            }

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            string sqlphoto = "select photo from teacher where tcode = '" + this.Tea.Tcode + "';";
            SqlDataReader sqlData = Dyy.GetDataReader(sqlphoto);
            sqlData.Read();
            this.picPath = Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~", "Resources");
            FileStream fs = new FileStream(this.picPath, FileMode.Open, FileAccess.Read);
            fs.Close();
            fs.Dispose();
            try
            {
                pictureBox1.Image = Image.FromStream(fs);
            }
            catch { }
            if (this.newPath != this.picPath && newPath != null)
            {
                File.Copy(newPath, picPath, true);
                MessageBox.Show("修改成功！");
            }
            else { MessageBox.Show("对不起，修改失败！"); }


        }

    }
}

