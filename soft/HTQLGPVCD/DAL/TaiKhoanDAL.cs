using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private KetNoiCSDL ketnoicsdl = KetNoiCSDL.Instance;
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        //Load danh sách giảng viên lên datagridview
        public DataTable LoadDanhSachTaiKhoanDAL()
        {
            SqlConnection conn = ketnoicsdl.GetConnection();
            ketnoicsdl.OpenConnection();
            string query = "SELECT * FROM dbo.TAIKHOAN";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            ketnoicsdl.CloseConnection();
            return data;
        }
        //Thêm giảng viên
        public bool AddTaiKhoanDAL(string username, string idgv, string idqtc, string password)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();

                string ktquery = "SELECT COUNT(*) FROM TAIKHOAN WHERE Username = @Username";
                SqlCommand checkCommand = new SqlCommand(ktquery, conn);
                checkCommand.Parameters.AddWithValue("@Username", username);
                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    return false; // Return false indicating that the IDGV already exists
                }
                else
                {
                    string query = "INSERT INTO dbo.TAIKHOAN VALUES (@Username, @IDGV, @IDQTC, @Password)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@IDGV", idgv);
                    command.Parameters.AddWithValue("@IDQTC", idqtc);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();
                }
                return true;
            }

        }
        //Xóa giảng viên theo id
        public void DeleteTaiKhoanDAL(string username)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "DELETE FROM dbo.TAIKHOAN WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();
            }
        }
        //Thay đổi thông tin giảng viên
        public void UpdateTaiKhoanDAL(string username, string idgv, string idqtc, string password)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "UPDATE dbo.GIANGVIEN SET IDGV = @IDGV, IDQTC = @IDQTC,Password = @Password WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@IDGV", idgv);
                command.Parameters.AddWithValue("@IDQTC", idqtc);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
            }
        }

        public DataTable SearchUsernameTaiKhoanDAL(string username)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "SELECT * FROM dbo.TaiKhoan WHERE Username COLLATE Latin1_General_CS_AS = @Username";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
