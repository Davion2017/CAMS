using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Teacher
{
    public partial class FrmTeacher : Form
    {
        private string Account;
        public FrmTeacher(string account)
        {
            InitializeComponent();
            this.Account = account;
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
