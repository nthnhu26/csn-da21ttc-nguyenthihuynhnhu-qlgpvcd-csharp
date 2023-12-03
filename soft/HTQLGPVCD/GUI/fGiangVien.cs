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
using DAL;

namespace GUI
{
    public partial class fGiangVien : Form
    {
        GiangVienBLL giangvienbll = new GiangVienBLL();
        DataTable danhsachgiangvien = new DataTable();
        public fGiangVien()
        {
            InitializeComponent();
        }
        public void LoadDanhSach()
        {
            danhsachgiangvien = giangvienbll.LoadDanhSachGiangVienBLL();
            dgvgiangvien.DataSource = danhsachgiangvien;

        }
        private void fGiangVien_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnclaer_Click(object sender, EventArgs e)
        {
            FormControlHelper.ClearTextComboBox(tabletextcombo);
            txtid.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddGiangVien();
        }
        public void AddGiangVien()
        {
            string id = txtid.Text;
            string hoten = txthoten.Text;
            string gioitinh = cbgioitinh.Text;
            string hocvi = cbhocvi.Text;
            string chucvu = cbchucvu.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string bomon = cbbomon.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("IDGV khong duoc bo trong");
            }
            else
            {
                bool ketqua = giangvienbll.AddGiangVienBLL(id, hoten, gioitinh, hocvi, chucvu, email, sdt, bomon);
                if (ketqua)
                {
                    danhsachgiangvien.Clear();
                    LoadDanhSach();
                    MessageBox.Show("Thêm thành công");
                    FormControlHelper.ClearTextComboBox(tabletextcombo);
                }
                else
                {
                    MessageBox.Show("IDGV đã tồn tại. Vui lòng nhập một IDGV duy nhất.");
                    // Here, you can take further UI-related actions if needed
                }
            }
        }
        private void dgvgiangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtid.Text = danhsachgiangvien.Rows[donghh]["IDGV"].ToString();
                txthoten.Text = danhsachgiangvien.Rows[donghh]["HoTen"].ToString();
                cbgioitinh.Text = danhsachgiangvien.Rows[donghh]["GioiTinh"].ToString();
                cbhocvi.Text = danhsachgiangvien.Rows[donghh]["HocVi"].ToString();
                cbchucvu.Text = danhsachgiangvien.Rows[donghh]["ChucVu"].ToString();
                txtemail.Text = danhsachgiangvien.Rows[donghh]["Email"].ToString();
                txtsdt.Text = danhsachgiangvien.Rows[donghh]["SoDienThoai"].ToString();
                cbbomon.Text = danhsachgiangvien.Rows[donghh]["BoMon"].ToString();
                txtid.Enabled = false;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string idgv = txtid.Text;
            if (idgv != null)
            {
                giangvienbll.DeleteGiangVienBLL(idgv);
                danhsachgiangvien.Clear();
                LoadDanhSach();
                MessageBox.Show("Xóa thành công giảng viên có id: " + idgv);
                FormControlHelper.ClearTextComboBox(tabletextcombo);
            }
        }
        //Cập nhật giảng viên
        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateGiangVien();
        }
        public void UpdateGiangVien()
        {
            string id = txtid.Text;
            string hoten = txthoten.Text;
            string gioitinh = cbgioitinh.Text;
            string hocvi = cbhocvi.Text;
            string chucvu = cbchucvu.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string bomon = cbbomon.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("IDGV khong duoc bo trong");
            }
            else
            {
                giangvienbll.UpdateGiangVienBLL(id, hoten, gioitinh, hocvi, chucvu, email, sdt, bomon);
                danhsachgiangvien.Clear();
                LoadDanhSach();
                MessageBox.Show("Cập nhật thành công");
                FormControlHelper.ClearTextComboBox(tabletextcombo);

            }
        }

        private void searchid_Click(object sender, EventArgs e)
        {
            string idgv = txtid.Text;
            if (!string.IsNullOrWhiteSpace(idgv))
            {
                danhsachgiangvien = giangvienbll.SearchIDGiangVienBLL(idgv);
                if (danhsachgiangvien != null)
                {
                    dgvgiangvien.DataSource = danhsachgiangvien;
                    FormControlHelper.ClearTextComboBox(tabletextcombo);
                    MessageBox.Show("Tìm thấy thông tin cho IDGV " + idgv);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cho IDGV " + idgv);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập IDGV để tìm kiếm");
            }
        }

        private void btnsearchten_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            if (!string.IsNullOrWhiteSpace(hoten))
            {
                danhsachgiangvien = giangvienbll.SearchTenGiangVienBLL(hoten);
                if (danhsachgiangvien != null)
                {
                    dgvgiangvien.DataSource = danhsachgiangvien;
                    FormControlHelper.ClearTextComboBox(tabletextcombo);
                    MessageBox.Show("Tìm thấy thông tin " + hoten);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin" + hoten);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên để tìm kiếm");
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintList.InExcel(dgvgiangvien);
        }

    }

}
