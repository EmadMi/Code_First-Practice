using Code_First_Practice.Infrastructrue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_Practice
{
    public partial class Persons : Form
    {
        public Persons()
        {
            InitializeComponent();
            new ReshapeTextBox(this);
            new ReshapeGrid(this);
            new ReshapeForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {

                throw;
            }
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            try
            {
                Thread FillGrid = new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    gridPersons.Invoke(new MethodInvoker(delegate
                    {
                        gridPersons.DataSource = null;
                        gridPersons.DataSource = (new Person()).Read();
                    }));
                });
                FillGrid.Start();
            }
            catch
            {

                throw;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch
            {

                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Register myfrm = new Register();
                myfrm.ShowDialog();
                //
                FillGrid();
            }
            catch
            {

                throw;
            }
        }

        void FillGrid()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.Text) &&
                    txtSearch.Text.Trim() != txtSearch.AccessibleName.Trim())
                {
                    gridPersons.DataSource = null;
                    gridPersons.DataSource = (new Person()).Read(txtSearch.Text);
                }
                else
                {
                    gridPersons.DataSource = null;
                    gridPersons.DataSource = (new Person()).Read();
                }
            }
            catch
            {

                throw;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(((Button)sender).Tag.ToString());
                Register myfrm = new Register("Edit", Id);
                myfrm.ShowDialog();
                //
                FillGrid();
            }
            catch
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا مطمئن به حذف این مورد هستید؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(((Button)sender).Tag.ToString());
                    //
                    bool DeleteResult = (new Person()).DeletePerson(Id);
                    //
                    if (DeleteResult)
                    {
                        FillGrid();
                    }
                    else
                    {
                        MessageBox.Show("در اجرای عملیات خطایی رخ داده است.");
                    }
                }
            }
            catch
            {

                throw;
            }
        }
    }
}
