using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_Practice.Infrastructrue
{
    class ReshapeGrid
    {
        public ReshapeGrid(Control ctrl)
        {
            setGridGraphic(ctrl);
        }
        public void setGridGraphic(Control control)
        {
            try
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (ctrl.GetType() == typeof(DataGridView))
                    {
                        DataGridView grid = ctrl as DataGridView;
                        //
                        grid.BackgroundColor = Color.Ivory;
                        grid.ForeColor = Color.Gray;
                        grid.RowsDefaultCellStyle.BackColor = Color.Ivory;
                        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
                        grid.DefaultCellStyle.SelectionForeColor = Color.Black;
                        grid.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
                        grid.AllowUserToAddRows = false;
                        grid.AllowUserToDeleteRows = false;
                        grid.AllowUserToResizeRows = false;
                        grid.AllowUserToResizeColumns = false;
                        grid.ReadOnly = true;
                        grid.BorderStyle = BorderStyle.None;
                        grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
                        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grid.RowHeadersVisible = false;
                        grid.MultiSelect = false;
                        grid.DataBindingComplete += Grid_DataBindingComplete;
                        grid.CellClick += Grid_CellClick;
                        grid.Refresh();
                    }
                }
            }
            catch
            {

                throw;
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in ((DataGridView)sender).Parent.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    if (((Button)item).AccessibleName == "Permissions")
                    {
                        ((Button)item).Enabled = true;
                        ((Button)item).Tag = ((DataGridView)sender).Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    }
                }
            }
        }

        private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
            ((DataGridView)sender).Columns["Id"].Visible = false;
            //
            foreach (var item in ((DataGridView)sender).Parent.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    if (((Button)item).AccessibleName == "Permissions")
                    {
                        ((Button)item).Enabled = false;
                        ((Button)item).Tag = null;
                    }
                }
            }
        }
    }
}
