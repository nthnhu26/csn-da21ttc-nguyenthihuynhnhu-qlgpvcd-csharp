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
    public class HoatDongDAL
    {
        private KetNoiCSDL ketnoicsdl;
        public HoatDongDAL()
        {
            ketnoicsdl = new KetNoiCSDL();
        }
        //Lấy danh sách hoạt động
        public DataTable DanhSachHoatDongDAL()
        {
            string query = "SELECT * FROM dbo.HOATDONG";
            return ketnoicsdl.ExecuteQuery(query);
        }
        //Kiểm tra ID có tồn tại hay không
        private bool KiemTraID(string idhd)
        {
            string query = "SELECT COUNT(*) FROM HOATDONG WHERE IDHD = @IDHD";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDHD", idhd);
            int count = Convert.ToInt32(ketnoicsdl.ExecuteScalar(command));
            return count > 0; //ID tồn tại => true 
        }
        //Thêm hoạt động vào cơ sở dữ liệu
        public bool ThemHoatDongDAL(HoatDongDTO hoatdong)
        {
            if (KiemTraID(hoatdong.IDHD))
            {
                return false; //  ID đã tồn tại, không thêm hoạt động
            }
            string query = "INSERT INTO dbo.HOATDONG VALUES (@IDHD, @TenHD, @SoGioQuyDinh, @NgayBatDau, @NgayKetThuc, @DonViTinh,@MinhChung)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDHD", hoatdong.IDHD);
            command.Parameters.AddWithValue("@TenHD", hoatdong.TenHD);
            command.Parameters.AddWithValue("@SoGioQuyDinh", hoatdong.SoGioQuyDinh);
            command.Parameters.AddWithValue("@NgayBatDau", hoatdong.NgayBatDau);
            command.Parameters.AddWithValue("@NgayKetThuc", hoatdong.NgayKetThuc);
            command.Parameters.AddWithValue("@DonViTinh", hoatdong.DonViTinh);
            command.Parameters.AddWithValue("@MinhChung", hoatdong.MinhChung);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        //Thay đổi thông tin của hoạt động
        public bool CapNhatHoatDongDAL(HoatDongDTO hoatdong)
        {
            if (!KiemTraID(hoatdong.IDHD))
            {
                return false; //  ID không tồn tại, không sửa hoạt động
            }
            string query = "UPDATE dbo.HOATDONG SET TenHD = @TenHD, SoGioQuyDinh = @SoGioQuyDinh,NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, DonViTinh = @DonViTinh, MinhChung = @MinhChung WHERE IDHD = @IDHD";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDHD", hoatdong.IDHD);
            command.Parameters.AddWithValue("@TenHD", hoatdong.TenHD);
            command.Parameters.AddWithValue("@SoGioQuyDinh", hoatdong.SoGioQuyDinh);
            command.Parameters.AddWithValue("@NgayBatDau", hoatdong.NgayBatDau);
            command.Parameters.AddWithValue("@NgayKetThuc", hoatdong.NgayKetThuc);
            command.Parameters.AddWithValue("@DonViTinh", hoatdong.DonViTinh);
            command.Parameters.AddWithValue("@MinhChung", hoatdong.MinhChung);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        //Xóa hoạt động theo id       
        public bool XoaHoatDongDAL(string idhd)
        {
            // Xóa dữ liệu liên quan từ các bảng có ràng buộc khóa ngoại trước
        
            string query2 = "DELETE FROM dbo.MINHCHUNG WHERE IDHD = @IDHD";
            SqlCommand command2 = new SqlCommand(query2);
            command2.Parameters.AddWithValue("@IDHD", idhd);

            ketnoicsdl.ExecuteNonQuery(command2);
            //Xóa hoạt động
            string query = "DELETE FROM dbo.HOATDONG WHERE IDHD = @IDHD";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IDHD", idhd);
            return ketnoicsdl.ExecuteNonQuery(command);
        }
        //Tìm hoạt động theo id
        public DataTable TimIDHoatDongDAL(string idhd)
        {
            string query = "SELECT * FROM dbo.HOATDONG WHERE IDHD COLLATE Latin1_General_CS_AS = @IDHD";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@IDHD", idhd));
        }
        //Tìm hoạt động theo tên
        public DataTable TimTenHoatDongDAL(string tenhd)
        {
            string query = "SELECT * FROM dbo.HOATDONG WHERE TenHD LIKE @TenHD";
            return ketnoicsdl.ExecuteQuery(query, new SqlParameter("@TenHD", "%" + tenhd + "%"));
        }
    }
}
