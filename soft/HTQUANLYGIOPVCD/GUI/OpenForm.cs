using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            if (formchild != null)
            {
                formchild.Close();
            }
            formchild = child;
            child.TopLevel = false;      
            child.Dock = DockStyle.None;
            int x = (panelmain.Width - child.Width) / 2;
            int y = (panelmain.Height - child.Height) / 2;
            child.Location = new Point(x, y);
            panelmain.Controls.Add(child);
            panelmain.Tag = child;
            child.BringToFront();
            child.Show();
        }

        public void OpenReportForm(Form child)
        {
            if (formchild != null)
            {
                formchild.Close();
            }
            formchild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.None;
            ReportViewer reportViewer = new ReportViewer();
            // Cấu hình ReportViewer tại đây (nếu cần)
            reportViewer.Dock = DockStyle.None;
            // Điều chỉnh kích thước và vị trí của ReportViewer
            reportViewer.Size = new Size(800, 100); // Thay đổi kích thước này theo ý muốn của bạn
            reportViewer.Location = new Point(10, 10); // Thay đổi vị trí này theo ý muốn của bạn
            panelmain.Controls.Add(child);
            panelmain.Tag = child;
            child.Show();
        }
    }
}
