using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            skinEngine1.SkinFile = Application.StartupPath.Replace("bin\\Debug", "") + @"/Resources/Skins/mp10.ssk";
        }
    }
}
