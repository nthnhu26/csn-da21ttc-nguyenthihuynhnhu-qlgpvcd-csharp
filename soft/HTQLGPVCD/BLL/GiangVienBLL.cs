using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class GiangVienBLL
    {
        private GiangVienDAL giangviendal = new GiangVienDAL();
        public DataTable LoadDanhSachGiangVienBLL()
        {
            return giangviendal.LoadDanhSachGiangVienDAL();
        }
        public bool AddGiangVienBLL(string idgv, string hoten, string gioitinh, string hocvi, string chucvu, string email, string sdt, string bomon)
        {
            return giangviendal.AddGiangVienDAL(idgv, hoten, gioitinh, hocvi, chucvu, email, sdt, bomon);
        }

        public void DeleteGiangVienBLL(string idgv)
        {
            giangviendal.DeleteGiangVienDAL(idgv);
        }

        public void UpdateGiangVienBLL(string idgv, string hoten, string gioitinh, string hocvi, string chucvu, string email, string sdt, string bomon)
        {
            giangviendal.UpdateGiangVienDAL(idgv, hoten, gioitinh, hocvi, chucvu, email, sdt, bomon);
        }

        public DataTable SearchIDGiangVienBLL(string idgv)
        {
            return giangviendal.SearchIDGiangVienDAL(idgv);
        }
        public DataTable SearchTenGiangVienBLL(string hoten)
        {
            return giangviendal.SearchTenGiangVienDAL(hoten);
        }


    }
}
