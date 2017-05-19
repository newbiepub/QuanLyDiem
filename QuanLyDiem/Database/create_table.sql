
-----------------------------------------------------------------Quản lý điểm--------------------------------------------	

--Bảng Điểm
Go
CREATE TABLE [dbo].[DIEM] (
    [MaHocSinh]  BIGINT         NOT NULL,
    [MaMon]      BIGINT         NOT NULL,
    [DiemMieng]  INT            DEFAULT ((0)) NULL,
    [DiemGiuaKy] INT            DEFAULT ((0)) NULL,
    [DiemHocKy]  INT            DEFAULT ((0)) NULL,
    [HocKy]      NCHAR (10)     NOT NULL,
    [NamHoc]     DATETIME       NOT NULL,
    [GhiChu]     NVARCHAR (MAX) NULL,
    CONSTRAINT [FK_DIEM_ToTable] FOREIGN KEY ([MaHocSinh]) REFERENCES [dbo].[HOC_SINH] ([MaHocSinh]),
    CONSTRAINT [FK_DIEM_ToTable_2] FOREIGN KEY ([MaMon]) REFERENCES [dbo].[MON_HOC] ([MaMon]),
    CHECK ([DiemMieng]>=(0) AND [DiemMieng]<=(10)),
    CHECK ([DiemGiuaKy]>=(0) AND [DiemGiuaKy]<=(10)),
    CHECK ([DiemHocKy]>=(0) AND [DiemHocKy]<=(10))
);

--Bảng Đăng Nhập
GO
CREATE TABLE [dbo].[DANG_NHAP] (
    [ID]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [TenDangNhap] NVARCHAR (50)  NOT NULL,
    [MatKhau]     NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_DANG_NHAP] PRIMARY KEY CLUSTERED ([ID] ASC)
);

--Bảng Dạy
Go
CREATE TABLE [dbo].[DAY] (
    [MaMon]  BIGINT         NOT NULL,
    [MaGV]   BIGINT         NOT NULL,
    [GhiChu] NVARCHAR (MAX) NULL,
    [MaLop]  BIGINT         NOT NULL,
    CONSTRAINT [FK_DAY_ToTable] FOREIGN KEY ([MaMon]) REFERENCES [dbo].[MON_HOC] ([MaMon]),
    CONSTRAINT [FK_DAY_ToTable_1] FOREIGN KEY ([MaGV]) REFERENCES [dbo].[GIAO_VIEN] ([MaGiaoVien]),
    CONSTRAINT [FK_DAY_ToTable_2] FOREIGN KEY ([MaLop]) REFERENCES [dbo].[LOP] ([MaLop])
);

---- Nhap Lieu
INSERT INTO [dbo].[DAY] ([MaMon], [MaGV], [GhiChu], [MaLop]) VALUES (2, 8, NULL, 1)
INSERT INTO [dbo].[DAY] ([MaMon], [MaGV], [GhiChu], [MaLop]) VALUES (3, 9, NULL, 2)
INSERT INTO [dbo].[DAY] ([MaMon], [MaGV], [GhiChu], [MaLop]) VALUES (4, 10, NULL, 3)


--Bảng Giáo Viên
Go
CREATE TABLE [dbo].[GIAO_VIEN] (
    [MaGiaoVien]  BIGINT         IDENTITY (1, 1) NOT NULL,
    [TenGiaoVien] NVARCHAR (MAX) NOT NULL,
    [NgaySinh]    DATE           NOT NULL,
    [GioiTinh]    INT            NOT NULL,
    [SoDienThoai] NVARCHAR (11)  NULL,
    [DiaChi]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_GIAO_VIEN] PRIMARY KEY CLUSTERED ([MaGiaoVien] ASC)
);

