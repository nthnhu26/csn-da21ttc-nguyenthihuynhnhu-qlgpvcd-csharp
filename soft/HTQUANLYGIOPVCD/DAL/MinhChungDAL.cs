using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;



namespace DAL
{
    public class MinhChungDAL
    {
        private KetNoiCSDL ketnoicsdl;
        public MinhChungDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
        }
        public DataTable DanhSachMinhChungDAL()
        {
            string query = "SELECT MC.*, TT.TenTT, GV.HoTen FROM MINHCHUNG MC JOIN TRANGTHAI TT ON TT.IDTT = MC.IDTT JOIN GIANGVIEN GV ON GV.IDGV = MC.IDGV";
            return ketnoicsdl.ExecuteQuery(query);
        }
        //Trạng thái minh chứng
        public DataTable TrangThaiMinhChungDAL()
        {
            string query = "SELECT * FROM TRANGTHAI";
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
        public int LayGioQuyDinhDAL(string idhd)
        {
            int gioquydinh = 0;
            string query = "SELECT SoGioQuyDinh FROM HOATDONG WHERE IDHD = @IDHD";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDHD", idhd);
            object result = ketnoicsdl.ExecuteScalar(command);
            if (result != null && !Convert.IsDBNull(result))
            {
                gioquydinh = Convert.ToInt32(result);
            }
            return gioquydinh;
        }

        public void CapNhatGioHoanThanhDAL(string idgv, int giohoanthanh)
        {
            string query = "UPDATE MINHCHUNG SET SoGioDaHoanThanh = SoGioDaHoanThanh+@SoGioHoanThanh, SoGioConLai = SoGioConLai - @SoGioHoanThanh WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            command.Parameters.AddWithValue("@SoGioHoanThanh", giohoanthanh);
            ketnoicsdl.ExecuteNonQuery(command);
        }

        public void CapNhatTTMinhChungDAL(string idmc, string idtt)
        {
            // Cập nhật SoGioDaHoanThanh và SoGioConLai
            string query = "UPDATE MINHCHUNG SET IDTT = @IDTT WHERE IDMC = @IDMC";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDMC", idmc);
            command.Parameters.AddWithValue("@IDTT", idtt);
            ketnoicsdl.ExecuteNonQuery(command);
        }
        public string LayTrangThaiHienTai(string idmc)
        {
            string query = "SELECT IDTT FROM MINHCHUNG WHERE IDMC = @IDMC";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDMC", idmc);
            object result = ketnoicsdl.ExecuteScalar(command);
            if (result != null && !Convert.IsDBNull(result))
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
        }

        private bool KiemTraID(string idmc)
        {
            string query = "SELECT COUNT(*) FROM MINHCHUNG WHERE IDMC = @IDMC";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDMC", idmc);
            int count = Convert.ToInt32(ketnoicsdl.ExecuteScalar(command));
            return count > 0; //ID tồn tại => true 
        }
        public bool XoaMinhChungDAL(string idmc)
        {
            if (!KiemTraID(idmc))
            {
                return false; //  ID không tồn tại, không sửa hoạt động
            }
            string query = "DELETE FROM dbo.MinhChung WHERE IDMC = @IDMC";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDMC", idmc);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        public bool KiemTraIDGVDAL(string idgv)
        {
            string query = "SELECT COUNT(*) FROM dbo.MINHCHUNG WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            int count = Convert.ToInt32(ketnoicsdl.ExecuteScalar(command));
            return count > 0; //ID tồn tại => true 
        }


        public DataTable TimIDGVDAL(string idgv)
        {
            string query = "SELECT * FROM dbo.MINHCHUNG WHERE IDGV COLLATE Latin1_General_CS_AS = @IDGV";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@IDGV", idgv));
        }

        public DataTable TimIDHDDAL(string idhd)
        {
            string query = "SELECT * FROM dbo.MINHCHUNG WHERE IDHD COLLATE Latin1_General_CS_AS = @IDHD";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@IDHD", idhd));
        }
        public DataTable TimIDTTDAL(string idtt)
        {
            string query = "SELECT * FROM dbo.MINHCHUNG WHERE IDTT COLLATE Latin1_General_CS_AS = @IDTT";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@IDTT", idtt));
        }



    }
}
