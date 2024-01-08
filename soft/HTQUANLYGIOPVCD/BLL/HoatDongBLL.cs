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
    public class HoatDongBLL
    {
        private HoatDongDAL hoatdongdal;
        public HoatDongBLL()
        {
            hoatdongdal = new HoatDongDAL();
        }
        public DataTable DanhSachHoatDongBLL()
        {
            return hoatdongdal.DanhSachHoatDongDAL();
        }

        public bool ThemHoatDongBLL(string idhd, string tenhd, int sogioquydinh, DateTime ngaybatdau, DateTime ngayketthuc, string donvitinh, string minhchung)
        {
            HoatDongDTO hoatdong = new HoatDongDTO()
            {
                IDHD = idhd,
                TenHD = tenhd,
                SoGioQuyDinh = sogioquydinh,
                NgayBatDau = ngaybatdau,
                NgayKetThuc = ngayketthuc,
                DonViTinh = donvitinh,
                MinhChung = minhchung

            };
            return hoatdongdal.ThemHoatDongDAL(hoatdong);
        }
        public bool CapNhatHoatDongBLL(string idhd, string tenhd, int sogioquydinh, DateTime ngaybatdau, DateTime ngayketthuc, string donvitinh, string minhchung)
        {
            HoatDongDTO hoatdong = new HoatDongDTO()
            {
                IDHD = idhd,
                TenHD = tenhd,
                SoGioQuyDinh = sogioquydinh,
                NgayBatDau = ngaybatdau,
                NgayKetThuc = ngayketthuc,
                DonViTinh = donvitinh,
                MinhChung = minhchung
            };
            return hoatdongdal.CapNhatHoatDongDAL(hoatdong);
        }
        public bool XoaHoatDongBLL(string idhd)
        {
            return hoatdongdal.XoaHoatDongDAL(idhd);
        }

        public DataTable TimIDHoatDongBLL(string idhd)
        {
            return hoatdongdal.TimIDHoatDongDAL(idhd);
        }

        public DataTable TimTenHoatDongBLL(string tenhd)
        {
            return hoatdongdal.TimTenHoatDongDAL(tenhd);
        }











    }
}
