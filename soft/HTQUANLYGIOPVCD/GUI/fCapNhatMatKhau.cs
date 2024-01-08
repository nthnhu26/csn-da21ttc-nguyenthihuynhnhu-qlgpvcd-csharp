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
    public partial class fCapNhatMatKhau : Form
    {
        private CapNhatMatKhauBLL capnhatmatkhaubll;
        public fCapNhatMatKhau()
        {
            InitializeComponent();
            capnhatmatkhaubll = new CapNhatMatKhauBLL();
        }
        void Clear()
        {
            txtpassold.Clear();
            txtpassnew1.Clear();
            txtpassnew2.Clear();
        }
        //Hàm kiểm tra mật khẩu thay đổi
        private bool KiemTraMatKhau(string password)
        {
            // Biểu thức chính quy: Ít nhất một ký tự đặc biệt, một ký tự hoa, từ 8 đến 20 ký tự
            Regex regex = new Regex(@"^(?=.*[^\w\s])(?=.*[A-Z]).{8,20}$");
            return regex.IsMatch(password);
        }
        void CapNhapMatKhau()
        {
            string user = txtuser.Text;
            string passold = txtpassold.Text;
            string passnew1 = txtpassnew1.Text;
            string passnew2 = txtpassnew2.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(passold) || string.IsNullOrWhiteSpace(passnew1) || string.IsNullOrWhiteSpace(passnew2))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (passnew1 == passnew2)
                {
                    if (KiemTraMatKhau(passnew1))
                    {
                        bool ketqua = capnhatmatkhaubll.ThayDoiMatKhauBLL(user, passold, passnew1);
                        if (ketqua)
                        {
                            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không đáp ứng yêu cầu: ít nhất một ký tự đặc biệt, một ký tự hoa và từ 8 đến 20 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassnew1.Clear();
                        txtpassnew2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassnew2.Clear();
                }
            }
        }
        private void fCapNhatMatKhau_Load(object sender, EventArgs e)
        {
            txtuser.Text = ThongTinDangNhap.Instance.IDGV;
            //txtuser.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            CapNhapMatKhau();
        }

       
    }
}
