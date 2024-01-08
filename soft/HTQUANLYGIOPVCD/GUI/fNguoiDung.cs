using BLL;
using System;
using System.Collections.Generic;
using Google.Apis.Drive.v3;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Guna.UI2.WinForms;
using System.Diagnostics;


namespace GUI
{
    public partial class fNguoiDung : Form
    {
        private GoogleDrive driveService;
        private NguoiDungBLL nguoidungbll;
        private MinhChungBLL minhchungbll;
        DataTable danhsachminhchung = new DataTable();
        DataTable trangthai = new DataTable();
        private string idgv = ThongTinDangNhap.Instance.IDGV;
        public fNguoiDung()
        {
            InitializeComponent();
            InitializeDriveService();
            minhchungbll = new MinhChungBLL();
            nguoidungbll = new NguoiDungBLL();
        }
        private void InitializeDriveService()
        {
            string[] scopes = { DriveService.Scope.Drive };
            string applicationName = "HTQLGPVCD";
            driveService = new GoogleDrive(scopes, applicationName);
        }
        void DanhSachMinhChung()
        {
            danhsachminhchung = nguoidungbll.DanhSachMinhChungBLL(idgv);
            dgvminhchung.DataSource = danhsachminhchung;
        }
        void TrangThaiMinhChung()
        {
            trangthai = minhchungbll.TrangThaMinhChungBLL();
            cmbidtt.DataSource = trangthai;
            cmbidtt.DisplayMember = "TenTT";
            cmbidtt.ValueMember = "IDTT";
        } 
        private void fNguoiDung_Load(object sender, EventArgs e)
        {
            DanhSachMinhChung();
            HienThiGioConLai();
            dgvminhchung.Sort(dgvminhchung.Columns["NgayCapNhat"], System.ComponentModel.ListSortDirection.Descending);
            tongso.Text = "Tổng số minh chứng đã cập nhật là: " + dgvminhchung.RowCount;
            TrangThaiMinhChung();
        }




        void HienThiGioConLai()
        {
            if (dgvminhchung.Rows.Count > 0)
            {
                int colIndex = 5; // Chỉ số cột chứa giờ còn lại trong DatagridView
                string gioConLai = string.Empty;

                // Tìm chỉ số cột chứa giờ còn lại trong DatagridView
                for (int i = 0; i < dgvminhchung.Columns.Count; i++)
                {
                    if (dgvminhchung.Columns[i].HeaderText == "SoGioConLai") // Thay "GioConLai" bằng tên cột chứa giờ còn lại
                    {
                        colIndex = i;
                        break;
                    }
                }

                if (colIndex != -1)
                {
                    // Lấy giá trị giờ còn lại từ dòng cuối cùng của DatagridView
                    gioConLai = dgvminhchung.Rows[dgvminhchung.Rows.Count - 1].Cells[colIndex].Value.ToString();
                }

                // Hiển thị giá trị giờ còn lại lên TextBox
                btngioconlai.Text = "Số giờ còn lại cần phải thực hiện là: " + gioConLai;
            }
        }
        void XoaMinhChung()
        {
            if (dgvminhchung.SelectedRows.Count > 0)
            {
                string selectedLink = dgvminhchung.SelectedRows[0].Cells["LoaiMinhChung"].Value.ToString();
                string idmc = dgvminhchung.SelectedRows[0].Cells["IDMC"].Value.ToString();
                string idtt = dgvminhchung.SelectedRows[0].Cells["TenTT"].Value.ToString();
                string fileId = driveService.GetGoogleDriveFileId(selectedLink);

                try
                {
                    if (idtt != "Đã phê duyệt")
                    {
                        if (!string.IsNullOrEmpty(fileId))
                        {
                            bool ketqua = nguoidungbll.XoaMinhChungBLL(idmc, idgv);
                            if (ketqua)
                            {
                                MessageBox.Show("Xóa minh chứng thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                driveService.DeleteFile(fileId);
                                danhsachminhchung.Clear();
                                DanhSachMinhChung();
                            }
                            else
                            {
                                MessageBox.Show("Xóa minh chứng không thành công! IDMC không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa minh chứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            XoaMinhChung();
            DanhSachMinhChung();     
        }
        private void dgvminhchung_DataSourceChanged(object sender, EventArgs e)
        {
            tongso.Text = "Tổng số minh chứng đã cập nhật là: " + dgvminhchung.RowCount;
         
        }

        private void dgvminhchung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                string clickedUrl = dgvminhchung.Rows[e.RowIndex].Cells[7].Value.ToString();

                var linkValue = dgvminhchung.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Uri uri;
                // Kiểm tra xem liên kết có hợp lệ hay không
                if (linkValue != null && Uri.TryCreate(linkValue.ToString(), UriKind.Absolute, out uri))
                {
                    // Mở liên kết trong trình duyệt Chrome với một tab duy nhất
                    Process.Start("chrome.exe", "--new-tab \"" + uri.ToString() + "\"");
                }
                else if (!string.IsNullOrEmpty(clickedUrl))
                {
                    // Mở liên kết trong trình duyệt Chrome với một tab duy nhất
                    Process.Start("chrome.exe", "--new-tab \"" + clickedUrl + "\"");
                }
            }
        }
        void TimIDTT()
        {
            string idtt = cmbidtt.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(idtt))
            {
                danhsachminhchung = minhchungbll.TimIDTTBLL(idtt);
                if (danhsachminhchung.Rows.Count > 0)
                {
                    dgvminhchung.DataSource = danhsachminhchung;
                    MessageBox.Show("Tìm thấy thông tin cho ID: " + idtt + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvminhchung.DataSource = danhsachminhchung;
                    MessageBox.Show("Không tìm thấy thông tin cho ID: " + idtt + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập trạng thái để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            TimIDTT();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DanhSachMinhChung();
        }


    }
}
