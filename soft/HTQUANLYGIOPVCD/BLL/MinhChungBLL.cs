using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MinhChungBLL
    {
        private MinhChungDAL minhchungdal;
        public MinhChungBLL()
        {
            minhchungdal = new MinhChungDAL();
        }
        public DataTable DanhSachMinhChungBLL()
        {
            return minhchungdal.DanhSachMinhChungDAL();
        }

        public bool KiemTraIDGVBLL(string idgv)
        {
            return minhchungdal.KiemTraIDGVDAL(idgv);
        }
        public DataTable TrangThaMinhChungBLL()
        {
            return minhchungdal.TrangThaiMinhChungDAL();
        }
        public void CapNhatGioHoanThanhBLL(string idgv, int giohoanthanh)
        {

            // minhchungdal.CapNhatGioHoanThanhDAL(idgv, giohoanthanh);
        }
        public int LayGioQuyDinhBLL(string idhd)
        {
            return minhchungdal.LayGioQuyDinhDAL(idhd);
        }
        public bool CapNhatTTMinhChungBLL(string idmc, string idhd, string idgv, string idtt)
        {
            string idttht = minhchungdal.LayTrangThaiHienTai(idmc);
            if (idttht != "dpd")
            {
                minhchungdal.CapNhatTTMinhChungDAL(idmc, idtt);
                int giohoanthanh = minhchungdal.LayGioQuyDinhDAL(idhd);
                if (idtt == "dpd")
                {
                    minhchungdal.CapNhatGioHoanThanhDAL(idgv, giohoanthanh);
                }
                return true;
            }
            return false;


        }

        public bool XoaMinhChungBLL(string idmc)
        {
            return minhchungdal.XoaMinhChungDAL(idmc);
        }
        public void CapNhatGioHoanThanh(string idgv, int giohoanthanh)
        {
            minhchungdal.CapNhatGioHoanThanhDAL(idgv, giohoanthanh);
        }

        public DataTable TimIDGVBLL(string idgv)
        {

            return minhchungdal.TimIDGVDAL(idgv);
        }

        public DataTable TimIDHDBLL(string idhd)
        {

            return minhchungdal.TimIDHDDAL(idhd);
        }

        public DataTable TimIDTTBLL(string idtt)
        {

            return minhchungdal.TimIDTTDAL(idtt);
        }




    }
}
