create table Kho 
(
	id int identity ,
	tenkho nvarchar(200) not null,
	vitri nvarchar(200) not null,

  constraint pk_kho
	primary key (id)
)


create table ChuDe
(
	id int identity ,
	tenchude nvarchar(200) not null,
	soluong int,

	idkho int,

	constraint pk_chude
	primary key (id),

	constraint fk_chude_kho
	foreign key (idkho)
	references Kho(id)
)

create table LoaiSach
(
	id int identity ,
	soluong int,
	noibo int, -- 1 Tài liệu lưu hành nội bộ -- 0 Tài liệu chung

	idchude int,

	constraint pk_loaisach
	primary key (id),

	constraint fk_loaisach_chude
	foreign key (idchude)
	references ChuDe(id)
)

create table Sach 
(
	id int identity ,
	tensach nvarchar(200) not null,

	idloaisach int,

	constraint pk_sach
	primary key (id),

	constraint fk_sach_loaisach
	foreign key (idloaisach)
	references LoaiSach (id)
)

create table NhanSu
(
	id int identity ,
	ten nvarchar(200) not null,
	ngaysinh datetime,
	anhdaidien varchar(MAX),
	gioitinh nvarchar(3), -- Nam or Nữ
	taikhoan varchar(200),
	matkhau varchar(200),

	quanly int, -- 0 Thử thư --1 Quản lý
	
	constraint pk_nhansu
	primary key (id)
)

create table TheThuVien 
(
	id int identity,
	ten nvarchar(200) not null,
	ngaysinh datetime,
	anhdaidien varchar(MAX),
	gioitinh nvarchar(3), -- Nam or Nữ
	loaithe int, --0 Dân sự --1 Quân sự

	constraint pk_thethuvien
	primary key (id),
)

create table MuonTra
(
	id int identity ,
	ngaymuon datetime default getdate(),
	hanmuon datetime,
	ngaytra datetime,

	idnhansu int,
	idthethuvien int,

	constraint pk_muontra
	primary key (id),

	constraint fk_muontra_nhansu
	foreign key (idnhansu)
	references NhanSu (id),

	constraint fk_muontra_thethuvien
	foreign key (idthethuvien)
	references TheThuVien (id)
)





