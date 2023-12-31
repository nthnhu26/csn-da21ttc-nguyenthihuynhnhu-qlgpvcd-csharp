## XÂY DỰNG HỆ THỐNG QUẢN LÝ GIỜ PHỤC VỤ CỘNG ĐỒNG CỦA KHOA KT&CN - TRƯỜNG ĐẠI HỌC TRÀ VINH ##
### Giảng viên hướng dẫn ###
- Trần Văn Nam
  - Email: namtv@tvu.edu.vn
  - Điện thoại: 0365583414
### Sinh viên thực hiện ###
- Nguyễn Thị Huỳnh Như
  - Email: nguyennhu3570@gmail.com
  - Số điện thoại: 0357104009
## CẤU TRÚC CÂY THƯ MỤC TRÊN GITHUB REPOSITORE ##
- progress-report: gồm các file word báo cáo tiến độ theo tuần.
- soft:  
  - HTQUANLYGIOPVCD: Gồm mã nguồn của chương trình.
  - CoSoDuLieu: Gồm cơ sở dữ liệu để chạy chương trình.
  - MoHinhDuLieu: Gồm các mô hình dữ liệu của hệ thống.
- src: Gồm file danh sách các hoạt động phục vụ cộng động và danh sách các giảng viên trong khoa KT&CN để chạy thử chương trình.
- thesis: 
  - doc: Gồm đề cương chi tiết và quyển báo cáo đồ án cơ sở ngành.
  - abs: Gồm slide thuyết trình.
## HƯỚNG DẪN CÀI ĐẶT CHƯƠNG TRÌNH ##
- Tải thư mục HTQUANLYGIOPVCD và CoSoDuLieu.
- Chạy file HTQUANLYGIOPVCD.sql trong thư mục CoSoDuLieu bằng công cụ SQL Server Management Tools 2019 để thêm dữ liệu vào server.
- Chạy chương trình trên Visual Studio .NET Framework 4.8
- Thay đổi tên server trong class KetNoiCSDL.cs nằm trong lớp DAL: "Data Source= <tên server>;Initial Catalog=HTQUANLYGIOPVCD;Integrated Security=True";
- Tài khoản admin của hệ thống: 
  - Tên đăng nhập: GV1
  - Mật khẩu: 123
## BÁO CÁO TIẾN ĐỘ ##
- Cài đặt các ứng dụng hỗ trợ làm đồ án:
  - Visual Studio 2013
  - SQL Server 2022
  - SQL Server Management Tools 2019
  - PowerDesigner 16.5
  - Đăng ký dịch vụ Google Drive API để lưu trữ minh chứng.
- Thực hiện công việc của tuần 1:
  - Phân tích yêu cầu của hệ thống
  - Tìm hiểu về ngôn ngữ C#
  - Tìm hiểu về quy chế tính giờ phục vụ cộng đồng
- Thực hiện công việc của tuần 2:
  - Thiết kế cơ sở dữ liệu: sử dụng công cụ PowerDesigner 
      - Thiết kế các đối tượng và mối quan hệ giữa các đối tượng
  - Thiết kế giao diện người dùng: Dùng Winforms để thiết kế các giao diện gồm các form sau:
      - fTrangChu: Trang chủ của hệ thống
      - fLogin: Trang đăng nhập
      - fGiangVien, fHoatDong, fMinhChung, fTaiKhoan, fTaiKhoan: Trang dành cho người quản trị 
      - fNguoiDung: Trang dành cho giảng viên
      - fCapNhatMatKhau: Trang cập nhật mật khẩu
- Thực hiện công việc tuần 3: Các file code của chương trình được lưu trong thư mục soft
    - Xây dựng cơ sở dữ liệu:
      - Xây dựng mối quan hệ giữa các đối tượng dữ liệu trong hệ thống 
      - Xây dựng mô hình dữ liệu vật lý
      - Xây dựng sơ đồ BFD (Block Flow Diagram): để biểu diễn quá trình hoạt động của hệ thống
      - Xây dựng sơ đồ DFD (Data Flow Diagram): biểu diễn luồng dữ liệu trong hệ thống
      - Xây dựng cơ sở dữ liệu bằng SQL Server Tools 2019
    - Xây dựng giao diện người dùng gồm các chức năng: 
      - Quản lý thông tin giảng viên, hoạt động, minh chứng, tài khoản.
      - Tải minh chứng lên Googledrive.
      - Phê duyệt minh chứng.
      - TÍnh toán số giờ hoàn thành và số giờ còn lại tự động cho giảng viên.
- Thực hiện công việc tuần 4: Kiểm thử và hoàn thiện hệ thống.
- Thực hiện công việc tuần 5: Hoàn thiện quyển báo cáo và slide thuyết trình.


