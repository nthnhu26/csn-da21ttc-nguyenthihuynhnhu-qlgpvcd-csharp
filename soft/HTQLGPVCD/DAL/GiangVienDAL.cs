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
    public class GiangVienDAL
    {
        private KetNoiCSDL ketnoicsdl = KetNoiCSDL.Instance;
        GiangVienDTO giangvien = new GiangVienDTO();
        //Load danh sách giảng viên lên datagridview
        public DataTable LoadDanhSachGiangVienDAL()
        {
            SqlConnection conn = ketnoicsdl.GetConnection();
            ketnoicsdl.OpenConnection();
            string query = "SELECT * FROM dbo.GIANGVIEN";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            ketnoicsdl.CloseConnection();
            return data;
        }
        //Thêm giảng viên
        public bool AddGiangVienDAL(string idgv, string hoten, string gioitinh, string hocvi, string chucvu, string email, string sdt, string bomon)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();

                string ktquery = "SELECT COUNT(*) FROM GIANGVIEN WHERE IDGV = @IDGV";
                SqlCommand checkCommand = new SqlCommand(ktquery, conn);
                checkCommand.Parameters.AddWithValue("@IDGV", idgv);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    return false; // Return false indicating that the IDGV already exists
                }
                else
                {
                    string query = "INSERT INTO dbo.GIANGVIEN VALUES (@IDGV, @HoTen, @GioiTinh, @HocVi, @ChucVu, @Email, @SoDienThoai, @Bomon)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@IDGV", idgv);
                    command.Parameters.AddWithValue("@HoTen", hoten);
                    command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                    command.Parameters.AddWithValue("@HocVi", hocvi);
                    command.Parameters.AddWithValue("@ChucVu", chucvu);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@SoDienThoai", sdt);
                    command.Parameters.AddWithValue("@Bomon", bomon);
                    command.ExecuteNonQuery();
                }
                return true;
            }
                
        }
        //Xóa giảng viên theo id
        public void DeleteGiangVienDAL(string idgv)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "DELETE FROM dbo.GIANGVIEN WHERE IDGV = @IDGV";
                SqlCommand command = new SqlCommand(query,conn);
                command.Parameters.AddWithValue("@IDGV", idgv);
                command.ExecuteNonQuery();
            }
        }
        //Thay đổi thông tin giảng viên
        public void UpdateGiangVienDAL(string idgv, string hoten, string gioitinh, string hocvi, string chucvu, string email, string sdt, string bomon)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "UPDATE dbo.GIANGVIEN SET HoTen = @HoTen, GioiTinh = @GioiTinh,HocVi = @HocVi, ChucVu = @ChucVu,"
                    + "Email = @Email, SoDienThoai = @SoDienThoai, Bomon = @Bomon WHERE IDGV = @IDGV";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDGV", idgv);
                command.Parameters.AddWithValue("@HoTen", hoten);
                command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                command.Parameters.AddWithValue("@HocVi", hocvi);
                command.Parameters.AddWithValue("@ChucVu", chucvu);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@SoDienThoai", sdt);
                command.Parameters.AddWithValue("@Bomon", bomon);
                command.ExecuteNonQuery();
            }
        }

        public DataTable SearchIDGiangVienDAL(string idgv)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "SELECT * FROM dbo.GIANGVIEN WHERE IDGV COLLATE Latin1_General_CS_AS = @IDGV";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDGV", idgv);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable SearchTenGiangVienDAL(string hoten)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "SELECT * FROM dbo.GIANGVIEN WHERE HoTen LIKE @HoTen";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@HoTen", "%" + hoten + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

















    }
}
