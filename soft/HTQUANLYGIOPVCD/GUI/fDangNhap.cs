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
    public partial class fDangNhap : Form
    {
        private DangNhapBLL dangnhapbll;
        public fDangNhap()
        {
            InitializeComponent();
            dangnhapbll = new DangNhapBLL();
        }

      

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            txtuser.Text = Properties.Settings.Default.Username;
            txtpass.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Username != "")
            {
                check.Checked = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                if (string.IsNullOrWhiteSpace(user))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu để đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                TaiKhoanDTO taikhoankdto = dangnhapbll.KiemTraDangNhapBLL(user, pass);
                if (taikhoankdto != null)
                {
                    // Lưu thông tin người dùng đăng nhập
                    ThongTinDangNhap.Instance.Username = taikhoankdto.Username;
                    ThongTinDangNhap.Instance.IDGV = taikhoankdto.IDGV;
                    ThongTinDangNhap.Instance.IDQTC = taikhoankdto.IDQTC;

                  //  MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fTrangChu trangchu = new fTrangChu();
                    trangchu.Show();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Đăng nhập thất bại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (txtuser.Text != "" && txtpass.Text != "")
            {
                if (check.Checked == true)
                {
                    string users = txtuser.Text;
                    string pass = txtpass.Text;
                    Properties.Settings.Default.Username = users;
                    Properties.Settings.Default.Password = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }




    }
}
