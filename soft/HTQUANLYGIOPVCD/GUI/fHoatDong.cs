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
namespace GUI
{
    public partial class fHoatDong : Form
    {
        private HoatDongBLL hoatdongbll;
        DataTable danhsachhoatdong = new DataTable();
        public fHoatDong()
        {
            InitializeComponent();
            hoatdongbll = new HoatDongBLL();
        }
        //Danh sách hoạt động từ cơ sở dữ liệu 
        void DanhSachHoatDong()
        {
            danhsachhoatdong = hoatdongbll.DanhSachHoatDongBLL();
            dgvhoatdong.DataSource = danhsachhoatdong;
        }
        private void fHoatDong_Load(object sender, EventArgs e)
        {
            cmbdonvitinh.SelectedIndex = 0;
            DanhSachHoatDong();
            dgvhoatdong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Thiết lập DefaultCellStyle.WrapMode để cho phép các dòng tự động xuống dòng
            // dgvhoatdong.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvhoatdong.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvhoatdong.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvhoatdong.Columns["NgayBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvhoatdong.Columns["NgayKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy";
            tongso.Text = "Tổng số hoạt động: " + dgvhoatdong.RowCount;
        }
        //Thêm hoạt động

        void ThemHoatDong()
        {
            string idhd = txtidhd.Text;
            string tenhd = txttenhd.Text;
            int sogioquydinh = (int)nupsogio.Value;
            DateTime ngaybatdau;
            DateTime ngayketthuc;
            string donvitinh = cmbdonvitinh.Text;
            string minhchung = txtminhchung.Text;
            if (string.IsNullOrEmpty(idhd))
            {
                MessageBox.Show("IDHD không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DateTime.TryParse(dtpbatdau.Text, out ngaybatdau) && DateTime.TryParse(dtpketthuc.Text, out ngayketthuc))
                {
                    bool ketqua = hoatdongbll.ThemHoatDongBLL(idhd, tenhd, sogioquydinh, ngaybatdau, ngayketthuc, donvitinh, minhchung);
                    if (ketqua)
                    {
                        danhsachhoatdong.Clear();
                        DanhSachHoatDong();
                        MessageBox.Show("Thêm hoạt động thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm hoạt động không thành công! IDHD đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày bắt đầu/kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Sự kiện CellClick của datagridview
 
        //Cập nhật hoạt động

        void CapNhatHoatDong()
        {
            string idhd = txtidhd.Text;
            string tenhd = txttenhd.Text;
            int sogioquydinh = (int)nupsogio.Value;
            DateTime ngaybatdau;
            DateTime ngayketthuc;
            string donvitinh = cmbdonvitinh.Text;
            string minhchung = txtminhchung.Text;
            if (string.IsNullOrEmpty(idhd))
            {
                MessageBox.Show("IDHD không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DateTime.TryParse(dtpbatdau.Text, out ngaybatdau) && DateTime.TryParse(dtpketthuc.Text, out ngayketthuc))
                {
                    bool ketqua = hoatdongbll.CapNhatHoatDongBLL(idhd, tenhd, sogioquydinh, ngaybatdau, ngayketthuc, donvitinh, minhchung);
                    if (ketqua)
                    {
                        danhsachhoatdong.Clear();
                        DanhSachHoatDong();
                        MessageBox.Show("Cập nhật hoạt động thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật hoạt động không thành công! IDHD không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng ngày bắt đầu/kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //Xóa hoạt động
 
        void XoaHoatDong()
        {
            string idhd = txtidhd.Text;
            if (string.IsNullOrEmpty(idhd))
            {

                MessageBox.Show("Vui lòng nhập ID hoạt động để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult drs;
                drs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.Yes)
                {
                    bool ketqua = hoatdongbll.XoaHoatDongBLL(idhd);
                    if (ketqua)
                    {
                        danhsachhoatdong.Clear();
                        DanhSachHoatDong();
                        MessageBox.Show("Xóa hoạt động thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hoạt động không thành công! IDHD không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
        }
        //In danh sách Excel từ dữ liệu trong datagridview

       
        //Hàm cho button làm mới, xóa các dữ liệu trong textbox và cập nhật lại giá trị ban đầu cho numberupdown và datetime
        void Clear()
        {
            txtidhd.Clear();
            txttenhd.Clear();
            nupsogio.Value = 0;
            dtpbatdau.Value = DateTime.Now;
            dtpketthuc.Value = DateTime.Now;
            cmbdonvitinh.SelectedIndex = 0;
            txtminhchung.Clear();
            txtidhd.Enabled = true;
        }

        //Tải lại Danh sách hoạt động

        //Tìm hoạt động theo ID

        void TimIDHoatDong()
        {
            string idhd = txtidhd.Text;
            if (!string.IsNullOrEmpty(idhd))
            {
                danhsachhoatdong = hoatdongbll.TimIDHoatDongBLL(idhd);
                if (danhsachhoatdong.Rows.Count>0)
                {
                    dgvhoatdong.DataSource = danhsachhoatdong;
                    Clear();
                    MessageBox.Show("Tìm thấy thông tin cho ID: " + idhd + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvhoatdong.DataSource = danhsachhoatdong;
                    MessageBox.Show("Không tìm thấy thông tin cho ID: " + idhd + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tìm hoạt động theo tên

        void TimTenHoatDong()
        {
            string tenhd = txttenhd.Text;
            if (!string.IsNullOrEmpty(tenhd))
            {
                danhsachhoatdong = hoatdongbll.TimTenHoatDongBLL(tenhd);
                if (danhsachhoatdong.Rows.Count > 0)
                {
                    dgvhoatdong.DataSource = danhsachhoatdong;
                    Clear();
                    MessageBox.Show("Tìm thấy thông tin cho hoạt động: " + tenhd + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvhoatdong.DataSource = danhsachhoatdong;
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

        private void btnload_Click(object sender, EventArgs e)
        {
            DanhSachHoatDong();
        }

        private void btnsearchid_Click(object sender, EventArgs e)
        {
            TimIDHoatDong();
        }

        private void btnsearchten_Click(object sender, EventArgs e)
        {
            TimTenHoatDong();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ThemHoatDong();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            XoaHoatDong();
            
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            CapNhatHoatDong();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            InDanhSach.InExcel(dgvhoatdong);
        }

      

        private void dgvhoatdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow donghh = dgvhoatdong.Rows[e.RowIndex];
                txtidhd.Text = donghh.Cells[0].Value.ToString();
                txttenhd.Text = donghh.Cells[1].Value.ToString();
                int number;
                if (int.TryParse(donghh.Cells[2].Value.ToString(), out number))
                {
                    nupsogio.Value = number;
                }
                DateTime ngaybatdau;
                if (DateTime.TryParse(donghh.Cells["NgayBatDau"].Value.ToString(), out ngaybatdau))
                {
                    dtpbatdau.Value = ngaybatdau;
                }
                DateTime ngayketthuc;
                if (DateTime.TryParse(donghh.Cells["NgayKetThuc"].Value.ToString(), out ngayketthuc))
                {
                    dtpketthuc.Value = ngayketthuc;
                }
                cmbdonvitinh.Text = donghh.Cells["DonViTinh"].Value.ToString();
                txtminhchung.Text = donghh.Cells[6].Value.ToString();
                txtidhd.Enabled = false;


            }

        }

   

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text.ToLower();
            int so;
            DateTime ngay;           
            if (DateTime.TryParse(timkiem, out ngay))
            {
                string locngay = string.Format("NgayBatDau = #{0:d/M/yyyy}# OR NgayKetThuc = #{1:d/M/yyyy}#", ngay, ngay);           
                ((DataTable)dgvhoatdong.DataSource).DefaultView.RowFilter = locngay;
            }
            else if(int.TryParse(timkiem, out so))
            {
                string locso = string.Format("SoGioQuyDinh = '{0}'", so);
                ((DataTable)dgvhoatdong.DataSource).DefaultView.RowFilter = locso;
            }
            else
            {
                string loc = string.Format("IDHD LIKE '%{0}%' OR TenHD LIKE '%{0}%' OR DonViTinh LIKE '%{0}%' OR MinhChung LIKE '%{0}%'", timkiem);
                ((DataTable)dgvhoatdong.DataSource).DefaultView.RowFilter = loc;
            }
            tongso.Text = "Tổng số hoạt động: " + dgvhoatdong.RowCount;
        }

        private void dgvhoatdong_DataSourceChanged(object sender, EventArgs e)
        {
            tongso.Text = "Tổng số hoạt động: " + dgvhoatdong.RowCount;
        }
    }
}