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
    public partial class Register : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //
        string Mode = "";
        int Id = 0;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public Register(string _Mode = "Add",int _Id = 0)
        {
            InitializeComponent();
            new ReshapeTextBox(this);
            new ReshapeForm(this);
            //
            Mode = _Mode;
            Id = _Id;
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
                    NewPerson.Id = Id;
                    NewPerson.FullName = txtFullName.Text;
                    NewPerson.NationCode = txtNationCode.Text;
                    NewPerson.MobileNumber = txtMobileNumber.Text;
                    NewPerson.SexType = (rdbMan.Checked ? true : false);
                    //
                    if (!NewPerson.ExistPerson(NewPerson))
                    {
                        bool RegisterResult = false; 
                        switch (Mode)
                        {
                            case "Add":
                                {
                                    RegisterResult = NewPerson.RegisterPerson(NewPerson);
                                    //
                                    break;
                                }
                            case "Edit":
                                {
                                    RegisterResult = false;
                                    //
                                    break;
                                }
                        }
                        
                        if (RegisterResult)
                        {
                            lblWarning.Text = "ثبت اطلاعات با موفقیت انجام شد.";
                            //
                            Thread.Sleep(2000);
                            //
                            this.Close();
                        }
                        else
                        {
                            lblWarning.Text = "در ثبت اطلاعات خطایی رخ داده است.";
                        }
                    }
                    else
                    {
                        lblWarning.Text = "این کد ملی قبلا ثبت شده است.";
                    }
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
                this.Close();
            }
            catch (Exception ex)
            {
                string Msg = ex.Message;
                throw;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Mode)
                {
                    case "Add":
                        {
                            lblTitle.Text = "ثبت اطلاعات فرد";
                            imgTitle.Image = Properties.Resources.register50;
                            btnRegister.Text = "ثبت";
                            btnRegister.Image = Properties.Resources.personadd30;
                            break;
                        }
                    case "Edit":
                        {
                            lblTitle.Text = "ویرایش اطلاعات فرد";
                            imgTitle.Image = Properties.Resources.editperson50;
                            btnRegister.Text = "ویرایش";
                            btnRegister.Image = Properties.Resources.personedit30;
                            //
                            Person CurrentPerson = (new Person()).Read(Id);
                            //
                            txtFullName.Text = CurrentPerson.FullName;
                            txtNationCode.Text = CurrentPerson.NationCode;
                            txtMobileNumber.Text = CurrentPerson.MobileNumber;
                            if (CurrentPerson.SexType)
                                rdbMan.Checked = true;
                            else
                                rdbMan.Checked = true;
                            //
                            break;
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
