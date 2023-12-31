
/****** Object:  Database [HTQUANLYGIOPVCD]    Script Date: 1/8/2024 10:09:59 PM ******/
CREATE DATABASE [HTQUANLYGIOPVCD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HTQUANLYGIOPVCD', FILENAME = N'E:\UngDung\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HTQUANLYGIOPVCD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HTQUANLYGIOPVCD_log', FILENAME = N'E:\UngDung\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HTQUANLYGIOPVCD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HTQUANLYGIOPVCD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET ARITHABORT OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET RECOVERY FULL 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET  MULTI_USER 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HTQUANLYGIOPVCD', N'ON'
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET QUERY_STORE = ON
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HTQUANLYGIOPVCD]
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[IDGV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[HocVi] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[BoMon] [nvarchar](50) NOT NULL,
	[GioChuan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOATDONG]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOATDONG](
	[IDHD] [varchar](10) NOT NULL,
	[TenHD] [nvarchar](max) NULL,
	[SoGioQuyDinh] [int] NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
	[DonViTinh] [nvarchar](50) NOT NULL,
	[MinhChung] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MINHCHUNG]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MINHCHUNG](
	[IDMC] [int] IDENTITY(1,1) NOT NULL,
	[IDHD] [varchar](10) NOT NULL,
	[IDGV] [varchar](10) NOT NULL,
	[IDTT] [varchar](10) NOT NULL,
	[SoGioDaHoanThanh] [int] NOT NULL,
	[SoGioConLai] [int] NOT NULL,
	[LoaiMinhChung] [nvarchar](100) NOT NULL,
	[NgayCapNhat] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYENTRUYCAP]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYENTRUYCAP](
	[IDQTC] [varchar](10) NOT NULL,
	[TenQTC] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[Username] [varchar](10) NOT NULL,
	[IDGV] [varchar](10) NOT NULL,
	[IDQTC] [varchar](10) NOT NULL,
	[Password] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANGTHAI]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAI](
	[IDTT] [varchar](10) NOT NULL,
	[TenTT] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV1', N'Nguyễn Bảo Ân', N'Nam', N'Tiến sĩ', N'Phó trưởng bộ môn', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV3', N'Nguyễn Ngọc Đan Thanh', N'Nữ', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV4', N'Hà Thị Thuý Vi', N'Nữ', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV5', N'Nguyễn Hoàng Duy Thiện', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV6', N'Nguyễn Hiếu Minh', N'Nam', N'Phó giáo sư', N'Chuyên gia đầu ngành', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV7', N'Nguyễn Nhứt Lam', N'Nam', N'Tiến sĩ', N'Trưởng bộ môn', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV8', N'Nguyễn Bá Nhiệm', N'Nam', N'Thạc sĩ', N'Phó trưởng bộ môn', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV9', N'Nguyễn Trần Diễm Hạnh', N'Nữ', N'Tiến sĩ', N'Phó trưởng bộ môn', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV10', N'Trần Văn Nam', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Công nghệ thông tin', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV12', N'Đặng Xuân Trọng', N'Nam', N'Tiến sĩ', N'Chuyên gia đầu ngành', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV11', N'Phan Tấn Tài', N'Nam', N'Nghiên cứu sinh', N'Trưởng bộ môn', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV13', N'Nguyễn Vũ Lực', N'Nam', N'Thạc sĩ', N'Phó trưởng bộ môn', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV14', N'Trương Văn Mến', N'Nam', N'Tiến sĩ', N'Phó trưởng bộ môn', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV15', N'Huỳnh Thanh Bảnh', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV16', N'Phan Văn Tuân', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV17', N'Phạm Vũ Phong', N'Nam', N'Nghiên cứu sinh', N'Giảng viên ', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV18', N'Thạch Ngọc Phúc', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV19', N'Dương Minh Hùng', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV20', N'Tăng Tấn Minh', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Cơ khí - Động lực', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV21', N'Trần Thị Thanh', N'Nữ', N'Giáo sư', N'Chuyên gia đầu ngành', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV22', N'Nguyễn Xuân Sơn', N'Nam', N'Tiến sĩ', N'Chuyên gia đầu ngành', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV23', N'Huỳnh Văn Hiệp', N'Nam', N'Tiến sĩ', N'Trưởng bộ môn', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV24', N'Đoàn Công Chánh', N'Nam', N'Thạc sĩ', N'Phó trưởng bộ môn', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV25', N'Nguyễn Thành Công', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV26', N'Nguyễn Thanh Tâm', N'Nam', N'Tiến sĩ', N'Giảng viên ', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV27', N'Cao Hữu Lợi', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV28', N'Nguyễn Phú Nhuận', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV29', N'Ngô Gia Truyền', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV30', N'Huỳnh Thị Mỹ Dung', N'Nữ', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Xây dựng ', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV31', N'Đỗ Đức Tôn', N'Nam', N'Phó giáo sư', N'Chuyên gia đầu ngành', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV32', N'Vũ Thắng', N'Nam', N'Tiến sĩ', N'Chuyên gia đầu ngành', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV33', N'Cao Phương Thảo', N'Nữ', N'Tiến sĩ', N'Trưởng bộ môn', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV34', N'Trần Song Toàn', N'Nam', N'Tiến sĩ', N'Phó trưởng bộ môn', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV35', N'Trần Song Toàn', N'Nam', N'Tiến sĩ', N'Phó trưởng bộ môn', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV36', N'Nguyễn Đức Hiệu', N'Nam', N'Thạc sĩ', N'Phó trưởng bộ môn', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV37', N'Bùi Thị Thu Thủy', N'Nữ', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV38', N'Đặng Hoàng Minh', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV39', N'Kim Anh Tuấn', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Điện - Điện tử', 150)