--Nhap Lieu
SET IDENTITY_INSERT [dbo].[GIAO_VIEN] ON
INSERT INTO [dbo].[GIAO_VIEN] ([MaGiaoVien], [TenGiaoVien], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi]) VALUES (8, N'Nguyễn Văn A', N'1990-12-23', 1, N'01282066864', N'16 Lê Duẩn')
INSERT INTO [dbo].[GIAO_VIEN] ([MaGiaoVien], [TenGiaoVien], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi]) VALUES (9, N'Nguyen B', N'2011-02-02', 0, NULL, NULL)
INSERT INTO [dbo].[GIAO_VIEN] ([MaGiaoVien], [TenGiaoVien], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi]) VALUES (10, N'Nguyen  lê AB', N'2011-02-02', 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[GIAO_VIEN] OFF

--Bảng Khối
Go
CREATE TABLE [dbo].[KHOI] (
    [khoiId] BIGINT     IDENTITY (1, 1) NOT NULL,
    [Khoi]   NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([khoiId] ASC)
);
--Nhap Lieu
SET IDENTITY_INSERT [dbo].[KHOI] ON
INSERT INTO [dbo].[KHOI] ([khoiId], [Khoi]) VALUES (1, N'1')
INSERT INTO [dbo].[KHOI] ([khoiId], [Khoi]) VALUES (2, N'2')
INSERT INTO [dbo].[KHOI] ([khoiId], [Khoi]) VALUES (3, N'3')
INSERT INTO [dbo].[KHOI] ([khoiId], [Khoi]) VALUES (4, N'4')
INSERT INTO [dbo].[KHOI] ([khoiId], [Khoi]) VALUES (5, N'5')
SET IDENTITY_INSERT [dbo].[KHOI] OFF

--Bảng Lớp
Go
CREATE TABLE [dbo].[LOP] (
    [MaLop]  BIGINT         IDENTITY (1, 1) NOT NULL,
    [TenLop] NVARCHAR (50)  NOT NULL,
    [Khoi]   BIGINT         NOT NULL,
    [GhiChu] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED ([MaLop] ASC)
);
--Nhap Lieu
SET IDENTITY_INSERT [dbo].[LOP] ON
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (1, N'A', 1, N'Lop 1A')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (2, N'B', 1, N'Lop 1B')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (3, N'A', 2, N'Lop 2A')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (4, N'B', 2, N'Lop 2B')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (6, N'A', 3, N'Lop 3A')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (7, N'B', 3, N'Lop3B')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (8, N'A', 4, N'Lop4A')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (9, N'B', 4, N'Lop4B')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (10, N'A', 5, N'Lop5A')
INSERT INTO [dbo].[LOP] ([MaLop], [TenLop], [Khoi], [GhiChu]) VALUES (11, N'B', 5, N'Lop5B')
SET IDENTITY_INSERT [dbo].[LOP] OFF


--Bảng Học Sinh
Go
CREATE TABLE [dbo].[HOC_SINH] (
    [MaHocSinh]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [TenHocSinh]    NVARCHAR (80)  NOT NULL,
    [NgaySinh]      DATE           NOT NULL,
    [DiaChi]        NVARCHAR (150) NULL,
    [MaLop]         BIGINT         NOT NULL,
    [GioiTinh]      INT            NOT NULL,
    [DiemTrungBinh] FLOAT (53)     NULL,
    [XepLoai]       NVARCHAR (20)  NULL,
    CONSTRAINT [PK_HOC_SINH] PRIMARY KEY CLUSTERED ([MaHocSinh] ASC),
    CONSTRAINT [FK_HOC_SINH_ToTable] FOREIGN KEY ([MaLop]) REFERENCES [dbo].[LOP] ([MaLop])
);
--Nhap Lieu
SET IDENTITY_INSERT [dbo].[HOC_SINH] ON
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (1, N'Nguyen Hong Lam', N'2012-12-12', N'K43/59 Le Huu Trac', 1, 1, 8.11111111111111, N'Gioi')
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (2, N'Nguyen Van B', N'2012-12-12', N'K43/59 Le Huu Trac', 2, 1, 5, N'Trung Binh')
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (3, N'Nguyen Van A', N'2012-12-12', N'K43/59 Le Huu Trac', 3, 1, 8, N'Gioi')
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (4, N'Nguyen Van C', N'2012-12-12', N'K61/8 Tran Khanh Du', 4, 1, NULL, NULL)
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (9, N'Nguyen Van D', N'2012-12-12', N'K61/82 An Cu', 6, 1, NULL, NULL)
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (11, N'Nguyen Van E', N'2012-12-12', N'K62/12 An Hiep', 7, 0, NULL, NULL)
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (12, N'Nguyen Van F', N'2014-01-12', N'K54/51 Le Duan', 8, 0, NULL, NULL)
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (13, N'Nguyen Van Cu', N'2012-01-12', N'65 Nguyen Van Cu', 9, 1, NULL, NULL)
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (14, N'Van Mai Huong ', N'2012-11-20', N'54 Nguyen Luong Bang', 10, 0, NULL, NULL)
INSERT INTO [dbo].[HOC_SINH] ([MaHocSinh], [TenHocSinh], [NgaySinh], [DiaChi], [MaLop], [GioiTinh], [DiemTrungBinh], [XepLoai]) VALUES (15, N'Nguyen Buu ', N'2012-12-22', N'193 Nguyen Luong Bang', 11, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[HOC_SINH] OFF


-- Bảng Môn Học
Go
CREATE TABLE [dbo].[MON_HOC] (
    [MaMon]  BIGINT        IDENTITY (1, 1) NOT NULL,
    [TenMon] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MON_HOC] PRIMARY KEY CLUSTERED ([MaMon] ASC)
);
--Nhap Lieu
SET IDENTITY_INSERT [dbo].[MON_HOC] ON
INSERT INTO [dbo].[MON_HOC] ([MaMon], [TenMon]) VALUES (2, N'Toán')
INSERT INTO [dbo].[MON_HOC] ([MaMon], [TenMon]) VALUES (3, N'Lý')
INSERT INTO [dbo].[MON_HOC] ([MaMon], [TenMon]) VALUES (4, N'Hóa')
INSERT INTO [dbo].[MON_HOC] ([MaMon], [TenMon]) VALUES (5, N'Văn')
SET IDENTITY_INSERT [dbo].[MON_HOC] OFF