using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongTinDangNhapBLL
    {
        private ThongTinDangNhapDAL thongtindangnhapdal;
        public ThongTinDangNhapBLL()
        {
            thongtindangnhapdal = new ThongTinDangNhapDAL();
        }
        public string TenGiangVienBLL(string idgv)
        {
            return thongtindangnhapdal.TenGiangVienDAL(idgv);
        }
    }
}