INSERT [dbo].[GIANGVIEN] ([IDGV], [HoTen], [GioiTinh], [HocVi], [ChucVu], [Email], [SoDienThoai], [BoMon], [GioChuan]) VALUES (N'GV40', N'Lê Thanh Tùng', N'Nam', N'Thạc sĩ', N'Giảng viên ', N'', N'', N'Điện - Điện tử', 150)
GO
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD1', N'- Hoạt động chuyển giao, hỗ trợ,tập huấn tư vấn, cung cấp dịch vụ, cải tiến khoa học kỹ thuật cho cộng đồng và các hoạt động hỗ trợ trong việc xây dựng nông thôn mới', 30, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Hợp đồng được BGH/Lãnh đạo các đơn vị trực thuộc trường hoạt động độc lập (CRCS, CSP, CPE....) ký duyệt.
- Quyết định / Danh sách thành viên.
- Kế hoạch')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD2', N'- Vận động quỹ khuyến học cho học sinh, sinh viên TVU với trị giá từ 10 triệu trở lên', 30, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Bản công nhận.
- Phiếu thu của Trường.
- Giấy xác nhận của đơn vị.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD3', N'- Xúc tiến và gắn kết hợp tác ghi nhớ, đào tạo, nghiên cứu với các đơn vị ngoài trường', 40, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Bản ghi nhớ', N'- Bản ghi nhớ Biên bản thương thảo hợp tác.
- Danh sách xác nhận của đơn vị
- Kế hoạch
- Email trao đổi thông tin.
- Văn bản thỏa thuận.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD5', N'- Sửa chữa tu bổ các công trình phúc lợi phục vụ cộng đồng', 40, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Kế hoạch', N'- Kế hoạch 
- Danh sách giảng viên')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD6', N'- Tập huấn, Báo cáo chuyên đề học thuật; phổ biến pháp luật cho giáo viên; học sinh các trường phổ thông, giảng viên,sinh viên', 20, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Danh sách giảng viên.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD7', N'- Tham gia ban chỉ huy chiến dịch thanh niên tình nguyện hè, các hoạt động phong trào đoàn thể do tỉnh tổ chức.', 20, CAST(N'2023-12-25T00:00:00.000' AS DateTime), CAST(N'2023-12-25T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Danh sách giảng viên.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD8', N'- Tham gia các hoạt động về nguồn nhằm giáo dục truyền thống cho viên chức, sinh viên... Các hoạt động phong trào, hưởng ứng, chào mừng các ngày lễ lớn, ngày kỷ niệm... do Trường và các sở ban ngành phát động.', 20, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Giấy xác nhận.
Danh sách đăng ký tham gia của đơn vị.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD9', N'- Hỗ trợ các trường mầm non; tiểu học; THPT đến trải nghiệm thực tế tại đơn vị', 30, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Danh sách phân công của đơn vị.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD10', N'Các hoạt động tình nguyện, thiện nguyện được phát động theo chủ trương của các tổ chức chính trị, xã hội, của Trường Đại học Trà Vinh và của cá nhân được cho phép (mang hình ảnh Trường Đại học Trà Vinh) như:
- Tham gia chương trình tư vấn, chăm sóc sức khỏe và giáo dục sức khỏe cho người dân; khám bệnh, chữa bệnh miễn phí...
Thực hiện tư vấn, tuyên truyền pháp luật cho cộng đồng, các cơ sở tôn giáo....
Hiến máu nhân đạo; tiếp sức mùa thi:
- Tư vấn tuyển sinh; tư vẫn việc làm cho sinh viên...
- Tham gia các hoạt động tiếp sinh, thiết kế các sản phẩm phục vụ công tác tuyển sinh...
- Thăm hỏi và phát quà cho trẻ em mồ côi tại các cơ sở nhân đạo như: trung tâm bảo trợ xã hội, chúa, các cơ sở tôn giáo, thăm gia đình chính sách; gia đình có công với cách mạng; người giả neo đơn: gia đình có hoàn cảnh khó khăn...
- Dạy phụ đạo về ngôn ngữ, nghệ thuật cho học sinh, sinh viên trong trường, ngoài cộng đồng, các điểm chùa...
- Tham gia giúp đỡ công đoàn viên có hoàn cảnh khó khăn.
- Báo cáo, nói chuyện chuyên đề liên quan đến tâm lý cho các trường học, đoàn thể, ban ngành.', 20, CAST(N'2023-12-25T00:00:00.000' AS DateTime), CAST(N'2023-12-25T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Danh sách giảng viên.
- Giấy xác nhận tham gia của đơn vị
- Công lệnh.
- Giấy mời.
- Bằng khen
- Giấy khen
- Giấy xác nhận của tổ công đoàn')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD11', N'- Tham các cuộc vận động đóng góp phát động của Nhà trường', 20, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Năm', N'- Các thông báo đóng góp trừ vào lương')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD12', N'- Kết hợp với các Đài truyền hình truyền thông để quảng bá hình ảnh của Trường Đại học Trà Vinh, thực hiện viết bài đăng trên bản tin của Trường; Bản tin của khoa; Quản lý fanpage, viết bài đăng fanpage', 30, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Bản tin trường', N'- Văn bản phê duyệt cho phép phát ngôn.....
- Link bài viết; Bài viết in từ website TVU
- Bản tin của khoa
- Email xác nhận thông tin.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD14', N'- Được các tổ chức, cơ quan bên ngoài trường ghi nhận thành tích đóng góp của cá nhân.', 60, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'Quyết định
- Giấy khen
- Chứng nhận
- Thư cảm ơn')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD15', N'- Đề xuất áp dụng mô hình/giải pháp sẵn có và được ứng dụng tại Trường Đại học Trà Vinh mang lại hiệu quả thiết thực', 30, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Mô hình / Giải pháp', N'- Quyết định công nhận
- Thông báo')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD4', N'- Tham gia các chương trình các dự án của các tổ chức để huy động nguồn lực địa phương nhằm phát triển kinh tế xã hội địa phương', 30, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định.
- Kế hoạch
- Danh sách xác nhận của đơn vị.
- Bản thuyết minh được cơ quan có thẩm quyền duyệt 
- Hợp đồng được ký kết với đối tác')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD13', N'- Kết hợp với các Đài truyền hình truyền thông để quảng bá hình ảnh của Trường Đại học Trà Vinh, thực hiện viết bài đăng trên bản tin của Trường; Bản tin của khoa; Quản lý fanpage, viết bài đăng fanpage', 15, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Bản tin khoa', N'- Văn bản phê duyệt cho phép phát ngôn.....
- Link bài viết; Bài viết in từ website TVU
- Bản tin của khoa
- Email xác nhận thông tin.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD16', N'- Tham gia Chỉ ủy Chi bộ trở lên và BCH các tổ chức đoàn thể (bao gồm tổ chức CĐCS trường ĐHTV)', 20, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Quyết định', N'- Quyết định (chuẩn y, công nhận)
- Danh sách giảng viên')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD17', N'- Tham gia công tác ISO tại đơn vị', 20, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Giảng viên', N'- Quyết định
- Danh sách xác nhận của đơn vị')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD19', N'- Hướng dẫn sinh viên/học sinh tham gia các hội thi về khoa học kỹ thuật cấp tỉnh trở lên', 15, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Kế hoạch
- Quyết định
- Danh sách giảng viên.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD20', N'- Cải tiến quy trình, sáng kiến kinh nghiệm thực hiện công việc (gồm xây dựng mới và cập nhật, chỉnh sửa)', 15, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quy trình / Sáng kiến được công nhận từ cấp Khoa trở lên.')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD21', N'- Tham gia cuộc thi học thuật của học sinh, sinh viên (cố vấn, hướng dẫn và giám khảo) từ cấp Khoa, Trường', 15, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Danh sách')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD22', N'- Tham gia công tác kiểm định của đơn vị (viết báo cáo chuyên đề, Báo cáo chuyên đề)', 15, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Giảng viên', N'- Quyết định
- Kế hoạch
- Danh sách')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD23', N'- Tham gia công tác kiểm định của đơn vị (Trả lời phỏng vấn)', 30, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Giảng viên', N'- Quyết định
- Kế hoạch
- Danh sách')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD24', N'- Tham gia công tác tổ chức, bảo cáo chuyên môn các hội thảo, hội nghị, Tọa đàm, hội thi của Khoa, Trường (Ban tổ chức, phản biện, báo cáo viên, thư ký)', 15, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Danh sách phân công phân biện
- Thư mời')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD25', N'- Tham gia Ban chủ nhiệm, Ban cố vấn các câu lạc bộ của Khoa, Trường', 15, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Giảng viên', N'- Quyết định
- Kế hoạch
- Danh sách')
INSERT [dbo].[HOATDONG] ([IDHD], [TenHD], [SoGioQuyDinh], [NgayBatDau], [NgayKetThuc], [DonViTinh], [MinhChung]) VALUES (N'HD18', N'- Hỗ trợ các chuyên gia; tình nguyện viên trong, ngoài nước tham gia các hoạt động vì cộng đồng.', 20, CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2024-05-31T00:00:00.000' AS DateTime), N'Lần ', N'- Quyết định
- Kế hoạch
- Danh sách xác nhận của đơn vị')
GO
SET IDENTITY_INSERT [dbo].[MINHCHUNG] ON 

INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (139, N'HD14', N'GV4', N'dpd', 155, -5, N'https://drive.google.com/file/d/1bS6bLvge4WWFdnpw92Y8P6f3GGKMTdjo/view', CAST(N'2024-01-08T21:00:18.923' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (140, N'HD3', N'GV4', N'dpd', 155, -5, N'https://drive.google.com/file/d/1GbdNq91PqqrD_MZKv97HCxkxO10eYRNc/view', CAST(N'2024-01-08T21:00:32.193' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (141, N'HD5', N'GV4', N'dpd', 155, -5, N'https://drive.google.com/file/d/1Qguh7pHtzyhtaTV5kmL5_UvJycMsP0Ei/view', CAST(N'2024-01-08T21:00:41.483' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (142, N'HD20', N'GV4', N'dpd', 155, -5, N'https://drive.google.com/file/d/1OwY76cPAnp-3RprkM0iRQ9rj_IbGgE3z/view', CAST(N'2024-01-08T21:00:55.630' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (147, N'HD14', N'GV1', N'dpd', 160, -10, N'https://drive.google.com/file/d/1k8nTx9f6GEQu1rFMogdurct_wUcgQgtu/view', CAST(N'2024-01-08T21:04:43.113' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (148, N'HD3', N'GV1', N'dpd', 160, -10, N'https://drive.google.com/file/d/17_RkdFmNsRDma7krYGRKhPaYyUmABDuO/view', CAST(N'2024-01-08T21:05:10.913' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (149, N'HD5', N'GV1', N'dpd', 160, -10, N'https://drive.google.com/file/d/1Hwj9hTsaWfIgfgZQi99BAhj2VuFq34fF/view', CAST(N'2024-01-08T21:05:22.063' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (150, N'HD6', N'GV1', N'dpd', 160, -10, N'https://drive.google.com/file/d/10GjdXWkermgIbRwmt_o7DX0yPCxEUkW2/view', CAST(N'2024-01-08T21:05:30.207' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (151, N'HD14', N'GV5', N'dpd', 155, -5, N'https://drive.google.com/file/d/1GfdIJwpHVsTnpRh85PVnmB8YhjCC7EoD/view', CAST(N'2024-01-08T21:06:04.760' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (152, N'HD5', N'GV5', N'dpd', 155, -5, N'https://drive.google.com/file/d/1bFWS_FfpZW5sJS9HaqyPvVThxEXWmPmK/view', CAST(N'2024-01-08T21:06:16.707' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (153, N'HD3', N'GV5', N'dpd', 155, -5, N'https://drive.google.com/file/d/1OnJZvcwTHQj3TInSDiWJ7468eMjE_XpG/view', CAST(N'2024-01-08T21:06:25.350' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (154, N'HD13', N'GV5', N'dpd', 155, -5, N'https://drive.google.com/file/d/1inXjKoStz_P-qRAg-e3OO4u96TRne4CN/view', CAST(N'2024-01-08T21:06:37.753' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (155, N'HD14', N'GV16', N'dpd', 150, 0, N'https://drive.google.com/file/d/167akjIBKO_7Igk22R6RmmrZysMNyc9vV/view', CAST(N'2024-01-08T21:07:02.117' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (156, N'HD1', N'GV16', N'dpd', 150, 0, N'https://drive.google.com/file/d/1aMv2A0p1Vnq2YlViC-Xe8_UJXspQHmbX/view', CAST(N'2024-01-08T21:07:19.347' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (157, N'HD9', N'GV16', N'dpd', 150, 0, N'https://drive.google.com/file/d/1ejV6VVzZL1qqr6nw9O0imECdUICSNcHZ/view', CAST(N'2024-01-08T21:07:28.133' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (158, N'HD1', N'GV16', N'dpd', 150, 0, N'https://drive.google.com/file/d/1F_idN6rfHDsnqYvJ45w8rQhAb1nEiLcO/view', CAST(N'2024-01-08T21:08:10.420' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (159, N'HD14', N'GV40', N'dpd', 150, 0, N'https://drive.google.com/file/d/1bsnzeEXK9n7onII_hkUnW8yfkVGZP0eD/view', CAST(N'2024-01-08T21:09:15.653' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (160, N'HD1', N'GV40', N'dpd', 150, 0, N'https://drive.google.com/file/d/1kqtcF_0fPlnxcdiAyf2Cep6-30N4l-iF/view', CAST(N'2024-01-08T21:09:41.487' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (161, N'HD2', N'GV40', N'dpd', 150, 0, N'https://drive.google.com/file/d/1o2aWev6eStd22Cen_DXzI5rcwVe3aebm/view', CAST(N'2024-01-08T21:09:51.723' AS DateTime))
INSERT [dbo].[MINHCHUNG] ([IDMC], [IDHD], [IDGV], [IDTT], [SoGioDaHoanThanh], [SoGioConLai], [LoaiMinhChung], [NgayCapNhat]) VALUES (162, N'HD9', N'GV40', N'dpd', 150, 0, N'https://drive.google.com/file/d/1LmmBi2aRjzI-m1rwC87bIT1S1lrYO3iR/view', CAST(N'2024-01-08T21:10:00.557' AS DateTime))
SET IDENTITY_INSERT [dbo].[MINHCHUNG] OFF
GO
INSERT [dbo].[QUYENTRUYCAP] ([IDQTC], [TenQTC]) VALUES (N'admin', N'Quản trị viên')
INSERT [dbo].[QUYENTRUYCAP] ([IDQTC], [TenQTC]) VALUES (N'user', N'Người dùng')
GO
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV19', N'GV19', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV1', N'GV1', N'admin', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV10', N'GV10', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV11', N'GV11', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV12', N'GV12', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV13', N'GV13', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV14', N'GV14', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV15', N'GV15', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV17', N'GV17', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV20', N'GV20', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV21', N'GV21', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV22', N'GV22', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV23', N'GV23', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV24', N'GV24', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV25', N'GV25', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV4', N'GV4', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV5', N'GV5', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV6', N'GV6', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV7', N'GV7', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV8', N'GV8', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV3', N'GV3', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV9', N'GV9', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV26', N'GV26', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV18', N'GV18', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV16', N'GV16', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[TAIKHOAN] ([Username], [IDGV], [IDQTC], [Password]) VALUES (N'GV40', N'GV40', N'user', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
GO
INSERT [dbo].[TRANGTHAI] ([IDTT], [TenTT]) VALUES (N'cpd', N'Chờ phê duyệt')
INSERT [dbo].[TRANGTHAI] ([IDTT], [TenTT]) VALUES (N'dpd', N'Đã phê duyệt')
INSERT [dbo].[TRANGTHAI] ([IDTT], [TenTT]) VALUES (N'khl', N'Không hợp lệ')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_GIANGVIEN]    Script Date: 1/8/2024 10:10:00 PM ******/
ALTER TABLE [dbo].[GIANGVIEN] ADD  CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY NONCLUSTERED 
(
	[IDGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_HOATDONG]    Script Date: 1/8/2024 10:10:00 PM ******/
ALTER TABLE [dbo].[HOATDONG] ADD  CONSTRAINT [PK_HOATDONG] PRIMARY KEY NONCLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [minhchung1_FK]    Script Date: 1/8/2024 10:10:00 PM ******/
CREATE NONCLUSTERED INDEX [minhchung1_FK] ON [dbo].[MINHCHUNG]
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [minhchung2_FK]    Script Date: 1/8/2024 10:10:00 PM ******/
CREATE NONCLUSTERED INDEX [minhchung2_FK] ON [dbo].[MINHCHUNG]
(
	[IDGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [minhchung3_FK]    Script Date: 1/8/2024 10:10:00 PM ******/
CREATE NONCLUSTERED INDEX [minhchung3_FK] ON [dbo].[MINHCHUNG]
(
	[IDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_QUYENTRUYCAP]    Script Date: 1/8/2024 10:10:00 PM ******/
ALTER TABLE [dbo].[QUYENTRUYCAP] ADD  CONSTRAINT [PK_QUYENTRUYCAP] PRIMARY KEY NONCLUSTERED 
(
	[IDQTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_TAIKHOAN]    Script Date: 1/8/2024 10:10:00 PM ******/
ALTER TABLE [dbo].[TAIKHOAN] ADD  CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [taikhoan_giangvien2_FK]    Script Date: 1/8/2024 10:10:00 PM ******/
CREATE NONCLUSTERED INDEX [taikhoan_giangvien2_FK] ON [dbo].[TAIKHOAN]
(
	[IDGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [thuocquyen_FK]    Script Date: 1/8/2024 10:10:00 PM ******/
CREATE NONCLUSTERED INDEX [thuocquyen_FK] ON [dbo].[TAIKHOAN]
(
	[IDQTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_TRANGTHAIHOATDONG]    Script Date: 1/8/2024 10:10:00 PM ******/
ALTER TABLE [dbo].[TRANGTHAI] ADD  CONSTRAINT [PK_TRANGTHAIHOATDONG] PRIMARY KEY NONCLUSTERED 
(
	[IDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MINHCHUNG]  WITH CHECK ADD  CONSTRAINT [FK_MINHCHUNG_GIANGVIEN] FOREIGN KEY([IDGV])
REFERENCES [dbo].[GIANGVIEN] ([IDGV])
GO
ALTER TABLE [dbo].[MINHCHUNG] CHECK CONSTRAINT [FK_MINHCHUNG_GIANGVIEN]
GO
ALTER TABLE [dbo].[MINHCHUNG]  WITH CHECK ADD  CONSTRAINT [FK_MINHCHUNG_HOATDONG] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HOATDONG] ([IDHD])
GO
ALTER TABLE [dbo].[MINHCHUNG] CHECK CONSTRAINT [FK_MINHCHUNG_HOATDONG]
GO
ALTER TABLE [dbo].[MINHCHUNG]  WITH CHECK ADD  CONSTRAINT [FK_MINHCHUNG_TRANGTHAI] FOREIGN KEY([IDTT])
REFERENCES [dbo].[TRANGTHAI] ([IDTT])
GO
ALTER TABLE [dbo].[MINHCHUNG] CHECK CONSTRAINT [FK_MINHCHUNG_TRANGTHAI]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_TAIKHOANC_QUYENTRU] FOREIGN KEY([IDQTC])
REFERENCES [dbo].[QUYENTRUYCAP] ([IDQTC])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_TAIKHOANC_QUYENTRU]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_TAIKHOANG_GIANGVIE] FOREIGN KEY([IDGV])
REFERENCES [dbo].[GIANGVIEN] ([IDGV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_TAIKHOANG_GIANGVIE]
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeGiangVien]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThongKeGiangVien]
AS
BEGIN
  SELECT gv.HoTen, 
		 gv.BoMon, 
         gv.GioChuan,
         ISNULL(Max(mc.SoGioDaHoanThanh), 0) AS SoGioDaHoanThanh,  
         ISNULL(Max(mc.SoGioDaHoanThanh), 0) - gv.GioChuan AS TongGioVuot
    FROM GiangVien gv 
    LEFT JOIN MinhChung mc ON gv.IDGV = mc.IDGV
   GROUP BY  gv.IDGV, gv.HoTen, gv.BoMon, gv.GioChuan
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeTheoBoMon]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThongKeTheoBoMon]
    @NgayBatDau datetime,
    @NgayKetThuc datetime,
    @BoMon nvarchar(100)
AS
BEGIN
	SELECT 
		gv.HoTen, 
        gv.BoMon, 
        gv.GioChuan,
        ISNULL(MAX(mc.SoGioDaHoanThanh), 0) AS SoGioDaHoanThanh,  
        ISNULL(MAX(mc.SoGioDaHoanThanh), 0) - gv.GioChuan AS TongGioVuot
    FROM 
        GiangVien gv 
        LEFT JOIN 
        MinhChung mc ON gv.IDGV = mc.IDGV
        AND mc.NgayCapNhat BETWEEN @NgayBatDau AND @NgayKetThuc
    WHERE 
        gv.BoMon like @BoMon -- Lọc theo bộ môn
    GROUP BY 
        gv.IDGV, gv.HoTen, gv.BoMon, gv.GioChuan
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeTheoNamHoc]    Script Date: 1/8/2024 10:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThongKeTheoNamHoc]
@NgayBatDau datetime,
@NgayKetThuc datetime,
@LocAmDuong int -- Tham số để lọc âm (-1), dương (1), hoặc không lọc (0)
AS
BEGIN
	SELECT gv.HoTen, 
         gv.GioChuan,
         ISNULL(MAX(mc.SoGioDaHoanThanh), 0) AS SoGioDaHoanThanh,  
         ISNULL(MAX(mc.SoGioDaHoanThanh), 0) - gv.GioChuan AS TongGioVuot
	FROM GiangVien gv 
    LEFT JOIN MinhChung mc ON gv.IDGV = mc.IDGV
                           AND mc.NgayCapNhat BETWEEN @NgayBatDau AND @NgayKetThuc
	GROUP BY gv.IDGV, gv.HoTen, gv.GioChuan
	HAVING 
    (
       (@LocAmDuong = -1 AND ISNULL(MAX(mc.SoGioDaHoanThanh), 0) - gv.GioChuan < 0) -- Lọc TongGioVuot âm nếu @LocAmDuong = -1
       OR 
       (@LocAmDuong = 1 AND ISNULL(MAX(mc.SoGioDaHoanThanh), 0) - gv.GioChuan >= 0) -- Lọc TongGioVuot dương nếu @LocAmDuong = 1
       OR
       (@LocAmDuong = 0) -- Không lọc nếu @LocAmDuong = 0
    )
END
GO
USE [master]
GO
ALTER DATABASE [HTQUANLYGIOPVCD] SET  READ_WRITE 
GO
