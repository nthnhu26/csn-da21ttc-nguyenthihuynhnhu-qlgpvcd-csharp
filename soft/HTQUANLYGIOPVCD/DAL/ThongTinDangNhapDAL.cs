using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongTinDangNhapDAL
    {
        private KetNoiCSDL ketnoicsdl;
        public ThongTinDangNhapDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
        }
        public string TenGiangVienDAL(string idgv)
        {
            string query = "SELECT HoTen FROM dbo.GIANGVIEN WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            object result = ketnoicsdl.ExecuteScalar(command);
            if (result != null)
            {
                 return result.ToString();
            }           
            return string.Empty; // Trả về chuỗi rỗng nếu không tìm thấy thông tin
        }
    }
}
