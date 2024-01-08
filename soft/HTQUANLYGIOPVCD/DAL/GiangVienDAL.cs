using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class GiangVienDAL
    {
        private KetNoiCSDL ketnoicsdl;
        public GiangVienDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
        }
        //Lấy danh sách hoạt động
        public DataTable DanhSachGiangVienDAL()
        {
            string query = "SELECT * FROM dbo.GIANGVIEN";
            return ketnoicsdl.ExecuteQuery(query);
        }
        //Kiểm tra ID có tồn tại hay không
        public bool KiemTraIDGV(string idgv)
        {
            string query = "SELECT COUNT(*) FROM GIANGVIEN WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            int count = Convert.ToInt32(ketnoicsdl.ExecuteScalar(command));
            return count > 0; //ID tồn tại => true 
        }
        //Thêm hoạt động vào cơ sở dữ liệu
        public bool ThemGiangVienDAL(GiangVienDTO giangvien)
        {
            if (KiemTraIDGV(giangvien.IDGV))
            {
                return false; //  ID đã tồn tại, không thêm hoạt động
            }
            string query = "INSERT INTO dbo.GIANGVIEN VALUES (@IDGV, @HoTen, @GioiTinh, @HocVi, @ChucVu, @Email, @SoDienThoai, @BoMon,@GioChuan)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", giangvien.IDGV);
            command.Parameters.AddWithValue("@HoTen", giangvien.HoTen);
            command.Parameters.AddWithValue("@GioiTinh", giangvien.GioiTinh);
            command.Parameters.AddWithValue("@HocVi", giangvien.HocVi);
            command.Parameters.AddWithValue("@ChucVu", giangvien.ChucVu);
            command.Parameters.AddWithValue("@Email", giangvien.Email);
            command.Parameters.AddWithValue("@SoDienThoai", giangvien.SoDienThoai);
            command.Parameters.AddWithValue("@BoMon", giangvien.BoMon);
            command.Parameters.AddWithValue("@GioChuan", giangvien.GioChuan);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        //Thay đổi thông tin của hoạt động
        public bool CapNhatGiangVienDAL(GiangVienDTO giangvien)
        {
            if (!KiemTraIDGV(giangvien.IDGV))
            {
                return false; //  ID không tồn tại, không sửa hoạt động
            }
            string query = "UPDATE dbo.GIANGVIEN SET HoTen = @HoTen, GioiTinh = @GioiTinh,HocVi = @HocVi, ChucVu = @ChucVu,"
            + "Email = @Email, SoDienThoai = @SoDienThoai, BoMon = @BoMon, GioChuan = @GioChuan WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", giangvien.IDGV);
            command.Parameters.AddWithValue("@HoTen", giangvien.HoTen);
            command.Parameters.AddWithValue("@GioiTinh", giangvien.GioiTinh);
            command.Parameters.AddWithValue("@HocVi", giangvien.HocVi);
            command.Parameters.AddWithValue("@ChucVu", giangvien.ChucVu);
            command.Parameters.AddWithValue("@Email", giangvien.Email);
            command.Parameters.AddWithValue("@SoDienThoai", giangvien.SoDienThoai);
            command.Parameters.AddWithValue("@BoMon", giangvien.BoMon);
            command.Parameters.AddWithValue("@GioChuan", giangvien.GioChuan);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        //Xóa hoạt động theo id
        /*
        public bool XoaGiangVienDAL(string idgv)
        {
            if (!KiemTraIDGV(idgv))
            {
                return false; //  ID không tồn tại, không sửa hoạt động
            }
            string query = "DELETE FROM dbo.GIANGVIEN WHERE IDGV = @IDGV";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDGV", idgv);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
         * */
        public bool XoaGiangVienDAL(string idgv)
        {
            // Xóa dữ liệu liên quan từ các bảng có ràng buộc khóa ngoại trước
            string query1 = "DELETE FROM dbo.TAIKHOAN WHERE IDGV = @IDGV";
            string query2 = "DELETE FROM dbo.MINHCHUNG WHERE IDGV = @IDGV";

            SqlCommand command1 = new SqlCommand(query1);
            SqlCommand command2 = new SqlCommand(query2);

            command1.Parameters.AddWithValue("@IDGV", idgv);
            command2.Parameters.AddWithValue("@IDGV", idgv);

            ketnoicsdl.ExecuteNonQuery(command1);
            ketnoicsdl.ExecuteNonQuery(command2);

            // Sau khi xóa dữ liệu liên quan, xóa giảng viên từ bảng GIANGVIEN
            string query = "DELETE FROM dbo.GIANGVIEN WHERE IDGV = @IDGV";
            SqlCommand deleteGiangVienCommand = new SqlCommand(query);
            deleteGiangVienCommand.Parameters.AddWithValue("@IDGV", idgv);
            return ketnoicsdl.ExecuteNonQuery(deleteGiangVienCommand);
        }

        //Tìm hoạt động theo id
        public DataTable TimIDGiangVienDAL(string idgv)
        {
            string query = "SELECT * FROM dbo.GIANGVIEN WHERE IDGV COLLATE Latin1_General_CS_AS = @IDGV";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@IDGV", idgv));
        }
        //Tìm hoạt động theo tên
        public DataTable TimTenGiangVienDAL(string hoten)
        {
            string query = "SELECT * FROM dbo.GIANGVIEN WHERE HoTen LIKE @HoTen";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@HoTen", "%" + hoten + "%"));
        }
    }
}
