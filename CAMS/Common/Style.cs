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
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.RowHeadersVisible = false;
            gridView.AllowUserToAddRows = false;
            gridView.MultiSelect = false;
            

            gridView.ReadOnly = true;
            


            //设置单元格居中
            DataGridViewCellStyle viewCellStyle = new DataGridViewCellStyle();
            viewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridView.DefaultCellStyle = viewCellStyle;

            //设置表头居中
            gridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //foreach (DataGridViewColumn item in gridView.Columns)
            //{
            //    item.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}

            


            // 单元格宽度调整
            int width = 0;
            //对于DataGridView的每一个列都调整
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                //将每一列都调整为自动适应模式
                gridView.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                //记录整个DataGridView的宽度
                width += gridView.Columns[i].Width;
            }
            //判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，
            //则将DataGridView的列自动调整模式设置为显示的列即可，
            //如果是小于原来设定的宽度，将模式改为填充。
            if (width > gridView.Size.Width)
            {
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            //冻结某列 从左开始 0，1，2
            gridView.Columns[1].Frozen = true;

        }

        public static void DgvBind(DataGridView dataGridView)
        {
            foreach (DataGridViewRow dgvRow in dataGridView.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dataGridView.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dataGridView.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }


}
