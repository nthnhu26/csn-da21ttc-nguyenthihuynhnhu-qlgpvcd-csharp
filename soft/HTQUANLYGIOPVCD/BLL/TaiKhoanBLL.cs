using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL taikhoandal;
        public TaiKhoanBLL()
        {
            taikhoandal = new TaiKhoanDAL();
        }
        public DataTable DanhSachTaiKhoanBLL()
        {
            return taikhoandal.DanhSachTaiKhoanDAL();
        }
        public DataTable DanhSachIDGVBLL()
        {
            return taikhoandal.DanhSachIDGVDAL();
        }
        public string DanhSachTenGVBLL(string idgv)
        {
            return taikhoandal.DanhSachTenGVDAL(idgv);
        }
        public string DanhSachTenQTCBLL(string idqtc)
        {
            return taikhoandal.DanhSachTenQTCDAL(idqtc);
        }


        public bool ThemTaiKhoanBLL(string username, string idgv, string idqtc, string password)
        {
            TaiKhoanDTO taikhoan = new TaiKhoanDTO()
            {
                Username = username,
                IDGV = idgv,
                IDQTC = idqtc,
                Password = password
            };
            taikhoan.Password = MaHoaMatKhau.HashPassword(password);
            return taikhoandal.ThemTaiKhoanDAL(taikhoan);
        }
        public bool XoaTaiKhoanBLL(string username)
        {
            return taikhoandal.XoaTaiKhoanDAL(username);
        }

        public bool CapNhatTaiKhoanBLL(string username, string idgv, string idqtc, string password)
        {
            TaiKhoanDTO taikhoan = new TaiKhoanDTO()
            {
                Username = username,
                IDGV = idgv,
                IDQTC = idqtc,
                Password = password
            };
            taikhoan.Password = MaHoaMatKhau.HashPassword(password);
            return taikhoandal.CapNhatTaiKhoanDAL(taikhoan);
        }
        public DataTable TimUsernameTaiKhoanBLL(string username)
        {
            return taikhoandal.TimUsernameTaiKhoanDAL(username);
        }





    }
}
