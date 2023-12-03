using BLL;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
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
    public partial class fHoatDong : Form
    {
        private HoatDongBLL hoatdongbll = new HoatDongBLL();
        DataTable danhsachhoatdong = new DataTable();
        public fHoatDong()
        {
            InitializeComponent();
        }
        void LoadDanhSach()
        {
            danhsachhoatdong = hoatdongbll.LoadDanhSachHoatDongBLL();
            dgvhoatdong.DataSource = danhsachhoatdong;
        }
        private void fHoatDong_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            FormControlHelper.ClearTextComboBox(tabletextcombotime);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddHoatDong();
        }
        void AddHoatDong()
        {
            string idhd = txtid.Text;
            string tenhd = txtten.Text;
            int sogioquydinh;
            DateTime ngaybatdau;
            DateTime ngayketthuc;
            string donvitinh = cbdonvitinh.Text;
            if (string.IsNullOrEmpty(idhd))
            {
                MessageBox.Show("IDHD không được bỏ trống");
            }
            else
            {
                if (int.TryParse(txtsogio.Text, out sogioquydinh) &&
                    DateTime.TryParse(dtpbatdau.Text, out ngaybatdau) &&
                    DateTime.TryParse(dtpketthuc.Text, out ngayketthuc))
                {
                    bool ketqua = hoatdongbll.AddHoatDongBLL(idhd, tenhd, sogioquydinh, ngaybatdau, ngayketthuc, donvitinh);
                    if (ketqua)
                    {
                        danhsachhoatdong.Clear();
                        LoadDanhSach();
                        MessageBox.Show("Thêm hoạt động thành công!");
                        FormControlHelper.ClearTextComboBox(tabletextcombotime);
                    }
                    else
                    {
                        MessageBox.Show("Thêm hoạt động không thành công! IDHD đã tồn tại.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số giờ và ngày bắt đầu/kết thúc!");
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string idhd = txtid.Text;
            if (idhd!=null)
            {
                hoatdongbll.DeleteHoatDongBLL(idhd);
                danhsachhoatdong.Clear();
                LoadDanhSach();
                MessageBox.Show("Xoa thanh cong");
                FormControlHelper.ClearTextComboBox(tabletextcombotime);
            }
            else
            {
                MessageBox.Show("Vui long nhap id");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateHoatDong();
        }
        public void UpdateHoatDong()
        {
            string idhd = txtid.Text;
            string tenhd = txtten.Text;
            int sogioquydinh;
            DateTime ngaybatdau;
            DateTime ngayketthuc;
            string donvitinh = cbdonvitinh.Text;
            if (string.IsNullOrEmpty(idhd))
            {
                MessageBox.Show("IDHD không được bỏ trống");
            }
            else
            {
                if (int.TryParse(txtsogio.Text, out sogioquydinh) &&
                    DateTime.TryParse(dtpbatdau.Text, out ngaybatdau) &&
                    DateTime.TryParse(dtpketthuc.Text, out ngayketthuc))
                {
                    hoatdongbll.UpdateHoatDongBLL(idhd, tenhd, sogioquydinh, ngaybatdau, ngayketthuc, donvitinh);
                    danhsachhoatdong.Clear();
                    LoadDanhSach();
                    MessageBox.Show("Cập nhật hoạt động thành công!");
                    FormControlHelper.ClearTextComboBox(tabletextcombotime);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số giờ và ngày bắt đầu/kết thúc!");
                }
            }
        }

        private void btnsearchid_Click(object sender, EventArgs e)
        {
            string idhd = txtid.Text;
            if (!string.IsNullOrEmpty(idhd))
            {
                danhsachhoatdong = hoatdongbll.SearchIDHoatDongBLL(idhd);
                if (danhsachhoatdong != null)
                {
                    dgvhoatdong.DataSource = danhsachhoatdong;
                    FormControlHelper.ClearTextComboBox(tabletextcombotime);
                    MessageBox.Show("Tim thay thong tin");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cho IDHD " + idhd);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập IDHD để tìm kiếm");
            }
        }

        private void btnsearchten_Click(object sender, EventArgs e)
        {
            string tenhd = txtten.Text;
            if (!string.IsNullOrEmpty(tenhd))
            {
                danhsachhoatdong = hoatdongbll.SearchTenHoatDongBLL(tenhd);
                if (danhsachhoatdong != null)
                {
                    dgvhoatdong.DataSource = danhsachhoatdong;
                    FormControlHelper.ClearTextComboBox(tabletextcombotime);
                    MessageBox.Show("Tim thay thong tin");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin" + tenhd);
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
            PrintList.InExcel(dgvhoatdong);
        }

        private void dgvhoatdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int donghh = e.RowIndex;
            if(donghh>=0)
            {
                txtid.Text = danhsachhoatdong.Rows[donghh]["IDHD"].ToString();
                txtten.Text = danhsachhoatdong.Rows[donghh]["TenHD"].ToString();
                txtsogio.Text = danhsachhoatdong.Rows[donghh]["SoGioQuyDinh"].ToString();
                // Chuyển đổi chuỗi ngày tháng thành kiểu DateTime
                if (DateTime.TryParse(danhsachhoatdong.Rows[donghh]["NgayBatDau"].ToString(), out DateTime ngaybatdau))
                {
                    dtpbatdau.Value = ngaybatdau;
                }

                if (DateTime.TryParse(danhsachhoatdong.Rows[donghh]["NgayKetThuc"].ToString(), out DateTime ngayketthuc))
                {
                    dtpketthuc.Value = ngayketthuc;
                }

                cbdonvitinh.Text = danhsachhoatdong.Rows[donghh]["DonViTinh"].ToString();
                txtid.Enabled = false;
            }
        }
    }
}
