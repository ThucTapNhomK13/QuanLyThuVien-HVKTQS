
/****** Object:  Database [QuanLyThuVienHVKTQS]    Script Date: 4/14/17 11:59:50 PM ******/
CREATE DATABASE [QuanLyThuVienHVKTQS]
GO

USE [QuanLyThuVienHVKTQS]
GO

/****** Object:  Table [dbo].[ChuDe]    Script Date: 4/14/17 11:59:51 PM ******/
CREATE TABLE [dbo].[ChuDe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenchude] [nvarchar](200) NOT NULL,
	[noibo] [int] NULL,
	[kho] [nvarchar](200) NULL,
 CONSTRAINT [pk_chude] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]    Script Date: 4/14/17 11:59:51 PM ******/
CREATE TABLE [dbo].[Kho](
	[tenkho] [nvarchar](200) NOT NULL,
	[vitri] [nvarchar](200) NOT NULL,
 CONSTRAINT [pk_kho] PRIMARY KEY CLUSTERED 
(
	[tenkho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 4/14/17 11:59:51 PM ******/
CREATE TABLE [dbo].[LoaiSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[soluong] [int] NULL,
	[idchude] [int] NULL,
 CONSTRAINT [pk_loaisach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MuonTra]    Script Date: 4/14/17 11:59:51 PM ******/
CREATE TABLE [dbo].[MuonTra](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ngaymuon] [datetime] NULL,
	[hanmuon] [datetime] NULL,
	[ngaytra] [datetime] NULL,
	[idnhansu] [int] NULL,
	[idthethuvien] [int] NULL,
 CONSTRAINT [pk_muontra] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanSu]    Script Date: 4/14/17 11:59:51 PM ******/
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
/****** Object:  Table [dbo].[Sach]    Script Date: 4/14/17 11:59:51 PM ******/
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
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 4/14/17 11:59:51 PM ******/
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
SET IDENTITY_INSERT [dbo].[ChuDe] ON 

INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (1, N'Khoa học', 0, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (2, N'Kỹ thuật', 0, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (3, N'Công nghệ', 0, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (4, N'Công nghệ phần mềm', 0, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (5, N'Hệ thống thông tin', 0, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (6, N'Sinh học', 0, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (7, N'Điện tử', 0, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (8, N'Vũ khí', 1, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (9, N'Xe quân sự', 1, NULL)
INSERT [dbo].[ChuDe] ([id], [tenchude], [noibo], [kho]) VALUES (10, N'Đạn dược', 1, NULL)
SET IDENTITY_INSERT [dbo].[ChuDe] OFF
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 1', N'Nhà H2 tầng 1 phòng 1')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 2', N'Nhà H2 Tầng 1 phòng 3')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 3', N'Nhà H2 tầng 2 phòng 2')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 4', N'Nhà H3 tầng 4 phòng 1')
INSERT [dbo].[Kho] ([tenkho], [vitri]) VALUES (N'Kho 5', N'Nhà H2 tầng 1 phòng 2')
SET IDENTITY_INSERT [dbo].[LoaiSach] ON 

INSERT [dbo].[LoaiSach] ([id], [soluong], [idchude]) VALUES (1, 200, 4)
INSERT [dbo].[LoaiSach] ([id], [soluong], [idchude]) VALUES (2, 300, 1)
INSERT [dbo].[LoaiSach] ([id], [soluong], [idchude]) VALUES (3, 300, 1)
INSERT [dbo].[LoaiSach] ([id], [soluong], [idchude]) VALUES (4, 800, 2)
INSERT [dbo].[LoaiSach] ([id], [soluong], [idchude]) VALUES (5, 800, 2)
INSERT [dbo].[LoaiSach] ([id], [soluong], [idchude]) VALUES (6, 200, 3)
SET IDENTITY_INSERT [dbo].[LoaiSach] OFF
SET IDENTITY_INSERT [dbo].[NhanSu] ON 

INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (2, N'Vũ Hùng Cường', CAST(N'1996-11-11 00:00:00.000' AS DateTime), N'HungCuong.jpg', N'Nam', N'hungcuong', N'123456', 1)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (3, N'Vũ Lê Minh', CAST(N'1996-10-20 00:00:00.000' AS DateTime), N'LeMinh.jpg', N'Nam', N'leminh', N'123456', 1)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (4, N'Mai Tuấn Anh', CAST(N'1995-10-10 00:00:00.000' AS DateTime), N'AnhTuan.jpg', N'Nam', N'tuananh', N'123456', 0)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (5, N'Nguyễn Miên Anh', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'AnhNguyen.jpg', N'Nam', N'mienanh', N'123456', 0)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (7, N'Kim Thị Thùy Hương', CAST(N'1960-01-01 00:00:00.000' AS DateTime), N'ThuyHuong.jpg', N'Nữ', N'kimhuong', N'123456', 0)
INSERT [dbo].[NhanSu] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [taikhoan], [matkhau], [quanly]) VALUES (8, N'Nguyễn Thị Hoa', CAST(N'1980-04-14 00:00:00.000' AS DateTime), N'HoaNguyen.jpg', N'Nữ', N'nguyenhoa', N'123456', 0)
SET IDENTITY_INSERT [dbo].[NhanSu] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (1, N'Mạng viễn thông', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (2, N'Phân tích thiết kế và giải thuật', 2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (3, N'Lập trình Java', 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (4, N'Vật lý đại cương 1', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (5, N'Vật lý đại cương 2', 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (6, N'Toán rời rạc', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (7, N'Toán chuyên đề', 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (8, N'Lý thuyết xác xuất thống kê', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (9, N'Toán cao cấp', 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([id], [tensach], [idloaisach], [noibo], [masach], [tacgia], [gioithieu], [trangthai]) VALUES (10, N'Đại số tuyến tính', 4, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Sach] OFF
SET IDENTITY_INSERT [dbo].[TheThuVien] ON 

INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (1, N'Nguyễn Miên Anh', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'mienanh', N'Nam', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (2, N'Nguyễn Văn Dũng ', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'nguyendung', N'Nam', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (3, N'Lê Bao Đồng', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'baodong', N'Nam', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (4, N'Kim Thị Thùy Hương', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'kimhuong', N'Nữ', 0)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (5, N'Nguyễn Đăng Khôi', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'dangkhoi', N'Nam', 1)
INSERT [dbo].[TheThuVien] ([id], [ten], [ngaysinh], [anhdaidien], [gioitinh], [loaithe]) VALUES (6, N'Lê Trường Sơn', CAST(N'1996-10-10 00:00:00.000' AS DateTime), N'truongson', N'Nam', 1)
SET IDENTITY_INSERT [dbo].[TheThuVien] OFF
ALTER TABLE [dbo].[MuonTra] ADD  DEFAULT (getdate()) FOR [ngaymuon]
GO
ALTER TABLE [dbo].[ChuDe]  WITH CHECK ADD  CONSTRAINT [fk_chude_kho] FOREIGN KEY([kho])
REFERENCES [dbo].[Kho] ([tenkho])
GO
ALTER TABLE [dbo].[ChuDe] CHECK CONSTRAINT [fk_chude_kho]
GO
ALTER TABLE [dbo].[LoaiSach]  WITH CHECK ADD  CONSTRAINT [fk_loaisach_chude] FOREIGN KEY([idchude])
REFERENCES [dbo].[ChuDe] ([id])
GO
ALTER TABLE [dbo].[LoaiSach] CHECK CONSTRAINT [fk_loaisach_chude]
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [fk_muontra_nhansu] FOREIGN KEY([idnhansu])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [fk_muontra_nhansu]
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [fk_muontra_thethuvien] FOREIGN KEY([idthethuvien])
REFERENCES [dbo].[TheThuVien] ([id])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [fk_muontra_thethuvien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [fk_sach_loaisach] FOREIGN KEY([idloaisach])
REFERENCES [dbo].[LoaiSach] ([id])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [fk_sach_loaisach]
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVienHVKTQS] SET  READ_WRITE 
GO
