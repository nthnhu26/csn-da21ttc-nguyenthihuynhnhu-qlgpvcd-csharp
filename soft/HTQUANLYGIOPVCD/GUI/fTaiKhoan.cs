using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class fTaiKhoan : Form
    {
        private TaiKhoanBLL taikhoanbll;
        private GiangVienBLL giangvienbll;
        DataTable danhsachtaikhoan = new DataTable();
        DataTable danhsachidgv = new DataTable();
        public fTaiKhoan()
        {
            InitializeComponent();
            taikhoanbll = new TaiKhoanBLL();
            giangvienbll = new GiangVienBLL();
        }
        void DanhSachTaiKhoan()
        {
            danhsachtaikhoan = taikhoanbll.DanhSachTaiKhoanBLL();
            dgvtaikhoan.DataSource = danhsachtaikhoan;
        }
        void DanhSachIDGV()
        {
            danhsachidgv = taikhoanbll.DanhSachIDGVBLL();
            cmbidgv.DataSource = danhsachidgv;
            cmbidgv.DisplayMember = "IDGV";
           cmbidgv.ValueMember = "IDGV";
        }     
        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            DanhSachTaiKhoan();
            cmbidqtc.SelectedIndex = 0;
            tongso.Text = "Tổng số tài khoản: " + dgvtaikhoan.RowCount;
            DanhSachIDGV();
        }    
        void Clear()
        {
            txtuser.Clear();         
            cmbidqtc.SelectedIndex = 0;
            txtpass.Clear();
            txtuser.Enabled = true;
            cmbidgv.Enabled = true;
            txtpass.Enabled = true;
            DanhSachIDGV();             
        }  
        void ThemTaiKhoan()
        {
            string user = txtuser.Text;
            string idgv = cmbidgv.Text;
            string idqtc = cmbidqtc.Text;
            string pass = txtpass.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                if (string.IsNullOrWhiteSpace(user))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(giangvienbll.KiemTraIDGV(idgv))
                {
                    if(user == idgv)
                    {
                        bool ketqua = taikhoanbll.ThemTaiKhoanBLL(user, idgv, idqtc, pass);
                        if (ketqua)
                        {
                            danhsachtaikhoan.Clear();
                            DanhSachTaiKhoan();
                            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DanhSachIDGV();
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập tên đăng nhập trùng với ID của giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                   
                }               
            }
        }
        void XoaTaiKhoan()
        {
            string user = txtuser.Text;
            if (!string.IsNullOrWhiteSpace(user))
            {
                taikhoanbll.XoaTaiKhoanBLL(user);
                danhsachtaikhoan.Clear();
                DanhSachTaiKhoan();
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachIDGV();
                Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Username để xóa tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
        void CapNhatTaiKhoan()
        {
            string user = txtuser.Text;
            string idgv = cmbidgv.Text;
            string idqtc = cmbidqtc.Text;
            string pass = txtpass.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                if (string.IsNullOrWhiteSpace(user))
                {
                    MessageBox.Show("Vui lòng nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                taikhoanbll.CapNhatTaiKhoanBLL(user, idgv, idqtc, pass);
                danhsachtaikhoan.Clear();
                DanhSachTaiKhoan();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
        

        private void dgvtaikhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null) // Chỉnh số 1 thành chỉ số của cột mật khẩu
            {
                e.Value = new string('●', e.Value.ToString().Length);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DanhSachTaiKhoan();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            InDanhSach.InExcel(dgvtaikhoan);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            CapNhatTaiKhoan();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            XoaTaiKhoan();
        }
        private void dgvtaikhoan_DataSourceChanged(object sender, EventArgs e)
        {
            tongso.Text = "Tổng số tài khoản: " + dgvtaikhoan.RowCount;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text.ToLower();
            string loc = string.Format("Username LIKE '%{0}%' OR IDGV LIKE '%{0}%' OR IDQTC LIKE '%{0}%'", timkiem);
            ((DataTable)dgvtaikhoan.DataSource).DefaultView.RowFilter = loc;
            tongso.Text = "Tổng số tài khoản: " + dgvtaikhoan.RowCount;
        }
        private void dgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow donghh = dgvtaikhoan.Rows[e.RowIndex];

                txtuser.Text = donghh.Cells["Username"].Value.ToString();
                string idgv = donghh.Cells["IDGV"].Value.ToString();
                cmbidgv.DataSource = null;
                cmbidgv.Items.Clear();
                // Đổ giá trị mới từ DataGridView vào ComboBox
                cmbidgv.Items.Add(idgv); // Hoặc sử dụng AddRange nếu cần điền nhiều giá trị
                // Chọn giá trị mới trong ComboBox
                cmbidgv.SelectedIndex = 0;
                // Chọn giá trị mới trong ComboBox
                cmbidgv.Text = idgv;
                cmbidqtc.Text = donghh.Cells["IDQTC"].Value.ToString();
                txtpass.Text = donghh.Cells["Password"].Value.ToString();
                txtuser.Enabled = false;
                cmbidgv.Enabled = false;
            }
        }
        private void cmbidgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idgv = cmbidgv.Text;
            txttengv.Text = taikhoanbll.DanhSachTenGVBLL(idgv);
        }

        private void cmbidqtc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idqtc = cmbidqtc.Text;
            txttenqtc.Text = taikhoanbll.DanhSachTenQTCBLL(idqtc);
        }
    }
}
