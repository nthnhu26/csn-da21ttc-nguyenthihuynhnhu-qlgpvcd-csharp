using BLL;
using DTO;
using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fMinhChung : Form
    {
        private GoogleDrive driveService;
        private MinhChungBLL minhchungbll;
        DataTable danhsachminhchung = new DataTable();
        DataTable trangthai = new DataTable();

        public fMinhChung()
        {
            InitializeComponent();
            InitializeDriveService();
            minhchungbll = new MinhChungBLL();
        }
        private void InitializeDriveService()
        {
            string[] scopes = { DriveService.Scope.Drive };
            string applicationName = "HTQLGPVCD";
            driveService = new GoogleDrive(scopes, applicationName);
        }
        void DanhSachMinhChung()
        {
            danhsachminhchung = minhchungbll.DanhSachMinhChungBLL();
            dgvminhchung.DataSource = danhsachminhchung;
        }
        
        private void btnprint_Click(object sender, EventArgs e)
        {
            InDanhSach.InExcel(dgvminhchung);
        }
        private DateTime lastClicked = DateTime.MinValue;
       
        private void dgvminhchung_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvminhchung.IsCurrentCellDirty)
            {
                dgvminhchung.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvminhchung_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvminhchung.Columns[e.ColumnIndex].Name != "PheDuyet")
            {
                e.Cancel = true; // Hủy bỏ việc sửa đổi nếu không phải là cột bạn muốn chỉnh sửa
            }
        }
        private void dgvminhchung_DataSourceChanged(object sender, EventArgs e)
        {
            tongso.Text = "Tổng số minh chứng được cập nhật là: " + dgvminhchung.RowCount;
        }

        private void fMinhChung_Load(object sender, EventArgs e)
        {
            DanhSachMinhChung();
            tongso.Text = "Tổng số minh chứng được cập nhật là: " + dgvminhchung.RowCount;
            dgvminhchung.Columns["NgayCapNhat"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

       
        private DataTable FindIDs(string searchText)
        {
            DataTable resultTable = new DataTable();
            foreach (DataGridViewColumn column in dgvminhchung.Columns)
            {
                if (column.Name != "PheDuyet")
                {
                    resultTable.Columns.Add(column.Name);
                }
            }

            foreach (DataGridViewRow row in dgvminhchung.Rows)
            {
                bool found = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString();
                        if (cellValue.Contains(searchText))
                        {
                            found = true;
                            break;
                        }
                    }
                }

                if (found)
                {
                    DataRow newRow = resultTable.Rows.Add();
                    int columnIndex = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Bỏ qua cột "PheDuyet" và chỉ thêm giá trị vào các cột còn lại
                        if (dgvminhchung.Columns[cell.ColumnIndex].Name != "PheDuyet")
                        {
                            newRow[columnIndex] = cell.Value;
                            columnIndex++;
                        }
                    }
                }
            }

            return resultTable;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string chuoitimkiem = txttimkiem.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ các khoảng trắng ở đầu cuối chuỗi
            danhsachminhchung = FindIDs(chuoitimkiem);
            if (danhsachminhchung.Rows.Count > 0)
            {
                dgvminhchung.DataSource = danhsachminhchung;
                MessageBox.Show("Tìm thấy thông tin cho: " + chuoitimkiem + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvminhchung.DataSource = danhsachminhchung;
                MessageBox.Show("Không tìm thấy thông tin cho: " + chuoitimkiem + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }       
        }

        private void dgvminhchung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvminhchung.Columns[e.ColumnIndex].Name == "PheDuyet")
                {
                    string idtt = dgvminhchung.Rows[e.RowIndex].Cells["PheDuyet"].Value.ToString();
                    string check = dgvminhchung.Rows[e.RowIndex].Cells["PheDuyet"].Value.ToString();

                    if (check == "dpd")
                    {
                        //   dgvminhchung.Rows[e.RowIndex].Cells["colum"].Value = "dpd";
                        idtt = "dpd";
                        string idmc = danhsachminhchung.Rows[e.RowIndex]["IDMC"].ToString();
                        string idhd = danhsachminhchung.Rows[e.RowIndex]["IDHD"].ToString();
                        string idgv = danhsachminhchung.Rows[e.RowIndex]["IDGV"].ToString();
                        bool ketqua = minhchungbll.CapNhatTTMinhChungBLL(idmc, idhd, idgv, idtt);
                        if (ketqua)
                        {
                            //   danhsachminhchung.Clear();
                            //    DanhSachMinhChung();
                            //     MessageBox.Show("Cập nhật trạng thái minh chứng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
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
        void XoaMinhChung(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    string selectedLink = row.Cells["LoaiMinhChung"].Value.ToString();
                    string fileId = driveService.GetGoogleDriveFileId(selectedLink);
                    string idmc = row.Cells["IDMC"].Value.ToString();
                    bool ketqua = minhchungbll.XoaMinhChungBLL(idmc);
                    if (ketqua)
                    {
                       DialogResult rs = MessageBox.Show("Bạn có thật sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       if (rs != DialogResult.Yes)
                       {
                           return;
                       }
                       dgv.Rows.RemoveAt(row.Index);
                       driveService.DeleteFile(fileId);
                    }
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            XoaMinhChung(dgvminhchung);
            DanhSachMinhChung();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text.ToLower();
            int sogio;
            DateTime ngay;
            if (DateTime.TryParse(timkiem, out ngay))
            {
                string locngay = string.Format("NgayCapNhat = #{0:d/M/yyyy}#", ngay);
                ((DataTable)dgvminhchung.DataSource).DefaultView.RowFilter = locngay;
            }
            else if (int.TryParse(timkiem, out sogio))
            {
                string locso = string.Format("IDMC = '{0}' OR SoGioDaHoanThanh = '{0}' OR SoGioConLai = '{0}'", sogio);
                ((DataTable)dgvminhchung.DataSource).DefaultView.RowFilter = locso;
            }
            else
            {
                string loc = string.Format("IDHD LIKE '%{0}%' OR IDGV LIKE '%{0}%' OR TenTT LIKE '%{0}%'", timkiem);
                ((DataTable)dgvminhchung.DataSource).DefaultView.RowFilter = loc;
            }
        }

        private void dgvminhchung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Xác định danh sách các cột bạn muốn căn giữa
            List<int> center = new List<int> { 0,1, 2, 4, 6, 7,9 };

            if (center.Contains(e.ColumnIndex))
            {
                DataGridViewCell cell = this.dgvminhchung.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DanhSachMinhChung();
        }



       







    }
}
