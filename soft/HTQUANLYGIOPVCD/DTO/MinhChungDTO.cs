using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MinhChungDTO
    {
        public int IDMC { get; set; }
        public string IDHD { get; set; }
        public string IDGV { get; set; }
        public string IDTT { get; set; }
        public int SoGioDaHoanThanh { get; set; }
        public int SoGioConLai { get; set; }
        public string LoaiMinhChung { get; set; }
        public DateTime NgayCapNhat { get; set; }    
    }
}
