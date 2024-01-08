using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguoiDungBLL
    {
        private NguoiDungDAL nguoidungdal;
        public NguoiDungBLL()
        {
            nguoidungdal = new NguoiDungDAL();
        }
        public DataTable DanhSachMinhChungBLL(string idgv)
        {
            return nguoidungdal.DanhSachMinhChungDAL(idgv);
        }
    
        public bool LuuMinhChungBLL(string idhd, string idgv, string loaiminhchung)
        {
            int sogiohoanthanh = nguoidungdal.LayGioHoanThanh(idgv);
            int giochuan;
            if (sogiohoanthanh == 0)
            {
                giochuan = nguoidungdal.LayGioChuan(idgv);
                
            }
            else
            {
                giochuan = nguoidungdal.LayGioConLai(idgv);
            }
            MinhChungDTO minhchung = new MinhChungDTO()
            {
                IDHD = idhd,
                IDGV = idgv,
                IDTT = "cpd",
                SoGioDaHoanThanh = sogiohoanthanh,
                SoGioConLai = giochuan,
                LoaiMinhChung = loaiminhchung,
                NgayCapNhat = DateTime.Now

            };
            return nguoidungdal.LuuMinhChungDAL(minhchung);
        }
        public bool KiemTraIDHDBLL(string idhd, string idgv)
        {
            return nguoidungdal.KiemTraIDHDDAL(idhd, idgv);
        }
        public DataTable TrangThaMinhChungBLL()
        {
            return nguoidungdal.TrangThaMinhChungDAL();
        }
        public bool XoaMinhChungBLL(string idmc, string idgv)
        {
            return nguoidungdal.XoaMinhChungDAL(idmc, idgv);
        }



    }
}
