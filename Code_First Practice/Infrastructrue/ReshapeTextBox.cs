using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Code_First_Practice.Infrastructrue
{
    public class ReshapeTextBox
    {
        Color txtText = Color.Black;
        Color txtDesc = Color.Gray;
        Font MyFont = new Font("Vazir", 9, FontStyle.Regular);
        public ReshapeTextBox(Control ctrl)
        {
            setHintToText(ctrl);
        }

        public void setHintToText(Control control)
        {
            try
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                    {
                        ctrl.TextChanged += ctrl_TextChanged;
                        ctrl.Leave += txt_Leave;
                        ctrl.MouseUp += ctrl_MouseUp;
                        ctrl.KeyDown += ctrl_KeyDown;
                        ctrl.Enter += ctrl_Enter;
                        ctrl.MouseMove += ctrl_MouseMove;
                        txt_Leave(ctrl, EventArgs.Empty);
                        ctrl.Font = MyFont;
                    }
                    //
                    if (ctrl.HasChildren)
                    {
                        setHintToText(ctrl);
                    }
                }
            }
            catch
            {

                throw;
            }
        }

        void ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                //
                if (txt.Text == txt.AccessibleName)
                {
                    txt.SelectionLength = 0;
                }
            }
            catch
            {

                throw;
            }
        }

        void ctrl_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                //
                if (txt.Text == txt.AccessibleName)
                {
                    txt.SelectionStart = 0;
                }
            }
            catch
            {

                throw;
            }
        }

        void ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                //
                if (txt.Text == txt.AccessibleName)
                {
                    if (e.KeyCode == Keys.Delete ||
                        e.KeyCode == Keys.Left ||
                        e.KeyCode == Keys.Back ||
                        e.KeyCode == Keys.End)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch
            {

                throw;
            }
        }

        void ctrl_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                //
                if (txt.Text == txt.AccessibleName)
                {
                    txt.DeselectAll();
                    txt.SelectionStart = 0;
                }
            }
            catch
            {

                throw;
            }
        }

        void ctrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                //
                if (txt.Text != txt.AccessibleName)
                {
                    txt.ForeColor = txtText;
                    if ((txt.Text.Length == txt.AccessibleName.Length + 1 &&
                        txt.Text.Contains(txt.AccessibleName)))
                    {
                        txt.Text = txt.Text.Replace(txt.AccessibleName, "");
                        txt.SelectionStart = 1;
                        Label lbl = new Label();
                        lbl.Name = "lbl" + txt.Name;
                        lbl.Text = "   " + txt.AccessibleName;
                        lbl.AutoSize = false;
                        lbl.Width = txt.Width;
                        lbl.Height = 23;
                        lbl.BackColor = Color.Transparent;
                        lbl.TextAlign = ContentAlignment.MiddleLeft;
                        Point pt = new Point(txt.Location.X, txt.Location.Y - txt.Height);
                        lbl.Location = pt;
                        txt.Parent.Controls.Add(lbl);
                    }
                    else if (txt.Text.Length == 0)
                    {
                        txt.Text = txt.AccessibleName;
                        txt.ForeColor = txtDesc;
                        txt.SelectionStart = 0;
                        //
                        if (txt.Parent.Controls.Find("lbl" + txt.Name, true).Count() != 0)
                        {
                            txt.Parent.Controls.Remove(txt.Parent.Controls.Find("lbl" + txt.Name, true)[0]);
                        }
                    }
                }
            }
            catch
            {

                throw;
            }
        }

        void txt_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                //
                if (txt.Text.Trim() == "" || txt.Text == txt.AccessibleName)
                {
                    txt.Text = txt.AccessibleName;
                    txt.ForeColor = txtDesc;
                    //
                    if (txt.Parent.Controls.Find("lbl" + txt.Name, true).Count() != 0)
                    {
                        txt.Parent.Controls.Remove(txt.Parent.Controls.Find("lbl" + txt.Name, true)[0]);
                    }
                }
            }
            catch
            {

                throw;
            }
        }

        public void setDefaultValueToText(Control control)
        {
            try
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                    {
                        if (ctrl.AccessibleDescription != null && ctrl.AccessibleDescription.Trim() != "")
                        {
                            ctrl.Text = "";
                            txt_Leave(ctrl, EventArgs.Empty);
                        }
                    }
                    //
                    if (ctrl.HasChildren)
                    {
                        setDefaultValueToText(ctrl);
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
