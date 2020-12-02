using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_Practice.Infrastructrue
{
    class ReshapeForm
    {
        public ReshapeForm(Control ctrl)
        {
            setGraphicToForm(ctrl);
        }
        void setGraphicToForm(Control ctrl)
        {
            Form frm = ctrl as Form;
            frm.Activated += Frm_Activated;
            frm.Deactivate += Frm_Deactivate;
        }

        private void Frm_Deactivate(object sender, EventArgs e)
        {
            ((Form)sender).Opacity = 0.7;
        }

        private void Frm_Activated(object sender, EventArgs e)
        {
            ((Form)sender).Opacity = 1;
        }
    }
}
