
create database QLGPVCD
go

use QLGPVCD
go

/*==============================================================*/
/* Table: GIANGVIEN                                             */
/*==============================================================*/
create table GIANGVIEN (
   IDGV                 varchar(10)             not null,
   HoTen                nvarchar(30)             not null,
   GioiTinh             nvarchar(10)             not null,
   HocVi                nvarchar(30)             not null,
   ChucVu               nvarchar(30)             not null,
   Email                varchar(30)             not null,
   SoDienThoai          varchar(10)             not null,
   Bomon                nvarchar(30)             not null,
   constraint PK_GIANGVIEN primary key nonclustered (IDGV)
)
go

/*==============================================================*/
/* Table: HOATDONG                                              */
/*==============================================================*/
create table HOATDONG (
   IDHD                 varchar(10)             not null,
   TenHD                nvarchar(2000)           not null,
   SoGioQuyDinh         int                  not null,
   NgayBatDau           date             not null,
   NgayKetThuc          date             not null,
   DonViTinh            nvarchar(30)             not null,
  
   constraint PK_HOATDONG primary key nonclustered (IDHD)
)
go

/*==============================================================*/
/* Table: HOATDONGDANGKY                                        */
/*==============================================================*/
create table HOATDONGDANGKY (
   IDHDDK               varchar(10)             not null,
   IDHD                 varchar(10)             not null,
   IDGV                 varchar(10)             not null,
   IDTT                 varchar(10)             not null,
   SoGioDaHoanThanh     int                  not null,
   SoGioConLai          int                  not null,
   NgayDangKy           date             not null,
   constraint PK_HOATDONGDANGKY primary key (IDHD, IDGV, IDTT, IDHDDK)
)
go

/*==============================================================*/
/* Table: MINHCHUNG                                             */
/*==============================================================*/
create table MINHCHUNG (
   IDMinhChung          varchar(10)             not null,
   IDHD                 varchar(10)             not null,
   IDGV                 varchar(10)             not null,
   TenMinhChung         nvarchar(200)            not null,
   NgayCapNhat          date             not null,
   constraint PK_MINHCHUNG primary key nonclustered (IDMinhChung)
)
go

/*==============================================================*/
/* Table: QUYENTRUYCAP                                          */
/*==============================================================*/
create table QUYENTRUYCAP (
   IDQTC                varchar(10)             not null,
   TenQTC               nvarchar(30)             not null,
   constraint PK_QUYENTRUYCAP primary key nonclustered (IDQTC)
)
go

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN (
   Username             varchar(10)             not null,
   IDGV                 varchar(10)             not null,
   IDQTC                varchar(10)             not null,
   Password             varchar(100)             not null,
   constraint PK_TAIKHOAN primary key nonclustered (Username)
)
go

/*==============================================================*/
/* Table: TRANGTHAI                                             */
/*==============================================================*/
create table TRANGTHAI (
   IDTT                 varchar(10)             not null,
   TenTT                nvarchar(30)            not null,
   constraint PK_TRANGTHAI primary key nonclustered (IDTT)
)
go

/*==============================================================*/
/* Index: hoatdongdangky_FK                                     */
/*==============================================================*/
create index hoatdongdangky_FK on HOATDONGDANGKY (
IDHD ASC
)
go

/*==============================================================*/
/* Index: hoatdongdangky3_FK                                    */
/*==============================================================*/
create index hoatdongdangky3_FK on HOATDONGDANGKY (
IDGV ASC
)
go

/*==============================================================*/
/* Index: hoatdongdangky5_FK                                    */
/*==============================================================*/
create index hoatdongdangky5_FK on HOATDONGDANGKY (
IDTT ASC
)
go



/*==============================================================*/
/* Index: Capnhatminhchung_FK                                   */
/*==============================================================*/
create index Capnhatminhchung_FK on MINHCHUNG (
IDGV ASC
)
go

/*==============================================================*/
/* Index: Hoatdong_minhchung_FK                                 */
/*==============================================================*/
create index Hoatdong_minhchung_FK on MINHCHUNG (
IDHD ASC
)
go



/*==============================================================*/
/* Index: thuocquyen_FK                                         */
/*==============================================================*/
create index thuocquyen_FK on TAIKHOAN (
IDQTC ASC
)
go

/*==============================================================*/
/* Index: taikhoan_giangvien2_FK                                */
/*==============================================================*/
create index taikhoan_giangvien2_FK on TAIKHOAN (
IDGV ASC
)
go



alter table HOATDONGDANGKY
   add constraint FK_HOATDONG_HOATDONGD_HOATDONG foreign key (IDHD)
      references HOATDONG (IDHD)
go

alter table HOATDONGDANGKY
   add constraint FK_HOATDONG_HOATDONGD_GIANGVIE foreign key (IDGV)
      references GIANGVIEN (IDGV)
go

alter table HOATDONGDANGKY
   add constraint FK_HOATDONG_HOATDONGD_TRANGTHA foreign key (IDTT)
      references TRANGTHAI (IDTT)
go

alter table MINHCHUNG
   add constraint FK_MINHCHUN_CAPNHATMI_GIANGVIE foreign key (IDGV)
      references GIANGVIEN (IDGV)
go

alter table MINHCHUNG
   add constraint FK_MINHCHUN_HOATDONGM_HOATDONG foreign key (IDHD)
      references HOATDONG (IDHD)
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_TAIKHOANC_QUYENTRU foreign key (IDQTC)
      references QUYENTRUYCAP (IDQTC)
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_TAIKHOANG_GIANGVIE foreign key (IDGV)
      references GIANGVIEN (IDGV)
go

