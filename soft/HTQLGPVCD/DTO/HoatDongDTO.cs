using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618
namespace DTO
{
    public class HoatDongDTO
    {
        public string IDHD { get; set; }
        public string TenHD { get; set; }
        public int SoGioQuyDinh { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string DonViTinh { get; set; }
    }
}
#pragma warning restore CS8618