using BLL;
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
    public partial class fAdminTaiKhoan : Form
    {
        TaiKhoanBLL taikhoanbll = new TaiKhoanBLL();
        DataTable danhsachtaikhoan = new DataTable();

        public fAdminTaiKhoan()
        {
            InitializeComponent();
        }
        public void LoadTaiKhoan()
        {
            danhsachtaikhoan = taikhoanbll.LoadDanhSachTaiKhoanBLL();
            dgvtaikhoan.DataSource = danhsachtaikhoan;
        }
        private void fAdminTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            FormControlHelper.ClearTextComboBox(tabletextcombo);
            txtuser.Enabled = true;
            txtid.Enabled = true;
            txtpass.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddTaiKhoan();
        }
        public void AddTaiKhoan()
        {
            string user = txtuser.Text;
            string idgv = txtid.Text;
            string idqtc = cbqtc.Text;
            string pass = txtpass.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(idgv) || string.IsNullOrWhiteSpace(idqtc) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Khong bo trong o nhap lieu");
            }
            else
            {
                bool ketqua = taikhoanbll.AddTaiKhoanBLL(user, idgv, idqtc, pass);
                if (ketqua)
                {
                    danhsachtaikhoan.Clear();
                    LoadTaiKhoan();
                    MessageBox.Show("Thêm thành công");
                    FormControlHelper.ClearTextComboBox(tabletextcombo);
                }
                else
                {
                    MessageBox.Show("Username đã tồn tại. Vui lòng nhập một Username duy nhất.");

                }
            }
        }

        private void dgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtuser.Text = danhsachtaikhoan.Rows[donghh]["Username"].ToString();
                txtid.Text = danhsachtaikhoan.Rows[donghh]["IDGV"].ToString();
                cbqtc.Text = danhsachtaikhoan.Rows[donghh]["IDQTC"].ToString();
                txtpass.Text = danhsachtaikhoan.Rows[donghh]["Password"].ToString();
                txtuser.Enabled = false;
                txtid.Enabled = false;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            if (user != null)
            {
                taikhoanbll.DeleteTaiKhoanBLL(user);
                danhsachtaikhoan.Clear();
                LoadTaiKhoan();
                MessageBox.Show("Xóa thành công username: " + user);
                FormControlHelper.ClearTextComboBox(tabletextcombo);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateTAiKhoan();
        }
        public void UpdateTAiKhoan()
        {
            string user = txtuser.Text;
            string idgv = txtid.Text;
            string idqtc = cbqtc.Text;
            string pass = txtpass.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(idgv) || string.IsNullOrWhiteSpace(idqtc) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Khong bo trong o nhap lieu");
            }
            else
            {
                taikhoanbll.UpdateTaiKhoanBLL(user, idgv, idqtc, pass);
                danhsachtaikhoan.Clear();
                LoadTaiKhoan();
                MessageBox.Show("Cập nhật thành công");
                FormControlHelper.ClearTextComboBox(tabletextcombo);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;

            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Vui long nhập Username");
                return;
            }

            danhsachtaikhoan = taikhoanbll.SearchUsernameTaiKhoanBLL(user);

            if (danhsachtaikhoan != null && danhsachtaikhoan.Rows.Count > 0)
            {
                dgvtaikhoan.DataSource = danhsachtaikhoan;
                FormControlHelper.ClearTextComboBox(tabletextcombo);
                MessageBox.Show("Tìm thấy thông tin cho Username " + user);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cho Username " + user);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintList.InExcel(dgvtaikhoan);
        }
    }
}
