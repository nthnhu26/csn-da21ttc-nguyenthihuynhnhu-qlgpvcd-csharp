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
    public class HoatDongDAL
    {
        private KetNoiCSDL ketnoicsdl = KetNoiCSDL.Instance;
        HoatDongDTO hoatdong=new HoatDongDTO();
        //Load danh sách hoạt động  lên datagridview
        public DataTable LoadDanhSachHoatDongDAL()
        {
            SqlConnection conn = ketnoicsdl.GetConnection();
            ketnoicsdl.OpenConnection();
            string query = "SELECT * FROM dbo.HOATDONG";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            ketnoicsdl.CloseConnection();
            return data;
        }
        public bool AddHoatDongDAL(string idhd,string tenhd, int sogioquydinh, DateTime ngaybatdau, DateTime ngayketthuc, string donvitinh)
        {
            using(SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string ktquery = "SELECT COUNT(*) FROM HOATDONG WHERE IDHD = @IDHD";
                SqlCommand checkCommand = new SqlCommand(ktquery, conn);
                checkCommand.Parameters.AddWithValue("@IDHD", idhd);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    return false; // Return false indicating that the IDGV already exists
                }
                else
                {
                    string query = "INSERT INTO dbo.HOATDONG VALUES (@IDHD, @TenHD, @SoGioQuyDinh, @NgayBatDau, @NgayKetThuc, @DonViTinh)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@IDHD", idhd);
                    command.Parameters.AddWithValue("@TenHD", tenhd);
                    command.Parameters.AddWithValue("@SoGioQuyDinh", sogioquydinh);
                    command.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);
                    command.Parameters.AddWithValue("@DonViTinh", donvitinh);
                    command.ExecuteNonQuery();
                }
                return true;
            }
        }

        public void DeleteHoatDongDAL(string idhd)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "DELETE FROM dbo.HOATDONG WHERE IDHD = @IDHD";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDHD", idhd);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateHoatDongDAL(string idhd, string tenhd, int sogioquydinh, DateTime ngaybatdau, DateTime ngayketthuc, string donvitinh)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "UPDATE dbo.HOATDONG SET TenHD = @TenHD, SoGioQuyDinh = @SoGioQuyDinh,NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, DonViTinh = @DonViTinh WHERE IDHD = @IDHD";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDHD", idhd);
                command.Parameters.AddWithValue("@TenHD", tenhd);
                command.Parameters.AddWithValue("@SoGioQuyDinh", sogioquydinh);
                command.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
                command.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);
                command.Parameters.AddWithValue("@DonViTinh", donvitinh);
                command.ExecuteNonQuery();
            }
        }

        public DataTable SearchIDHoatDongDAL(string idhd)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "SELECT * FROM dbo.HOATDONG WHERE IDHD COLLATE Latin1_General_CS_AS = @IDHD";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDHD", idhd);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable SearchTenHoatDongDAL(string tenhd)
        {
            using (SqlConnection conn = ketnoicsdl.GetConnection())
            {
                ketnoicsdl.OpenConnection();
                string query = "SELECT * FROM dbo.HOATDONG WHERE TenHD LIKE @TenHD";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TenHD", "%" + tenhd + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


















    }
}
