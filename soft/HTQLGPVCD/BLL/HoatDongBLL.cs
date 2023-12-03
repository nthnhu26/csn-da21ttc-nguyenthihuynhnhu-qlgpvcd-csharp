using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoatDongBLL
    {
        private HoatDongDAL hoatdongdal = new HoatDongDAL();
        public DataTable LoadDanhSachHoatDongBLL()
        {
            return hoatdongdal.LoadDanhSachHoatDongDAL();
        }
        public bool AddHoatDongBLL(string idhd, string tenhd, int sogioquydinh, DateTime ngaybatdau, DateTime ngayketthuc, string donvitinh)
        {
            return hoatdongdal.AddHoatDongDAL(idhd,tenhd,sogioquydinh,ngaybatdau,ngayketthuc,donvitinh);
        }
        public void DeleteHoatDongBLL(string idhd)
        {
            hoatdongdal.DeleteHoatDongDAL(idhd);
        }
        public void UpdateHoatDongBLL(string idhd, string tenhd, int sogioquydinh, DateTime ngaybatdau, DateTime ngayketthuc, string donvitinh)
        {
            hoatdongdal.UpdateHoatDongDAL(idhd, tenhd, sogioquydinh, ngaybatdau, ngayketthuc, donvitinh);
        }
        public DataTable SearchIDHoatDongBLL(string idhd)
        {
            return hoatdongdal.SearchIDHoatDongDAL(idhd);
        }

        public DataTable SearchTenHoatDongBLL(string tenhd)
        {
            return hoatdongdal.SearchTenHoatDongDAL(tenhd);
        }

    }
}
