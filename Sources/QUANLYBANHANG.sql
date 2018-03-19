create database QUANLYBANHANGVATTUPHANBON
go

--Khach hang
create table KHACHHANG
(
	ID int identity primary key,
	HoTen nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	TienNo money default 0
)


--HoaDon

create table HOADON
(
	MaHD nvarchar(10) primary key,
	MaSP nvarchar(10) not null,
	NgHD smalldatetime not null,
)

--CTHD ban

create table CTHDB
(
	MaHD nvarchar(10),
	MaSP nvarchar(10),
	SoLuong int,
	primary key(MaHD, MaSP)
)

-- San Pham
create table SANPHAM
(	
	MaSP nvarchar(10) primary key,
	TenSP nvarchar(30),
	Gia money,
)

--Dai Ly
create table DAILY
(
	MaDL nvarchar(10) primary key,
	TenDL nvarchar(50),
	TongNo money
)

--CTHDN
create table CTHDN
(
	MaDL nvarchar(10),
	MaSP nvarchar(10),
	NgayNhap smalldatetime,
	SLNhap int,
	DonGia Money,
	primary key(MaDL, MaSP)
)