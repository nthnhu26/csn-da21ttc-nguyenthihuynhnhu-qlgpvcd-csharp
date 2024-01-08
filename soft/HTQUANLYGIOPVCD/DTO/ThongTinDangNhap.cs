using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinDangNhap
    {
        private static ThongTinDangNhap instance;

        public static ThongTinDangNhap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinDangNhap();
                }
                return instance;
            }
        }
        public string Username { get; set; }
        public string IDGV { get; set; }
        public string IDQTC { get; set; }
        public string IDHD { get; set; }
        private ThongTinDangNhap() { }
    }
}
