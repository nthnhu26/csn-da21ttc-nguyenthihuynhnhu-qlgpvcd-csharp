using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fMain : Form
    {
        private OpenForm openform;
        public fMain()
        {
            InitializeComponent();
            openform = new OpenForm(frameform);
        }


        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fGiangVien());

        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.CloseChildForm();
        }
    }
}
