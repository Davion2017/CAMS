using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Student
{
    public partial class FrmStudent : Form
    {
        private string Account;
        public FrmStudent(string account)
        {
            InitializeComponent();
            this.Account = account;
        }
    }
}
