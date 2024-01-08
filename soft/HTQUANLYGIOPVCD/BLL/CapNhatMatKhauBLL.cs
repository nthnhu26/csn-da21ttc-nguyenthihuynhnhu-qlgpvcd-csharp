using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CapNhatMatKhauBLL
    {
        private CapNhatMatKhauDAL capnhatmatkhaudal;
        public CapNhatMatKhauBLL()
        {
            capnhatmatkhaudal = new CapNhatMatKhauDAL();
        }
         public bool ThayDoiMatKhauBLL(string user, string password, string passwordnew)
        {
            return capnhatmatkhaudal.ThayDoiMatKhauDAL(user, password, passwordnew);
        }
    }
}
