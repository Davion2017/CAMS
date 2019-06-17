﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Admin
{
    public partial class FrmAdminTeacher : Form
    {
        public FrmAdminTeacher()
        {
            InitializeComponent();
            TeacherInit();
        }

        private void TeacherInit()
        {
            string sql = "select tcode, name, gender from teacher";
            DataTable table = DBHelper.GetFillData(sql);
            dgvTeacher.DataSource = table;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string tcode = dgvTeacher.CurrentRow.Cells[0].Value.ToString();
            FrmTeacherInfo teacherInfo = new FrmTeacherInfo(tcode);
            teacherInfo.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string tcode = dgvTeacher.CurrentRow.Cells[0].Value.ToString();
            FrmTeacherUpdate teacherUpdate = new FrmTeacherUpdate(tcode);
            teacherUpdate.ShowDialog();
            TeacherInit();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string tcode = dgvTeacher.CurrentRow.Cells[0].Value.ToString();
            string sql = "DELETE FROM teacher WHERE tcode='" + tcode + "';";
            if(DBHelper.GetExcuteNonQuery(sql) > 0)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}