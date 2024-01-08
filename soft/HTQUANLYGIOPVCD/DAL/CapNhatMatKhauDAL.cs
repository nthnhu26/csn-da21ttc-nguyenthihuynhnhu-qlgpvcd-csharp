using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CapNhatMatKhauDAL
    {
        private KetNoiCSDL ketnoicsdl;
        public CapNhatMatKhauDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
        }

        public bool ThayDoiMatKhauDAL(string user, string password, string passwordnew)
        {
            // Kiểm tra xem mật khẩu hiện tại có khớp không
            string query = "SELECT Password FROM dbo.TAIKHOAN WHERE Username=@Username";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Username", user);
            DataTable data = ketnoicsdl.ExecuteReader(command);
            if (data.Rows.Count > 0)
            {
                string hashedPassword = data.Rows[0]["Password"].ToString();
                string inputPasswordHashed = MaHoaMatKhau.HashPassword(password);

                // So sánh mật khẩu hiện tại trong cơ sở dữ liệu với mật khẩu nhập vào
                if (hashedPassword == inputPasswordHashed)
                {
                    // Nếu mật khẩu hiện tại khớp, tiến hành cập nhật mật khẩu mới
                    query = "UPDATE dbo.TAIKHOAN SET Password=@NewPassword WHERE Username=@Username";
                    command = new SqlCommand(query);
                    command.Parameters.AddWithValue("@Username", user);
                    command.Parameters.AddWithValue("@NewPassword", MaHoaMatKhau.HashPassword(passwordnew));
                    return ketnoicsdl.ExecuteNonQuery(command); // Trả về true khi cập nhật thành công
                }
            }

            return false; // Trả về false nếu không tìm thấy người dùng hoặc mật khẩu không khớp
        }







    }
}

