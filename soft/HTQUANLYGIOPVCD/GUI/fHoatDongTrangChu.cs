using BLL;
using DTO;
using Google.Apis.Drive.v3;
using Guna.UI2.WinForms;
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
    public partial class fHoatDongTrangChu : Form
    {
        private HoatDongBLL hoatdongbll;
        DataTable danhsachhoatdong = new DataTable();
        private GoogleDrive driveService;
        private NguoiDungBLL nguoidungbll;
        private MinhChungBLL minhchungbll;
        DataTable danhsachminhchung = new DataTable();
        DataTable trangthai = new DataTable();
        private string idgv = ThongTinDangNhap.Instance.IDGV;
        //Danh sách hoạt động từ cơ sở dữ liệu 
        private const int ButtonHeight = 40; // Chiều cao mong muốn của button
        private const int ButtonWidth = 80;
        public fHoatDongTrangChu()
        {
            InitializeComponent();  
            hoatdongbll = new HoatDongBLL();
            InitializeDriveService();
            minhchungbll = new MinhChungBLL();
            nguoidungbll = new NguoiDungBLL();
        }
        private void InitializeDriveService()
        {
            string[] scopes = { DriveService.Scope.Drive };
            string applicationName = "QuanLyGioPhucVuCongDong";
            driveService = new GoogleDrive(scopes, applicationName);
        }

        void DanhSachHoatDong()
        {
            danhsachhoatdong = hoatdongbll.DanhSachHoatDongBLL();
            dgvhoatdong.DataSource = danhsachhoatdong;
        }

        private void fHoatDongTrangChu_Load(object sender, EventArgs e)
        {
            DanhSachHoatDong();
            dgvhoatdong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Thiết lập DefaultCellStyle.WrapMode để cho phép các dòng tự động xuống dòng
            // dgvhoatdong.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvhoatdong.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvhoatdong.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvhoatdong.Columns["NgayBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvhoatdong.Columns["NgayKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private string ChonFileMinhChung()
        {
            string parentFolderId = "1z7qbZfY73yrnieTeq56o-EHaHr6vOM4P";
            string folderName = idgv;
            string folderId = driveService.GetOrCreateFolder(parentFolderId, folderName);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    progress.Location = new Point((this.Width - progress.Width) / 2, (this.Height - progress.Height) / 2);
                    progress.BringToFront();
                    progress.Visible = true; // Hiển thị Guna2WinProgressIndicator sau khi chọn file
                    progress.Start();
                    string fileName = openFileDialog.FileName;
                    // Thực hiện upload file
                    string uploadedFileUrl = driveService.UploadFile(fileName, folderId); // Thực hiện upload file
                    progress.Stop(); // Dừng hiệu ứng quay tròn
                    progress.Visible = false; // Ẩn Guna2WinProgressIndicator khi xử lý hoàn tất
                    progress.SendToBack();
                    return uploadedFileUrl;                  
                }
            }
            return null; // Trả về null nếu không có đường dẫn nào được tạo ra
        }
        private void dgvhoatdong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the button column is clicked
            if (dgvhoatdong.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Handle the button click
                if (e.ColumnIndex == dgvhoatdong.Columns["File"].Index)
                {
                    string uploadedFileUrl = ChonFileMinhChung(); // Lấy đường dẫn của file sau khi upload
                    if (!string.IsNullOrEmpty(uploadedFileUrl))
                    {
                        string idhd = dgvhoatdong.Rows[e.RowIndex].Cells["IDHD"].Value.ToString();
                        string idgv = ThongTinDangNhap.Instance.IDGV;
                        string loaimc = dgvhoatdong.Rows[e.RowIndex].Cells["MinhChung"].Value.ToString();
                        // Lưu đường dẫn vào cơ sở dữ liệu của bạn ở đây (sử dụng uploadedFileUrl)
                        // Ví dụ: lưu vào cơ sở dữ liệu bằng cách gọi một hàm hoặc sử dụng ORM
                        bool ketqua = nguoidungbll.LuuMinhChungBLL(idhd, idgv, uploadedFileUrl);
                        if (ketqua)
                            MessageBox.Show("Tệp tin đã được upload thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi upload tệp tin!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void dgvhoatdong_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvhoatdong.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Xóa nội dung cũ của cell
                e.PaintBackground(e.CellBounds, true);

                // Vẽ lại button với kích thước mong muốn
                var buttonBounds = new Rectangle(
                    e.CellBounds.X + (e.CellBounds.Width - ButtonWidth) / 2,
                    e.CellBounds.Y + (e.CellBounds.Height - ButtonHeight) / 2,
                    ButtonWidth,
                    ButtonHeight);

                using (var brush = new SolidBrush(Color.FromArgb(103, 179, 227))) // Màu sắc của button
                {
                    e.Graphics.FillRectangle(brush, buttonBounds);
                }

                // Vẽ nội dung hoặc hình ảnh trên button (ví dụ: dùng e.Graphics.DrawString hoặc e.Graphics.DrawImage)
                using (var font = new Font("Times New Roman", 13)) // Sử dụng font và kích thước mong muốn
                {
                    using (var textBrush = new SolidBrush(Color.Black)) // Màu của nội dung text
                    {
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center; // Căn giữa theo chiều ngang
                        stringFormat.LineAlignment = StringAlignment.Center; // Căn giữa theo chiều dọc

                        e.Graphics.DrawString("Chọn file", font, textBrush, buttonBounds, stringFormat);
                    }
                }
                e.Handled = true;
            }

        }

        private void dgvhoatdong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Xác định danh sách các cột bạn muốn căn giữa
            List<int> center = new List<int> { 1,3, 4, 5};

            if (center.Contains(e.ColumnIndex))
            {
                DataGridViewCell cell = this.dgvhoatdong.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            else if (int.TryParse(timkiem, out so))
            {
                string locso = string.Format("SoGioQuyDinh = '{0}'", so);
                ((DataTable)dgvhoatdong.DataSource).DefaultView.RowFilter = locso;
            }
            else
            {
                string loc = string.Format("IDHD LIKE '%{0}%' OR TenHD LIKE '%{0}%' OR DonViTinh LIKE '%{0}%' OR MinhChung LIKE '%{0}%'", timkiem);
                ((DataTable)dgvhoatdong.DataSource).DefaultView.RowFilter = loc;
            }
        }






























     


    }
}
