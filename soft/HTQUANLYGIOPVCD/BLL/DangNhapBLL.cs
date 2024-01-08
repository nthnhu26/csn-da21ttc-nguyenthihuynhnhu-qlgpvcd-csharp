using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DangNhapBLL
    {
        private DangNhapDAL dangnhapdal;
        public DangNhapBLL()
        {
            dangnhapdal = new DangNhapDAL();
        }
        public TaiKhoanDTO KiemTraDangNhapBLL(string username, string password)
        {
            return dangnhapdal.KiemTraDangNhapDAL(username, password);
        }




    }
}
