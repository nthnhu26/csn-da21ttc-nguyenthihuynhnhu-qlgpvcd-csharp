using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL taikhoandal = new TaiKhoanDAL();
        public DataTable LoadDanhSachTaiKhoanBLL()
        {
            return taikhoandal.LoadDanhSachTaiKhoanDAL();
        }
        public bool AddTaiKhoanBLL(string username, string idgv, string idqtc, string password)
        {
            return taikhoandal.AddTaiKhoanDAL(username, idgv, idqtc, password);
        }

        public void DeleteTaiKhoanBLL(string username)
        {
            taikhoandal.DeleteTaiKhoanDAL(username);
        }

        public void UpdateTaiKhoanBLL(string username, string idgv, string idqtc, string password)
        {
            taikhoandal.UpdateTaiKhoanDAL(username,idgv, idqtc, password);
        }

        public DataTable SearchUsernameTaiKhoanBLL(string username)
        {
            return taikhoandal.SearchUsernameTaiKhoanDAL(username);
        }
    }
}
