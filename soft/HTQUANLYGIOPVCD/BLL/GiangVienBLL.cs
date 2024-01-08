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
    public class GiangVienBLL
    {
        private GiangVienDAL giangviendal;
        
        public GiangVienBLL()
        {
            giangviendal = new GiangVienDAL();
        }
        public DataTable DanhSachGiangVienBLL()
        {
            return giangviendal.DanhSachGiangVienDAL();
        }
        public bool KiemTraIDGV(string idgv)
        {
            return giangviendal.KiemTraIDGV(idgv);
        }

        public bool ThemGiangVienBLL(string idgv, string hoten, string gioitinh, string hocvi, string chucvu, string email, string sdt, string bomon, int giochuan)
        {
            GiangVienDTO giangvien = new GiangVienDTO()
            {
                IDGV = idgv,
                HoTen = hoten,
                GioiTinh = gioitinh,
                HocVi = hocvi,
                ChucVu = chucvu,
                Email = email,
                SoDienThoai = sdt,
                BoMon = bomon,
                GioChuan = giochuan
            };
            return giangviendal.ThemGiangVienDAL(giangvien);
        }
        public bool CapNhatGiangVienBLL(string idgv, string hoten, string gioitinh, string hocvi, string chucvu, string email, string sdt, string bomon, int giochuan)
        {
            GiangVienDTO giangvien = new GiangVienDTO()
            {
                IDGV = idgv,
                HoTen = hoten,
                GioiTinh = gioitinh,
                HocVi = hocvi,
                ChucVu = chucvu,
                Email = email,
                SoDienThoai = sdt,
                BoMon = bomon,
                GioChuan = giochuan
            };
            return giangviendal.CapNhatGiangVienDAL(giangvien);
        }
        public bool XoaGiangVienBLL(string idgv)
        {
            return giangviendal.XoaGiangVienDAL(idgv);
        }

        public DataTable TimIDGiangVienBLL(string idgv)
        {
            return giangviendal.TimIDGiangVienDAL(idgv);
        }

        public DataTable TimTenGiangVienBLL(string hotengv)
        {
            return giangviendal.TimTenGiangVienDAL(hotengv);
        }
    }
}
