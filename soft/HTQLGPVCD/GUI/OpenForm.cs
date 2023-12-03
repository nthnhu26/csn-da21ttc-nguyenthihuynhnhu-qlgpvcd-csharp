using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public class OpenForm
    {
        private Form formchild;
        private Panel panelmain;
        public OpenForm(Panel mainpanel)
        {
            panelmain = mainpanel;
        }
        public void OpenChildForm(Form child)
        {
            if(formchild != null)
            {
                formchild.Close();
            }
            formchild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;

            panelmain.Controls.Add(child);
            panelmain.Tag = child;

            child.BringToFront();
            child.Show();

        }

        public void CloseChildForm()
        {
            if (formchild != null)
            {
                formchild.Close();
                panelmain.Controls.Remove(formchild);
            }
        }

    }
}
