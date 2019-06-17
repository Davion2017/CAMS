using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAMS.Common
{
    class Style
    {
        /// <summary>
        /// 初始化Dgv样式
        /// </summary>
        /// <param name="gridView"></param>
        public static void DgvUI(DataGridView gridView)
        {
            //设置行列行列不可更改
            gridView.AllowUserToOrderColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.RowHeadersVisible = false;
            gridView.AllowUserToAddRows = false;

            //设置单元格居中
            DataGridViewCellStyle viewCellStyle = new DataGridViewCellStyle();
            viewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.DefaultCellStyle = viewCellStyle;

            //设置表头居中
            gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn item in gridView.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //奇数偶数行颜色
            foreach(DataGridViewRow item in gridView.Rows)
            {
                if(item.Index % 2 == 0)
                {
                    gridView.Rows[item.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    gridView.Rows[item.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
