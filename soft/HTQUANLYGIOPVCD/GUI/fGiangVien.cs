using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fGiangVien : Form
    {
        private GiangVienBLL giangvienbll;
        DataTable danhsachgiangvien = new DataTable();
        string idadmin = ThongTinDangNhap.Instance.IDGV;
        public fGiangVien()
        {
            InitializeComponent();
            giangvienbll = new GiangVienBLL();
        }
        void DanhSachGiangVien()
        {
            danhsachgiangvien = giangvienbll.DanhSachGiangVienBLL();
            dgvgiangvien.DataSource = danhsachgiangvien;
            
        }
        private void fGiangVien_Load(object sender, EventArgs e)
        {
            cmbgioitinh.SelectedIndex = 0;
            cmbhocvi.SelectedIndex = 0;
            cmbhocvi.SelectedIndex = 0;
            cmbbomon.SelectedIndex = 0;
            DanhSachGiangVien();
            tongso.Text = "Tổng số giảng viên: " + dgvgiangvien.RowCount;
        }
        //Hàm kiểm dữ liệu được nhập vào có đúng không
        // Phương thức kiểm tra IDGV
        private bool KiemTraIDGV(string idgv)
        {
            return idgv.Length > 2 && idgv.Length <= 10;
        }

        // Phương thức kiểm tra Email
        private bool KiemTraEmail(string email)
        {
            Regex regexEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regexEmail.IsMatch(email);
        }

        // Phương thức kiểm tra Số điện thoại
        private bool KiemTraSoDienThoai(string sdt)
        {
            Regex regexPhone = new Regex(@"^0\d{9}$");
            return regexPhone.IsMatch(sdt);
        }

        void ThemGiangVien()
        {
            string idgv = txtidgv.Text;
            string hoten = txthotengv.Text;
            string gioitinh = cmbgioitinh.Text;
            string hocvi = cmbhocvi.Text;
            string chucvu = cmbchucvu.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string bomon = cmbbomon.Text;
            int giochuan = (int)nupgiochuan.Value;
            if (string.IsNullOrEmpty(idgv) || string.IsNullOrEmpty(hoten))
            {
                if (string.IsNullOrEmpty(idgv))
                {
                    MessageBox.Show("IDGV không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tên giảng viên không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!KiemTraIDGV(idgv))
                {
                    MessageBox.Show("IDGV phải có độ dài từ 3 đến 10 kí tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!string.IsNullOrEmpty(email) && !KiemTraEmail(email))
                {
                    MessageBox.Show("Email không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(sdt) && !KiemTraSoDienThoai(sdt))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool ketqua = giangvienbll.ThemGiangVienBLL(idgv, hoten, gioitinh, hocvi, chucvu, email, sdt, bomon, giochuan);
                if (ketqua)
                {
                    danhsachgiangvien.Clear();
                    DanhSachGiangVien();
                    MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên không thành công! IDGV đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // Sự kiện CellClick của datagridview
        void CapNhatGiangVien()
        {
            string idgv = txtidgv.Text;
            string hoten = txthotengv.Text;
            string gioitinh = cmbgioitinh.Text;
            string hocvi = cmbhocvi.Text;
            string chucvu = cmbchucvu.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string bomon = cmbbomon.Text;
            int giochuan = (int)nupgiochuan.Value;
            if (string.IsNullOrEmpty(idgv))
            {
                MessageBox.Show("IDGV không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!string.IsNullOrEmpty(email) && !KiemTraEmail(email))
                {
                    MessageBox.Show("Email không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(sdt) && !KiemTraSoDienThoai(sdt))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool ketqua = giangvienbll.CapNhatGiangVienBLL(idgv, hoten, gioitinh, hocvi, chucvu, email, sdt, bomon, giochuan);
                if (ketqua)
                {
                    danhsachgiangvien.Clear();
                    DanhSachGiangVien();
                    MessageBox.Show("Cập nhật giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật giảng viên không thành công! IDGV không đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void XoaGiangVien()
        {
            string idgv = txtidgv.Text;
            if (idgv != null)
            {
                if(idgv == idadmin)
                {
                    MessageBox.Show("Không thể xóa tài khoản admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool ketqua = giangvienbll.XoaGiangVienBLL(idgv);
                    if (ketqua)
                    {
                        danhsachgiangvien.Clear();
                        DanhSachGiangVien();
                        MessageBox.Show("Xóa giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa giảng viên không thành công! IDGV không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID giảng viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Hàm cho button làm mới, xóa các dữ liệu trong textbox và cập nhật lại giá trị ban đầu cho numberupdown và datetime
        void Clear()
        {
            txtidgv.Clear();
            txthotengv.Clear();
            cmbgioitinh.SelectedIndex = 0;
            cmbhocvi.SelectedIndex = 0;
            cmbhocvi.SelectedIndex = 0;
            txtemail.Clear();
            txtemail.Clear();
            cmbbomon.SelectedIndex = 0;
            txtidgv.Enabled = true;
        }

   

        private void btnload_Click(object sender, EventArgs e)
        {
            DanhSachGiangVien();
        }

     
        void TimIDGiangVien()
        {
            string idgv = txtidgv.Text;
            if (!string.IsNullOrEmpty(idgv))
            {
                danhsachgiangvien = giangvienbll.TimIDGiangVienBLL(idgv);
                if (danhsachgiangvien.Rows.Count > 0)
                {
                    dgvgiangvien.DataSource = danhsachgiangvien;
                    Clear();
                    MessageBox.Show("Tìm thấy thông tin cho ID: " + idgv + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvgiangvien.DataSource = danhsachgiangvien;
                    MessageBox.Show("Không tìm thấy thông tin cho ID: " + idgv + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void TimTenGiangVien()
        {
            string tenhd = txthotengv.Text;
            if (!string.IsNullOrEmpty(tenhd))
            {
                danhsachgiangvien = giangvienbll.TimTenGiangVienBLL(tenhd);
                if (danhsachgiangvien.Rows.Count > 0)
                {
                    dgvgiangvien.DataSource = danhsachgiangvien;
                    Clear();
                    MessageBox.Show("Tìm thấy thông tin cho hoạt động: " + tenhd + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvgiangvien.DataSource = danhsachgiangvien;
                    MessageBox.Show("Không tìm thấy thông tin cho hoạt động: " + tenhd + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnload_Click_1(object sender, EventArgs e)
        {
            DanhSachGiangVien();
        }

        private void btnsearchid_Click(object sender, EventArgs e)
        {
            TimIDGiangVien();
        }

        private void btnsearchten_Click(object sender, EventArgs e)
        {
            TimTenGiangVien();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ThemGiangVien();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            XoaGiangVien();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            CapNhatGiangVien();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            InDanhSach.InExcel(dgvgiangvien);
        }

        private void dgvgiangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow donghh = dgvgiangvien.Rows[e.RowIndex];
                txtidgv.Text = donghh.Cells[0].Value.ToString();
                txthotengv.Text = donghh.Cells[1].Value.ToString();
                cmbgioitinh.Text = donghh.Cells[2].Value.ToString();
                cmbhocvi.Text = donghh.Cells[3].Value.ToString();
                cmbchucvu.Text = donghh.Cells[4].Value.ToString();
                txtemail.Text = donghh.Cells[5].Value.ToString();
                txtsdt.Text = donghh.Cells[6].Value.ToString();
                cmbbomon.Text = donghh.Cells[7].Value.ToString();
                int numericValue;
                if (int.TryParse(donghh.Cells[8].Value.ToString(), out numericValue))
                {
                    nupgiochuan.Value = numericValue;
                }
                txtidgv.Enabled = false;
            }
        }

        private void dgvgiangvien_DataSourceChanged(object sender, EventArgs e)
        {
            tongso.Text = "Số lượng giảng viên: " + dgvgiangvien.RowCount.ToString();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text.ToLower(); // Chuyển đổi về chữ thường để tìm kiếm không phân biệt chữ hoa, chữ thường
            int giochuan;
            if (int.TryParse(timkiem, out giochuan))
            {
                string locso = string.Format("GioChuan = '{0}'", giochuan);
                ((DataTable)dgvgiangvien.DataSource).DefaultView.RowFilter = locso;
            }
            else
            {
                string loc = string.Format("IDGV LIKE '%{0}%' OR HoTen LIKE '%{0}%' OR GioiTinh LIKE '%{0}%' OR HocVi LIKE '{0}%' OR ChucVu LIKE '%{0}%'" +
                " OR BoMon LIKE '%{0}%' OR SoDienThoai LIKE '%{0}%' OR Email LIKE '%{0}%'", timkiem);
                // Áp dụng bộ lọc
                ((DataTable)dgvgiangvien.DataSource).DefaultView.RowFilter = loc;
            }
        }

       

       








    }
}
