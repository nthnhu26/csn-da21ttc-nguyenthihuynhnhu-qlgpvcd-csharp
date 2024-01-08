using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DangNhapDAL
    {
        private KetNoiCSDL ketnoicsdl;
        public DangNhapDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
        }
        public TaiKhoanDTO KiemTraDangNhapDAL(string user, string pass)
        {
            TaiKhoanDTO taikhoan = null;
            string query = "SELECT* FROM dbo.TAIKHOAN WHERE Username COLLATE Latin1_General_CS_AS = @Username";
            using (SqlCommand command = new SqlCommand(query))
            {
                command.Parameters.AddWithValue("@Username", user);
                DataTable data = ketnoicsdl.ExecuteReader(command);
                foreach (DataRow row in data.Rows)
                {
                    string hashedPassword = row["Password"].ToString();
                    string inputPasswordHashed = MaHoaMatKhau.HashPassword(pass);

                    if (hashedPassword == inputPasswordHashed)
                    {
                        taikhoan = new TaiKhoanDTO
                        {
                            Username = row["Username"].ToString(),
                            IDGV = row["IDGV"].ToString(),
                            IDQTC = row["IDQTC"].ToString(),
                            Password = hashedPassword,
                        };
                    }
                }
            }
            return taikhoan;
        }















    }
}
