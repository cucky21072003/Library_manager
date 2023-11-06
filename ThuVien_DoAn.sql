create database ThuVien_DoAn
go
use ThuVien_DoAn
go
create table TheLoai
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenTheLoai nvarchar(50)
)
go
create table TacGia
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenTacGia nvarchar(50)
)
go
create table NhaXuatBan 
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenNhaXuatBan nvarchar(50),
	DiaChi nvarchar(50),
	SoDienThoai int,
)
go
create table TaiLieu
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenTaiLieu nvarchar(50),
	NamXuatBan int,
	SoLuong int,
	TinhTrang nvarchar(500),
	TacGiaId int,
	TheLoaiId int,
	NhaXuatBanId int,
	foreign key (TacGiaId) references TacGia (Id),
	foreign key (TheLoaiId) references TheLoai (Id),
	foreign key (NhaXuatBanId) references NhaXuatBan (Id)
)
go
create table DocG
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenDocGia nvarchar(50),
	Lop nvarchar(50),
	NgaySinh datetime,
	GioiTinh nvarchar(10),
	SoDienThoai int
)
go
create table NhanVien
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenNhanVien nvarchar(50),
	DiaChi nvarchar(50),
	NgaySinh datetime,
	GioiTinh nvarchar(10),
	SoDienThoai int
)
go
create table QuyDinh
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenQuyDinh nvarchar(50),
	MoTa nvarchar(500),
	NgayBanHanh datetime
)
go

create table PhieuMuon
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DocGId int,
	NhanVienId int,
	foreign key (DocGId) references DocG (Id),
	foreign key (NhanVienId) references NhanVien (Id)
)
go
create table CTMuon_Tra
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Note nvarchar(500),
	NgayMuon datetime,
	NgayHenTra datetime,
	NgayTra datetime,
	PhieuMuonId int,
	TaiLieuId int,
	QuyDinhId int,
	foreign key (PhieuMuonId) references PhieuMuon (Id),
	foreign key (TaiLieuId) references TaiLieu (Id),
	foreign key (QuyDinhId) references QuyDinh (Id)
)
go
insert into TheLoai values('tiểu thuyết'),('ngụ ngôn'),('trinh thám')
go
insert into TacGia values('Vũ Hoàng'),('Hải Nam'),('Ngọc Vũ')
go
insert into NhaXuatBan values('Hồng Hà', 'Hà Nội', 985713),('Hải Tiến', 'Hà Nội', 98571),('Kim Đồng', 'Hà Nội', 98571)
go
insert into DocG values('Nguyễ Thảo','d16cnpm1', 7/21/2003,'nữ',34982), ('Huyền Trang','d16cnpm1', 15/2/2003,'nữ',3498)
go
insert into NhanVien values('Thùy Dung','Hưng Yên', 3/18/2003,'nữ',34982), ('Tài Phạm','Nghệ An', 10/25/2003,'nam',3498)
go
insert into QuyDinh  values ('kiểm điểm','viết bản kiểm điểm',1/2/2000), ('phạt','phạt tiền',1/3/2000)

go
create table Account
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	UserName nvarchar(50),
	Pass nvarchar(50),
	Funtion nvarchar(50)
)
go
insert into Account  values ('admin','123','admin'), ('user','1','user')
