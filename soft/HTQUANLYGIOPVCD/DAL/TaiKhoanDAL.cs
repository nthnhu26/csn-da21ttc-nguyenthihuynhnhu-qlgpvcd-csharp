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
    public class TaiKhoanDAL
    {
        private KetNoiCSDL ketnoicsdl;
        private GiangVienDAL giangviendal;
        public TaiKhoanDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
            giangviendal = new GiangVienDAL();
        }
        //Lấy danh sách hoạt động
        public DataTable DanhSachTaiKhoanDAL()
        {
            string query = "SELECT TK.Username,TK.IDGV, GV.HoTen,TK.IDQTC, QTC.TenQTC,TK.Password FROM TAIKHOAN TK JOIN QUYENTRUYCAP QTC ON TK.IDQTC = QTC.IDQTC JOIN GIANGVIEN GV ON TK.IDGV=GV.IDGV";
            return ketnoicsdl.ExecuteQuery(query);
        }
        public DataTable DanhSachIDGVDAL()
        {
            string query = "SELECT GV.IDGV FROM GIANGVIEN GV LEFT JOIN TAIKHOAN TK ON GV.IDGV=TK.IDGV WHERE TK.IDGV IS NULL";
            return ketnoicsdl.ExecuteQuery(query);
        }
        public string DanhSachTenGVDAL(string idgv)
        {
            string query = "SELECT HoTen FROM GIANGVIEN WHERE IDGV = @IDGV";
            DataTable ketqua = ketnoicsdl.ExecuteQuery(query, new SqlParameter("@IDGV", idgv));
            if (ketqua.Rows.Count > 0)
            {
                // Lấy giá trị tên từ cột "HoTen" của dòng đầu tiên (nếu có)
                return ketqua.Rows[0]["HoTen"].ToString();
            }
            return "";
        }
        public string DanhSachTenQTCDAL(string idqtc)
        {
            string query = "SELECT TenQTC FROM QUYENTRUYCAP WHERE IDQTC = @IDQTC";
            DataTable ketqua = ketnoicsdl.ExecuteQuery(query, new SqlParameter("@IDQTC", idqtc));
            if (ketqua.Rows.Count > 0)
            {
                // Lấy giá trị tên từ cột "HoTen" của dòng đầu tiên (nếu có)
                return ketqua.Rows[0]["TenQTC"].ToString();
            }
            return "";
        }



        //Kiểm tra Username có tồn tại hay không
        private bool KiemTraUsername(string username)
        {
            string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Username", username);
            int count = Convert.ToInt32(ketnoicsdl.ExecuteScalar(command));
            return count > 0; //ID tồn tại => true 
        }
        //Thêm tài khoản vào cơ sở dữ liệu
        public bool ThemTaiKhoanDAL(TaiKhoanDTO taikhoan)
        {
            if (KiemTraUsername(taikhoan.Username))
            {
                return false; //  ID đã tồn tại, không thêm tài khoản
            }
            else
            {
                if(!giangviendal.KiemTraIDGV(taikhoan.IDGV))
                {
                    return false;
                }
                else
                {
                    string query = "INSERT INTO dbo.TAIKHOAN VALUES (@Username, @IDGV, @IDQTC, @Password)";
                    SqlCommand command = new SqlCommand(query);
                    command.Parameters.AddWithValue("@Username", taikhoan.Username);
                    command.Parameters.AddWithValue("@IDGV", taikhoan.IDGV);
                    command.Parameters.AddWithValue("@IDQTC", taikhoan.IDQTC);
                    command.Parameters.AddWithValue("@Password", taikhoan.Password);
                    return ketnoicsdl.ExecuteNonQuery(command);
                }
               
            }          
        }
        //Thay đổi thông tin của hoạt động
        public bool CapNhatTaiKhoanDAL(TaiKhoanDTO taikhoan)
        {
            if (!KiemTraUsername(taikhoan.Username))
            {
                return false; //  ID không tồn tại, không sửa hoạt động
            }
            string query = "UPDATE dbo.TAIKHOAN SET IDGV = @IDGV, IDQTC = @IDQTC,Password = @Password WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Username", taikhoan.Username);
            command.Parameters.AddWithValue("@IDGV", taikhoan.IDGV);
            command.Parameters.AddWithValue("@IDQTC", taikhoan.IDQTC);
            command.Parameters.AddWithValue("@Password", taikhoan.Password);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        //Xóa hoạt động theo id
        public bool XoaTaiKhoanDAL(string username)
        {
            if (!KiemTraUsername(username))
            {
                return false; //  ID không tồn tại, không sửa hoạt động
            }
            string query = "DELETE FROM dbo.TAIKHOAN WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Username", username);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        //Tìm hoạt động theo id
        public DataTable TimUsernameTaiKhoanDAL(string username)
        {
            string query = "SELECT * FROM dbo.TAIKHOAN WHERE Username COLLATE Latin1_General_CS_AS = @Username";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@Username", username));
        }
    }
}
