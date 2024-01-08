using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL
    {
        private KetNoiCSDL ketnoicsdl;
        public NguoiDungDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
        }
        public DataTable DanhSachMinhChungDAL(string idgv)
        {
            string query = "SELECT MC.*, TT.TenTT FROM MINHCHUNG MC JOIN TRANGTHAI TT ON TT.IDTT = MC.IDTT WHERE IDGV = '" + idgv + "'";
            return ketnoicsdl.ExecuteQuery(query);
        }

        public int LayGioChuan(string idgv)
        {
            int giochuan = 0;
            string query = "SELECT GioChuan FROM GIANGVIEN WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            object result = ketnoicsdl.ExecuteScalar(command);
            if (result != null && !Convert.IsDBNull(result))
            {
                giochuan = Convert.ToInt32(result);
            }
            return giochuan;
        }

        public int LayGioHoanThanh(string idgv)
        {
            int giohoanthanh = 0;
            string query = "SELECT SoGioDaHoanThanh FROM MINHCHUNG WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            object result = ketnoicsdl.ExecuteScalar(command);
            if (result != null && !Convert.IsDBNull(result))
            {
                giohoanthanh = Convert.ToInt32(result);
            }
            return giohoanthanh;
        }
        public int LayGioConLai(string idgv)
        {
            int gioconlai = 0;
            string query = "SELECT SoGioConLai FROM MINHCHUNG WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            object result = ketnoicsdl.ExecuteScalar(command);
            if (result != null && !Convert.IsDBNull(result))
            {
                gioconlai = Convert.ToInt32(result);
            }
            return gioconlai;
        }
        public bool LuuMinhChungDAL(MinhChungDTO minhchung)
        {

            string query = "INSERT INTO dbo.MINHCHUNG VALUES (@IDHD, @IDGV, @IDTT, @SoGioDaHoanThanh, @SoGioConLai, @LoaiMinhChung,@NgayCapNhat)";
            SqlCommand command = new SqlCommand(query);
            //     command.Parameters.AddWithValue("@IDMC", minhchung.IDMC);
            command.Parameters.AddWithValue("@IDHD", minhchung.IDHD);
            command.Parameters.AddWithValue("@IDGV", minhchung.IDGV);
            command.Parameters.AddWithValue("@IDTT", minhchung.IDTT);
            command.Parameters.AddWithValue("@SoGioDaHoanThanh", minhchung.SoGioDaHoanThanh);
            command.Parameters.AddWithValue("@SoGioConLai", minhchung.SoGioConLai);
            command.Parameters.AddWithValue("@LoaiMinhChung", minhchung.LoaiMinhChung);
            command.Parameters.AddWithValue("@NgayCapNhat", minhchung.NgayCapNhat);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        public bool KiemTraIDHDDAL(string idhd, string idgv)
        {
            string query = "SELECT COUNT(*) FROM MINHCHUNG WHERE IDHD = @IDHD AND IDGV = @IDGV";
            using (SqlCommand command = new SqlCommand(query))
            {
                command.Parameters.AddWithValue("@IDHD", idhd);
                command.Parameters.AddWithValue("@IDGV", idgv);
                int count = Convert.ToInt32(ketnoicsdl.ExecuteScalar(command));
                return count > 0; // Trả về true nếu có kết quả khác 0
            }
        }
        public DataTable TrangThaMinhChungDAL()
        {
            string query = "SELECT * FROM TRANGTHAI WHERE IDTT = 'cpd'";
            return ketnoicsdl.ExecuteQuery(query);
        }
        public bool XoaMinhChungDAL(string idmc, string idgv)
        {
            string query = "DELETE FROM dbo.MinhChung WHERE IDMC = @IDMC";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDMC", idmc);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
    }
}
