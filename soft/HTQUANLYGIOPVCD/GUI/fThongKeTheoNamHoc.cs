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
    public partial class fThongKeTheoNamHoc : Form
    {
        public fThongKeTheoNamHoc()
        {
            InitializeComponent();
        }

        private void fThongKeTheoNamHoc_Load(object sender, EventArgs e)
        {
            cmbloc.SelectedIndex = 0;
            
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            string luachon = cmbloc.SelectedItem.ToString();
            int ketqua = Convert.ToInt32(luachon);
            DateTime ngaybatdau = dtpbatdau.Value;
            DateTime ngayketthuc = dtpketthuc.Value;
            // TODO: This line of code loads data into the 'ThongKeTheoNamHoc.sp_ThongKeTheoNamHoc' table. You can move, or remove it, as needed.
            this.sp_ThongKeTheoNamHocTableAdapter.Fill(this.ThongKeTheoNamHoc.sp_ThongKeTheoNamHoc,ngaybatdau,ngayketthuc,ketqua);

            this.rptthongkenamhoc.RefreshReport();
        }

        private void rptthongkenamhoc_SizeChanged(object sender, EventArgs e)
        {
            rptthongkenamhoc.Width = 1200;
            rptthongkenamhoc.Height = 450;
        }
    }
}
