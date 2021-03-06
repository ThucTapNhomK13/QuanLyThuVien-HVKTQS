USE [master]
GO
/****** Object:  Database [QuanLyThuVienHVKTQS]    Script Date: 12-May-17 7:59:54 AM ******/
CREATE DATABASE [QuanLyThuVienHVKTQS]
GO
USE [QuanLyThuVienHVKTQS]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 12-May-17 7:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[tenkho] [nvarchar](200) NOT NULL,
	[vitri] [nvarchar](200) NOT NULL,
 CONSTRAINT [pk_kho] PRIMARY KEY CLUSTERED 
(
	[tenkho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 12-May-17 7:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[loaisach] [nvarchar](256) NULL,
	[idKho] [nvarchar](200) NULL,
	[soluong] [int] NULL,
 CONSTRAINT [pk_loaisach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MuonTra]    Script Date: 12-May-17 7:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MuonTra](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ngaymuon] [datetime] NULL DEFAULT (getdate()),
	[hanmuon] [datetime] NULL,
	[ngaytra] [datetime] NULL,
	[idnhansu] [int] NULL,
	[idthethuvien] [int] NULL,
	[idsach] [varchar](12) NULL,
 CONSTRAINT [pk_muontra] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanSu]    Script Date: 12-May-17 7:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanSu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](200) NOT NULL,
	[ngaysinh] [datetime] NULL,
	[anhdaidien] [varchar](max) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[taikhoan] [varchar](200) NULL,
	[matkhau] [varchar](200) NULL,
	[quanly] [int] NULL,
 CONSTRAINT [pk_nhansu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12-May-17 7:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tensach] [nvarchar](200) NOT NULL,
	[idloaisach] [int] NULL,
	[noibo] [int] NULL,
	[masach] [varchar](12) NULL,
	[tacgia] [nvarchar](100) NULL,
	[gioithieu] [nvarchar](max) NULL,
	[trangthai] [nvarchar](12) NULL,
 CONSTRAINT [pk_sach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 12-May-17 7:59:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheThuVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](200) NOT NULL,
	[ngaysinh] [datetime] NULL,
	[anhdaidien] [varchar](max) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[loaithe] [int] NULL,
 CONSTRAINT [pk_thethuvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 1', N'Nhà H2 tầng 1 phòng 1')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 2', N'Nhà H2 Tầng 1 phòng 3')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 3', N'Nhà H2 tầng 2 phòng 2')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 4', N'Nhà H3 tầng 4 phòng 1')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 5', N'Nhà H2 tầng 1 phòng 2')
SET IDENTITY_INSERT [dbo].[LoaiSach] ON 

INSERT [dbo].[LoaiSach] ([id], [loaisach], [idKho], [soluong]) VALUES (1, N'Công nghệ thông tin', NULL, 1000)
INSERT [dbo].[LoaiSach] ([id], [loaisach], [idKho], [soluong]) VALUES (2, N'Công nghệ hóa học', NULL, 500)
INSERT [dbo].[LoaiSach] ([id], [loaisach], [idKho], [soluong]) VALUES (3, N'Điện tử', NULL, 500)
INSERT [dbo].[LoaiSach] ([id], [loaisach], [idKho], [soluong]) VALUES (4, N'Lập trình cơ bản', NULL, 200)
INSERT [dbo].[LoaiSach] ([id], [loaisach], [idKho], [soluong]) VALUES (5, N'Quốc phòng cơ bản', NULL, 3000)
INSERT [dbo].[LoaiSach] ([id], [loaisach], [idKho], [soluong]) VALUES (6, N'Phổ cập giáo dục', NULL, 3000)
SET IDENTITY_INSERT [dbo].[LoaiSach] OFF
SET IDENTITY_INSERT [dbo].[MuonTra] ON 

INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (1, CAST(N'2017-04-23 00:00:00.000' AS DateTime), CAST(N'2017-04-30 00:00:00.000' AS DateTime), NULL, 2, 13150028, N'1315001')
INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (2, CAST(N'2017-04-23 15:58:23.580' AS DateTime), CAST(N'2017-05-01 00:00:00.000' AS DateTime), CAST(N'2017-05-11 15:17:32.350' AS DateTime), 3, 14150028, N'1315001')
INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (3, CAST(N'2017-04-23 15:59:22.250' AS DateTime), CAST(N'2017-05-02 00:00:00.000' AS DateTime), NULL, 4, 14150072, N'1315001')
INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (4, CAST(N'2017-04-23 15:59:47.993' AS DateTime), CAST(N'2017-05-02 00:00:00.000' AS DateTime), NULL, 4, 14150072, N'1315001')
INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (5, CAST(N'2017-04-23 16:03:23.057' AS DateTime), CAST(N'2017-05-02 00:00:00.000' AS DateTime), NULL, 5, 14150072, N'1315001')
INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (6, CAST(N'2017-03-15 00:00:00.000' AS DateTime), CAST(N'2017-03-28 00:00:00.000' AS DateTime), CAST(N'2017-04-01 00:00:00.000' AS DateTime), 7, 14160023, N'1315002')
INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (7, CAST(N'2017-02-23 16:08:14.623' AS DateTime), CAST(N'2017-03-17 00:00:00.000' AS DateTime), CAST(N'2017-03-14 00:00:00.000' AS DateTime), 9, 14160023, N'1315002')
INSERT [dbo].[MuonTra] ([id], [ngaymuon], [hanmuon], [ngaytra], [idnhansu], [idthethuvien], [idsach]) VALUES (8, CAST(N'2017-04-23 17:12:43.647' AS DateTime), CAST(N'2017-04-30 16:35:01.000' AS DateTime), CAST(N'2017-04-24 15:22:41.060' AS DateTime), 8, 13150072, N'13150028')
SET IDENTITY_INSERT [dbo].[MuonTra] OFF
SET IDENTITY_INSERT [dbo].[NhanSu] ON 

INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (2, N'Vũ Hùng Cường', CAST(N'1996-11-11 00:00:00.000' AS DateTime), N'HungCuong.jpg', N'Nam', N'hungcuong', N'123456', 1)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (3, N'Vũ Lê Minh', CAST(N'1996-10-20 00:00:00.000' AS DateTime), N'LeMinh.jpg', N'Nam', N'leminh', N'123456', 1)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (4, N'Mai Tuấn Anh', CAST(N'1995-10-10 00:00:00.000' AS DateTime), N'AnhTuan.jpg', N'Nam', N'tuananh', N'123456', 0)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (5, N'Nguyễn Miên Anh', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'AnhNguyen.jpg', N'Nam', N'mienanh', N'123456', 0)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (7, N'Kim Thị Thùy Hương', CAST(N'1960-01-01 00:00:00.000' AS DateTime), N'ThuyHuong.jpg', N'Nữ', N'kimhuong', N'123456', 0)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (8, N'Nguyễn Thị Hoa', CAST(N'1980-04-14 00:00:00.000' AS DateTime), N'HoaNguyen.jpg', N'Nữ', N'nguyenhoa', N'123456', 0)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (9, N'Nguyễn Sơn Hà', CAST(N'1996-11-11 00:00:00.000' AS DateTime), N'SonHa.jpg', N'Nam', N'quochung', N'123456', 0)
SET IDENTITY_INSERT [dbo].[NhanSu] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (1, N'Mạng viễn thông', 1, 0, N'1315001', N'Nguyễn Tùng', NULL, N'Mới')
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (2, N'Phân tích thiết kế và giải thuật', 2, 1, N'1315002', N'Mạnh Quốc', N'Đệ quy, quy hoạch động, tìm kiếm, sắp xếp ... và nhiều thuật toán khác. Tìm hiểu thêm về trí thông minh nhân tạo', N'Mới')
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (3, N'Lập trình Java', 3, 0, N'1315003', N'Sơn Ca', NULL, N'Mới')
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (4, N'Vật lý đại cương 1', 4, 0, N'1315004', N'Lý Tứ', NULL, N'Mới')
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (5, N'Vật lý đại cương 2', 5, 0, N'1315005', N'Tam Gia', NULL, N'Mới')
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (12, N'Lập trình cơ bản', 1, 0, N'1315009', N'Lê Thuật', N'Giới thiệu cơ bản về ngôn ngữ lập trình C/C++', N'Mới nhập')
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (13, N'Mạng viễn thông', 1, 0, N'1315010', N'Nguyễn Tùng', N'Giới thiệu về mạng viễn thông hiện tại ', N'Mới nhập')
SET IDENTITY_INSERT [dbo].[Sach] OFF
SET IDENTITY_INSERT [dbo].[TheThuVien] ON 

INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (1, N'Nguyễn Miên Anh', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'mienanh', N'Nam', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (2, N'Nguyễn Văn Dũng ', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'nguyendung', N'Nam', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (3, N'Lê Bao Đồng', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'baodong', N'Nam', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (4, N'Kim Thị Thùy Hương', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'kimhuong', N'Nữ', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (5, N'Nguyễn Đăng Khôi', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'dangkhoi', N'Nam', 1)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (6, N'Lê Trường Sơn', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'truongson', N'Nam', 1)
SET IDENTITY_INSERT [dbo].[TheThuVien] OFF
USE [master]
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET  READ_WRITE 
GO
