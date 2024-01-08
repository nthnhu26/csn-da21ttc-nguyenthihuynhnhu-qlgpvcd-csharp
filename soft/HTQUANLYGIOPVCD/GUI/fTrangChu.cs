using BLL;
using DTO;
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
    public partial class fTrangChu : Form
    {
        private OpenForm openform;
        private ThongTinDangNhapBLL tengiangvienbll;
        public fTrangChu()
        {
            InitializeComponent();
            this.Resize += new EventHandler(fTrangChu_Resize);
            openform = new OpenForm(mainpanel);
            tengiangvienbll = new ThongTinDangNhapBLL();
        }
        private void fTrangChu_Resize(object sender, EventArgs e)
        {
            mainpanel.Left = (this.ClientSize.Width - mainpanel.Width) / 2;
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            string idgv = ThongTinDangNhap.Instance.IDGV;
            TenGiangVien(idgv);
            //Phân quyền người dùng
            if (ThongTinDangNhap.Instance.IDQTC == "admin")
            {
                this.toolStripButton2.Enabled = true;
                this.toolStripSplitButton1.Enabled = true;
            }
            openform.OpenChildForm(new fHoatDongTrangChu());
        }
        //Lấy tên người dùng hiện lên textbox
        private void TenGiangVien(string id)
        {
            string tengv = tengiangvienbll.TenGiangVienBLL(id);
            txttengv.Text = tengv;
        }

        private void giảngViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fGiangVien());
        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fHoatDong());
        }

        private void hoạtĐộngĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   openform.OpenChildForm(new fQuanLyHoatDong());         
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fTaiKhoan());
        }

        private void minhChứngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fMinhChung());
        }

        private void thongkegiangvien_Click(object sender, EventArgs e)
        {
          openform.OpenReportForm(new fThongKeGiangVien());
        }

        private void thongketheonamhoc_Click(object sender, EventArgs e)
        {
            openform.OpenReportForm(new fThongKeTheoNamHoc());
        }

        private void hoạtĐộngCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fNguoiDung());
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fCapNhatMatKhau());
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fHoatDongTrangChu());
        }

        private void thongkebomon_Click(object sender, EventArgs e)
        {
            openform.OpenReportForm(new fThongKeTheoBoMon());
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;

            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangNhap dangnhap = new fDangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fGiangVien());
        }

        private void hoạtĐộngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fHoatDong());
        }

        private void minhChúngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fMinhChung());
        }

        private void tàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fTaiKhoan());
        }

        private void thốngKêGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenReportForm(new fThongKeGiangVien());
        }

        private void giảngViênTheoBộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenReportForm(new fThongKeTheoBoMon());
        }

        private void giảngViênTheoNămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenReportForm(new fThongKeTheoNamHoc());
        }

        private void hoạtĐộngCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fNguoiDung());
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fCapNhatMatKhau());
        }
       
        private void fTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            /*
             *  bool isClosingConfirmed = false;
            if (!isClosingConfirmed)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK)
                {
                    e.Cancel = true; // Hủy sự kiện đóng form nếu người dùng chọn Cancel
                }
                else
                {
                    isClosingConfirmed = true;
                    Application.Exit(); // Thoát ứng dụng nếu người dùng chọn OK
                }
            }
            else
            {
                Application.Exit(); // Thoát mà không hiển thị lại hộp thoại xác nhận
            }
             * */
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            openform.OpenChildForm(new fHoatDongTrangChu());
        }




       
    }
}
