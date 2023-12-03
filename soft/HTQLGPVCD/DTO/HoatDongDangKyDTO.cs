using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618
namespace DTO
{
    public class HoatDongDangKyDTO
    {
        public string IDHDDK { get; set; }
        public string IDHD { get; set; }
        public string IDGV { get; set; }
        public string IDTT { get; set; }
        public int SoGioDaHoanThanh { get; set; }
        public int SoGioConLai { get; set; }
        public DateTime NgayDangKy { get; set; }
    }
}
#pragma warning restore CS8618