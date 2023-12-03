using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618
namespace DTO
{
    public class MinhChungDTO
    {
        public string IDMinhChung { get; set; }
        public string IDHD { get; set; }
        public string IDGV { get; set; }
        public string TenMinhChung { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}
#pragma warning restore CS8618