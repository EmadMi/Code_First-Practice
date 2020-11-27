using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_Practice
{
    public partial class Register : Form
    {
        db db = new db();
        //
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public Register()
        {
            InitializeComponent();
        }
        public void RegisterPerson(Person NewPerson)
        {
            db.Persons.Add(NewPerson);
            db.SaveChanges();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                lblWarning.Text = "";
                bool IsValid = true;
                string ErrMsg = "";
                //
                if (string.IsNullOrEmpty(txtFullName.Text))
                {
                    IsValid = false;
                    ErrMsg = "لطفا نام و نام خانوادگی خود را وارد نمایید." + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(txtNationCode.Text))
                {
                    IsValid = false;
                    ErrMsg = "لطفا کد ملی خود را وارد نمایید." + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(txtMobileNumber.Text))
                {
                    IsValid = false;
                    ErrMsg = "لطفا شماره همراه خود را وارد نمایید." + Environment.NewLine;
                }
                //
                if (IsValid)
                {
                    Person NewPerson = new Person();
                    NewPerson.FullName = txtFullName.Text;
                    NewPerson.NationCode = txtNationCode.Text;
                    NewPerson.MobileNumber = txtMobileNumber.Text;
                    NewPerson.SexType = (rdbMan.Checked ? true : false);
                    //
                    RegisterPerson(NewPerson);
                }
                else
                {
                    lblWarning.Text = ErrMsg;
                }
            }
            catch (Exception ex)
            {
                string Msg = ex.Message;
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                string Msg = ex.Message;
                throw;
            }
        }
    }
}
