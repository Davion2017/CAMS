using CAMS.Admin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CAMS.Student
{
    public partial class updateStuInfo : UserControl
    {
        readonly StudentInfo stu = new StudentInfo();
        SqlConnection con;
        private string newPath;
        private string picPath;

        public updateStuInfo(string Account)
        {
            InitializeComponent();
            this.stu =new StudentInfo(Account);
        }
        public updateStuInfo()
        {
            InitializeComponent();
        }

        private void UpdateStuInfo_Load(object sender, EventArgs e)
        {
            string s = "select * from student where scode='" + stu.scode + "';";
            SqlDataReader sqlData = YRHelper.GetDataReader(s);
            sqlData.Read();
            this.label5.Text = sqlData["name"].ToString();
            this.label6.Text = sqlData["scode"].ToString();
            this.label9.Text = sqlData["gender"].ToString();
            string l = "select class.name from class,student where class.id='" + sqlData["class_id"].ToString() + "' and student.class_id = class.id";
            SqlDataReader sqlData2 = YRHelper.GetDataReader(l);
            sqlData2.Read();
            this.label7.Text = sqlData2["name"].ToString();
            string k = "select major.name from class,major where class.id='" + sqlData["class_id"].ToString() + "' and major.id = class.major_id";
            SqlDataReader sqlData3 = YRHelper.GetDataReader(k);
            sqlData3.Read();
            this.label8.Text = sqlData3["name"].ToString();
            //显示学生个人信息

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string SqlStr = "Data Source=DESKTOP-R5GQMVG\\SQLEXPRESS;Initial Catalog=xk;Integrated Security=True";
            con = new SqlConnection(SqlStr);
            string s = "select * from student where scode='" + stu.scode + "';";
            SqlDataReader sqlData = YRHelper.GetDataReader(s);
            sqlData.Read();
            string strsql = "Update student set password ='" + textBox3.Text.Trim() + "' where scode='" + sqlData["scode"].ToString() + "'";
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
                    textBox3.Clear();
                }
            }
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
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg文件(*jpg)|*.jpg|bmp文件(*bmp)|*.bmp|gif文件(*gif)|*.gif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.newPath = Path.GetFullPath(op.FileName);
                FileStream fs = new FileStream(this.newPath, FileMode.Open, FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                textBox1.Text = this.newPath;
                fs.Close();
                fs.Dispose();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string sqlphoto = "select photo from student where scode = '" + this.stu.scode + "';";
            SqlDataReader sqlData = YRHelper.GetDataReader(sqlphoto);
            sqlData.Read();
            this.picPath= Application.StartupPath.Replace("bin\\Debug", "") + sqlData["photo"].ToString().Replace("~","Resources");
            FileStream fs= new FileStream(this.picPath, FileMode.Open, FileAccess.Read);
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
            else
            {
                MessageBox.Show("对不起，修改失败！");
            }

        }
    }
}
