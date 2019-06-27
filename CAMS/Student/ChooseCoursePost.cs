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

namespace CAMS.Student
{
    public partial class ChooseCoursePost : UserControl
    {
        StudentInfo stu = new StudentInfo();
        public ChooseCoursePost()
        {
            InitializeComponent();
        }
        public ChooseCoursePost(string Account)
        {
            InitializeComponent();
            this.stu = new StudentInfo(Account);
            stu.scode = Account;
        }
    }
}
