USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QUANLICUAHANG1')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QUANLICUAHANG1') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QUANLICUAHANG1]
END
GO

CREATE DATABASE QUANLICUAHANG1

GO

USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[DAILI]    Script Date: 5/5/2018 1:15:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DAILI](
	[MaDL] [NVARCHAR](10) NOT NULL,
	[TenDL] [NVARCHAR](50) NULL,
	[DiaChi] [NVARCHAR](50) NULL,
	[SoDT] [NVARCHAR](15) NULL,
 CONSTRAINT [PK_DAILI] PRIMARY KEY CLUSTERED 
(
	[MaDL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[SANPHAMDL]    Script Date: 5/5/2018 1:16:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SANPHAMDL](
	[MaSPDL] [NVARCHAR](10) NOT NULL,
	[TenSP] [NVARCHAR](50) NOT NULL,
	[MaDL] [NVARCHAR](10) NOT NULL,
	[Gia] [MONEY] NULL,
	[DonVi] [NVARCHAR](20) NULL,
	[SoLuong] [INT] NULL,
 CONSTRAINT [PK_SANPHAMDL] PRIMARY KEY CLUSTERED 
(
	[MaSPDL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SANPHAMDL]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAMDL_DAILI] FOREIGN KEY([MaDL])
REFERENCES [dbo].[DAILI] ([MaDL])
GO

ALTER TABLE [dbo].[SANPHAMDL] CHECK CONSTRAINT [FK_SANPHAMDL_DAILI]
GO

USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[HOADONNHAPHANG]    Script Date: 5/5/2018 1:17:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HOADONNHAPHANG](
	[MaHDN] [NVARCHAR](10) NOT NULL,
	[MaDL] [NVARCHAR](10) NULL,
	[TenDL] [NVARCHAR](50) NULL,
	[NgayNhap] [DATETIME2](7) NULL,
	[TongTien] [MONEY] NULL,
	[TongNo] [MONEY] NULL,
 CONSTRAINT [PK_HOADONNHAPHANG] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HOADONNHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNH_DL] FOREIGN KEY([MaDL])
REFERENCES [dbo].[DAILI] ([MaDL])
GO

ALTER TABLE [dbo].[HOADONNHAPHANG] CHECK CONSTRAINT [FK_HOADONNH_DL]
GO

USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[CHITIETHOADONNHAP]    Script Date: 5/5/2018 1:17:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[CHITIETHOADONNHAP]    Script Date: 5/11/2018 11:59:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CHITIETHOADONNHAP](
	[MaHDN] [NVARCHAR](10) NOT NULL,
	[MaSPDL] [NVARCHAR](10) NOT NULL,
	[SoLuong] [INT] NULL,
 CONSTRAINT [PK_CHITIETHOADONNHAP] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC,
	[MaSPDL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CHITIETHOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHDN_HDN] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HOADONNHAPHANG] ([MaHDN])
GO

ALTER TABLE [dbo].[CHITIETHOADONNHAP] CHECK CONSTRAINT [FK_CHITIETHDN_HDN]
GO

ALTER TABLE [dbo].[CHITIETHOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHDN_SPDL] FOREIGN KEY([MaSPDL])
REFERENCES [dbo].[SANPHAMDL] ([MaSPDL])
GO

ALTER TABLE [dbo].[CHITIETHOADONNHAP] CHECK CONSTRAINT [FK_CHITIETHDN_SPDL]
GO


USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/5/2018 1:18:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [NVARCHAR](10) NOT NULL,
	[TenKH] [NVARCHAR](50) NULL,
	[DiaChi] [NVARCHAR](50) NULL,
	[SoDT] [NVARCHAR](15) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[SANPHAMCH]    Script Date: 5/8/2018 10:55:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SANPHAMCH](
	[MaSPCH] [NVARCHAR](10) NOT NULL,
	[TenSP] [NVARCHAR](50) NULL,
	[Gia] [MONEY] NULL,
	[DonVi] [NVARCHAR](20) NULL,
	[SoLuong] [INT] NULL,
	[HinhAnh] [IMAGE] NULL,
 CONSTRAINT [PK_SANPHAMCH] PRIMARY KEY CLUSTERED 
(
	[MaSPCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[SANPHAMCH]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAMCH_SANPHAMDL] FOREIGN KEY([MaSPCH])
REFERENCES [dbo].[SANPHAMDL] ([MaSPDL])
GO

ALTER TABLE [dbo].[SANPHAMCH] CHECK CONSTRAINT [FK_SANPHAMCH_SANPHAMDL]
GO

USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[HOADONBANHANG]    Script Date: 5/5/2018 1:19:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HOADONBANHANG](
	[MaHDB] [NVARCHAR](10) NOT NULL,
	[TenCH] [NVARCHAR](50) NULL,
	[MaKH] [NVARCHAR](10) NULL,
	[TenKH] [NVARCHAR](50) NULL,
	[NgayNhap] [DATETIME2](7) NULL,
	[TongTien] [MONEY] NULL,
	[TongNo] [MONEY] NULL,
 CONSTRAINT [PK_HOADONBANHANG] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[HOADONBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_HOADONBH_KH] FOREIGN KEY([MaKH])
--REFERENCES [dbo].[KHACHHANG] ([MaKH])
--GO

--ALTER TABLE [dbo].[HOADONBANHANG] CHECK CONSTRAINT [FK_HOADONBH_KH]
--GO

USE [QUANLICUAHANG1]
GO

/****** Object:  Table [dbo].[CHITIETHOADONBAN]    Script Date: 5/5/2018 1:19:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CHITIETHOADONBAN](
	[MaHDB] [NVARCHAR](10) NOT NULL,
	[MaSPCH] [NVARCHAR](10) NOT NULL,
	[SoLuong] [INT] NULL,
 CONSTRAINT [PK_CHITIETHOADONBAN1] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC,
	[MaSPCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CHITIETHOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHDB_HDBAN] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[HOADONBANHANG] ([MaHDB])
GO

ALTER TABLE [dbo].[CHITIETHOADONBAN] CHECK CONSTRAINT [FK_CHITIETHDB_HDBAN]
GO

ALTER TABLE [dbo].[CHITIETHOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHDBAN_HDBANHANG] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[HOADONBANHANG] ([MaHDB])
GO

ALTER TABLE [dbo].[CHITIETHOADONBAN] CHECK CONSTRAINT [FK_CHITIETHDBAN_HDBANHANG]
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 26/4/2018
CREATE PROCEDURE DSKhachHang 
AS
BEGIN
	SELECT *FROM dbo.KHACHHANG
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 24/4/2018
-- Description:	Thêm Khách Hàng
-- =============================================
CREATE PROCEDURE ThemKH 
	-- Add the parameters for the stored procedure here
	@MaKH NVARCHAR(10), 
	@TenKH NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@SoDT NVARCHAR(15) 
AS
BEGIN
	INSERT INTO dbo.KHACHHANG(MaKH,TenKH,DiaChi,SoDT)VALUES(@MaKH,@TenKH,@DiaChi,@SoDT)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 24/4/2018
-- Description:	Sửa Khách Hàng
-- =============================================
CREATE PROCEDURE SuaKH 
	-- Add the parameters for the stored procedure here
	@MaKH NVARCHAR(10), 
	@TenKH NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@SoDT NVARCHAR(15)
AS
BEGIN
	UPDATE dbo.KHACHHANG SET TenKH=@TenKH,DiaChi=@DiaChi,SoDT=@SoDT WHERE MaKH=@MaKH
END
GO

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 24/4/2018
-- Description:	Xóa Khách Hàng
-- =============================================
CREATE PROCEDURE XoaKH 
	-- Add the parameters for the stored procedure here
	@MaKH NVARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.KHACHHANG WHERE MaKH=@MaKH
END
GO

USE [QUANLICUAHANG1]
GO


-- Description:	Tìm kiếm thông tin khách hàng theo họ tên
-- =============================================
CREATE PROCEDURE TimKiemKH 
	@TuKhoa NVARCHAR(50)
AS
BEGIN
	SELECT*FROM dbo.KHACHHANG WHERE TenKH LIKE @TuKhoa
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE [QUANLICUAHANG1]
GO
-- Description: Tìm kiếm thông tin Khách hàng theo MaKH
CREATE PROCEDURE TimKiemKH2
	@TuKhoa NVARCHAR(10)
AS
BEGIN
	SELECT*FROM dbo.KHACHHANG WHERE MaKH LIKE @TuKhoa
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE [QUANLICUAHANG1]
GO
-- Hàm tự động tăng Mã khách hàng

CREATE FUNCTION fcGetMaKH()
RETURNS nvarchar(10)

AS 
BEGIN
    DECLARE @MaKH NVARCHAR(10)
	DECLARE @MaxMaKH NVARCHAR(10)
	DECLARE @Max FLOAT
    
	SELECT @MaxMaKH=MAX(MAKH) FROM dbo.KHACHHANG

	IF EXISTS (SELECT MaKH FROM KHACHHANG)
		SET @Max=CONVERT (FLOAT,SUBSTRING(@MaxMaKH,3,8))+1
	ELSE
		SET @Max=1
	IF (@Max<10)
		SET @MaKH='KH'+'0000000'+CONVERT(NVARCHAR(1),@Max)
	ELSE
	IF (@Max<100)
		SET @MaKH='KH'+'000000'+CONVERT(NVARCHAR(2),@Max)
	ELSE
	IF (@Max<1000)
		SET @MaKH='KH'+'00000'+CONVERT(NVARCHAR(3),@Max)
	ELSE
	IF (@Max<10000)
		SET @MaKH='KH'+'0000'+CONVERT(NVARCHAR(4),@Max)
	ELSE
	IF (@Max<100000)
		SET @MaKH='KH'+'000'+CONVERT(NVARCHAR(5),@Max)
	ELSE
	IF (@Max<1000000)
		SET @MaKH='KH'+'00'+CONVERT(NVARCHAR(6),@Max)
    ELSE
	IF (@Max<10000000)
		SET @MaKH='KH'+'0'+CONVERT(NVARCHAR(7),@Max)   
	ELSE
	    SET @MaKH='KH'+CONVERT(NVARCHAR(8),@Max)
	RETURN @MaKH
END

USE [QUANLICUAHANG1]
GO

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 27/4/2018
-- Description:	Danh sách phiếu bán hàng
-- =============================================
CREATE PROCEDURE DSPhieuBan 
AS
BEGIN
	SELECT* FROM dbo.HOADONBANHANG
END
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 27/4/2018
-- Description:	Thêm phiếu bán
-- =============================================
CREATE PROCEDURE ThemPHBan 
	@MaHDB NVARCHAR(10), 
	@TenCH NVARCHAR(50),
	@MaKH NVARCHAR(10),
	@TenKH NVARCHAR(50),
	@NgayNhap DATETIME2,
	@TongTien MONEY,
	@TongNo MONEY 
AS
BEGIN
	INSERT INTO dbo.HOADONBANHANG(MaHDB,TenCH,MaKH,TenKH,NgayNhap,TongTien,TongNo)VALUES(@MaHDB,@TenCH,@MaKH,@TenKH,@NgayNhap,@TongTien,@TongNo)
END
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 27/4/2018
-- Description:	Sửa phiếu bán
-- =============================================
CREATE PROCEDURE SuaPHBan 
	@MaHDB NVARCHAR(10), 
	@TenCH NVARCHAR(50),
	@MaKH NVARCHAR(10),
	@TenKH NVARCHAR(50),
	@NgayNhap DATETIME2,
	@TongTien MONEY,
	@TongNo MONEY 
AS
BEGIN
	UPDATE dbo.HOADONBANHANG SET TenCH=@TenCH,MaKH=@MaKH,TenKH=@TenKH,NgayNhap=@NgayNhap,TongTien=@TongTien,TongNo=@TongNo WHERE MaHDB=@MaHDB
END
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 27/4/2018
-- Description:	Sửa phiếu bán
-- =============================================
CREATE PROCEDURE XoaPHBan 
		@MaHDB NVARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.HOADONBANHANG WHERE MaHDB=@MaHDB
END
GO

-- Hàm tự động tăng Mã hóa đơn bán

CREATE FUNCTION fcGetMaHDB()
RETURNS nvarchar(10)

AS 
BEGIN
    DECLARE @MaHDB NVARCHAR(10)
	DECLARE @MaxMaHDB NVARCHAR(10)
	DECLARE @Max FLOAT
    
	SELECT @MaxMaHDB=MAX(MAHDB) FROM dbo.HOADONBANHANG

	IF EXISTS (SELECT MAHDB FROM dbo.HOADONBANHANG)
		SET @Max=CONVERT (FLOAT,SUBSTRING(@MaxMaHDB,4,7))+1
	ELSE
		SET @Max=1
	IF (@Max<10)
		SET @MaHDB='HDB'+'000000'+CONVERT(NVARCHAR(1),@Max)
	ELSE
	IF (@Max<100)
		SET @MaHDB='HDB'+'00000'+CONVERT(NVARCHAR(2),@Max)
	ELSE
	IF (@Max<1000)
		SET @MaHDB='HDB'+'0000'+CONVERT(NVARCHAR(3),@Max)
	ELSE
	IF (@Max<10000)
		SET @MaHDB='HDB'+'000'+CONVERT(NVARCHAR(4),@Max)
	ELSE
	IF (@Max<100000)
		SET @MaHDB='HDB'+'00'+CONVERT(NVARCHAR(5),@Max)
	ELSE
	IF (@Max<1000000)
		SET @MaHDB='HDB'+'0'+CONVERT(NVARCHAR(6),@Max)
    ELSE
	    SET @MaHDB='HDB'+CONVERT(NVARCHAR(7),@Max)
	RETURN @MaHDB
END


-- Create date: 21/4/2018
-- Description:	Liệt kê Danh Sách Đại Lí
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE DSDAILI 
AS
BEGIN
	SELECT *FROM DAILI
END
GO


-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 21/4/2018
-- Description:	Thêm Đại lí
-- =============================================
CREATE PROCEDURE ThemDaiLi 
	@MaDL NVARCHAR(10),
	@TenDL NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@SoDT NVARCHAR(15)
AS
BEGIN
		INSERT INTO dbo.DAILI(MaDL,TenDL,DiaChi,SoDT)VALUES(@MaDL,@TenDL,@DiaChi,@SoDT)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: Tô Công Hậu
-- Description:	Sửa thông tin Đại lí
-- =============================================
CREATE PROCEDURE SuaDaiLi
	@MaDL NVARCHAR(10),
	@TenDL NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@SoDT NVARCHAR(15)
AS
BEGIN
	UPDATE dbo.DAILI SET TenDL=@TenDL,DiaChi=@DiaChi,SoDT=@SoDT WHERE MaDL=@MADL
END
GO

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 22/04/2018
-- Description:	Xóa Tên Đại Lí
-- =============================================
CREATE PROCEDURE XoaDL 
	@MaDL NVARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.DAILI WHERE MaDL=@MaDL
END

-- Hàm tự động tăng Mã Đại Lí
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION fcGetMaDL()
RETURNS nvarchar(10)

AS 
BEGIN
    DECLARE @MaDL NVARCHAR(10)
	DECLARE @MaxMaDL NVARCHAR(10)
	DECLARE @Max FLOAT
    
	SELECT @MaxMaDL=MAX(MADL) FROM dbo.DAILI

	IF EXISTS (SELECT MaDL FROM dbo.DAILI)
		SET @Max=CONVERT (FLOAT,SUBSTRING(@MaxMaDL,3,8))+1
	ELSE
		SET @Max=1
	IF (@Max<10)
		SET @MaDL='DL'+'0000000'+CONVERT(NVARCHAR(1),@Max)
	ELSE
	IF (@Max<100)
		SET @MaDL='DL'+'000000'+CONVERT(NVARCHAR(2),@Max)
	ELSE
	IF (@Max<1000)
		SET @MaDL='DL'+'00000'+CONVERT(NVARCHAR(3),@Max)
	ELSE
	IF (@Max<10000)
		SET @MaDL='DL'+'0000'+CONVERT(NVARCHAR(4),@Max)
	ELSE
	IF (@Max<100000)
		SET @MaDL='DL'+'000'+CONVERT(NVARCHAR(5),@Max)
	ELSE
	IF (@Max<1000000)
		SET @MaDL='DL'+'00'+CONVERT(NVARCHAR(6),@Max)
    ELSE
	IF (@Max<10000000)
		SET @MaDL='DL'+'0'+CONVERT(NVARCHAR(7),@Max)   
	ELSE
	    SET @MaDL='DL'+CONVERT(NVARCHAR(8),@Max)
	RETURN @MaDL
END

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 22/04/2018
-- Description:	Sản phẩm của Đại Lí
-- =============================================
CREATE PROCEDURE DSSanPhamDL 
AS
BEGIN
	SELECT*FROM dbo.SANPHAMDL
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 22/04/2018
-- Description:	Thêm Sản phẩm Đại lí
-- =============================================
CREATE PROCEDURE ThemSPDL 
	-- Add the parameters for the stored procedure here
	@MaSPDL NVARCHAR(10),
	@TenSP NVARCHAR(50),
	@MaDL NVARCHAR(10),
	@Gia MONEY,
	@DonVi NVARCHAR(20),
	@SoLuong INT 
AS
BEGIN
	INSERT INTO dbo.SANPHAMDL(MaSPDL,TenSP,MaDL,Gia,DonVi,SoLuong) VALUES (@MASPDL,@TenSP,@MaDL,@Gia,@DonVi,@SoLuong)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công  Hậu
-- Create date: 23/4/2018
-- Description:	Sửa sản phẩm Đại Lí
-- =============================================
CREATE PROCEDURE SuaSPDL 
	@MaSPDL NVARCHAR(10),
	@TenSP NVARCHAR(50),
	@MaDL NVARCHAR(10),
	@Gia MONEY,
	@DonVi NVARCHAR(20),
	@SoLuong INT 
AS
BEGIN
	UPDATE dbo.SANPHAMDL SET TenSP=@TenSP,MaDL=@MaDL,Gia=@Gia,DonVi=@DonVi,SoLuong=@SoLuong WHERE MaSPDL=@MaSPDL
END
GO

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 23/4/2018
-- Description:	Xóa Sản Phẩm Đại Lí
-- =============================================
CREATE PROCEDURE XoaSPDL 
	@MaSPDL NVARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.SANPHAMDL WHERE MaSPDL=@MaSPDL 
END
GO

-- Hàm tự động tăng Mã Sản Phẩm

CREATE FUNCTION fcGetMaSP()
RETURNS nvarchar(10)

AS 
BEGIN
      DECLARE @MaSPDL NVARCHAR(10)
	DECLARE @MaxMaSPDL NVARCHAR(10)
	DECLARE @Max FLOAT
    
	SELECT @MaxMaSPDL=MAX(MaSPDL) FROM dbo.SANPHAMDL

	IF EXISTS (SELECT MaSPDL FROM dbo.SANPHAMDL)
		SET @Max=CONVERT (FLOAT,SUBSTRING(@MaxMaSPDL,3,8))+1
	ELSE
		SET @Max=1
	IF (@Max<10)
		SET @MaSPDL='SP'+'0000000'+CONVERT(NVARCHAR(1),@Max)
	ELSE
	IF (@Max<100)
		SET @MaSPDL='SP'+'000000'+CONVERT(NVARCHAR(2),@Max)
	ELSE
	IF (@Max<1000)
		SET @MaSPDL='SP'+'00000'+CONVERT(NVARCHAR(3),@Max)
	ELSE
	IF (@Max<10000)
		SET @MaSPDL='SP'+'0000'+CONVERT(NVARCHAR(4),@Max)
	ELSE
	IF (@Max<100000)
		SET @MaSPDL='SP'+'000'+CONVERT(NVARCHAR(5),@Max)
	ELSE
	IF (@Max<1000000)
		SET @MaSPDL='SP'+'00'+CONVERT(NVARCHAR(6),@Max)
    ELSE
	IF (@Max<10000000)
		SET @MaSPDL='SP'+'0'+CONVERT(NVARCHAR(7),@Max)   
	ELSE
	    SET @MaSPDL='SP'+CONVERT(NVARCHAR(8),@Max)
	RETURN @MaSPDL
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 8/5/2018
-- Description:	Thêm Sản phẩm vào Cửa hàng từ Đại Lí
-- =============================================
CREATE  TRIGGER TRG_SPDL_CH
ON  SANPHAMDL 
FOR INSERT
AS 
BEGIN
	DECLARE @MaSPDL NVARCHAR(10),@TenSP NVARCHAR(50),@Gia MONEY,@DonVi NVARCHAR(20),@SoLuong INT
	SELECT @MaSPDL=MaSPDL,@TenSP=TenSP,@Gia=Gia,@DonVi=DonVi,@SoLuong=SoLuong
	FROM Inserted

	INSERT INTO dbo.SANPHAMCH(MaSPCH,TenSP,Gia,DonVi,SoLuong,HinhAnh)VALUES(@MaSPDL,@TenSP,@Gia,@DonVi,@SoLuong,NULL)
END
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 27/4/2018
-- Description:	Danh sách Sản phẩm trong cửa hàng
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DSSanPhamCH 
AS
BEGIN
	SELECT * FROM dbo.SANPHAMCH 
END


-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 27/4/2018
-- Description:	Sửa sản phẩm trong Cửa hàng
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE SuaSPCH
	@MaSPCH NVARCHAR(10),
	@TenSP NVARCHAR(50),
	@Gia MONEY,
	@DonVi NVARCHAR(20),
	@SoLuong INT,
	@HinhAnh IMAGE
AS
BEGIN
	UPDATE dbo.SANPHAMCH SET TenSP=@TenSP,Gia=@Gia,DonVi=@DonVi,SoLuong=@SoLuong,HinhAnh=@HinhAnh WHERE MaSPCH=@MaSPCH
END

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 27/4/2018
-- Description:	Xóa sản phẩm trong Cửa hàng
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE XoaSPCH
	@MaSPCH NVARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.SANPHAMCH WHERE MaSPCH=@MaSPCH
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 25/4/2018
-- Description:	Thêm phiếu nhập hàng
-- =============================================
CREATE PROCEDURE ThemPHNhap 
	-- Add the parameters for the stored procedure here
	@MaHDN NVARCHAR(10), 
	@MaDL NVARCHAR(50),
	@TenDL NVARCHAR(50),
	@NgayNhap DATETIME2,
	@TongTien MONEY,
	@TongNo MONEY
AS
BEGIN
	INSERT INTO dbo.HOADONNHAPHANG(MaHDN,MaDL,TenDL,NgayNhap,TongTien,TongNo)VALUES(@MaHDN,@MaDL,@TenDL,@NgayNhap,@TongTien,@TongNo)
END
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 25/4/2018
-- Description:	Danh sách phiếu nhập
-- =============================================
CREATE PROCEDURE DSPhieuNhap 
AS
BEGIN
	SELECT *FROM dbo.HOADONNHAPHANG
END
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 25/4/2018
-- Description:	Chỉnh sửa phiếu nhập hàng
-- =============================================
CREATE PROCEDURE SuaPHNhap 
	-- Add the parameters for the stored procedure here
	@MaHDN NVARCHAR(10), 
	@MaDL NVARCHAR(50),
	@TenDL NVARCHAR(50),
	@NgayNhap DATETIME2,
	@TongTien MONEY,
	@TongNo MONEY
AS
BEGIN
	UPDATE dbo.HOADONNHAPHANG SET MaDL=@MaDL,TenDL=@TenDL,NgayNhap=@NgayNhap,TongTien=@tongTien,TongNo=@TongNo WHERE MaHDN=@MaHDN
END
GO

-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 25/4/2018
-- Description:	Xóa Phiếu Hàng Nhập
-- =============================================
CREATE PROCEDURE XoaPHNhap 
	@MaHDN NVARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.HOADONNHAPHANG WHERE MaHDN=@MaHDN
END
GO

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Hàm tự động tăng Mã hóa đơn nhập

CREATE FUNCTION fcGetMaHDN()
RETURNS nvarchar(10)

AS 
BEGIN
    DECLARE @MaHDN NVARCHAR(10)
	DECLARE @MaxMaHDN NVARCHAR(10)
	DECLARE @Max FLOAT
    
	SELECT @MaxMaHDN=MAX(MAHDN) FROM dbo.HOADONNHAPHANG

	IF EXISTS (SELECT MAHDN FROM dbo.HOADONNHAPHANG)
		SET @Max=CONVERT (FLOAT,SUBSTRING(@MaxMaHDN,4,7))+1
	ELSE
		SET @Max=1
	IF (@Max<10)
		SET @MaHDN='HDN'+'000000'+CONVERT(NVARCHAR(1),@Max)
	ELSE
	IF (@Max<100)
		SET @MaHDN='HDN'+'00000'+CONVERT(NVARCHAR(2),@Max)
	ELSE
	IF (@Max<1000)
		SET @MaHDN='HDN'+'0000'+CONVERT(NVARCHAR(3),@Max)
	ELSE
	IF (@Max<10000)
		SET @MaHDN='HDN'+'000'+CONVERT(NVARCHAR(4),@Max)
	ELSE
	IF (@Max<100000)
		SET @MaHDN='HDN'+'00'+CONVERT(NVARCHAR(5),@Max)
	ELSE
	IF (@Max<1000000)
		SET @MaHDN='HDN'+'0'+CONVERT(NVARCHAR(6),@Max)
    ELSE
	    SET @MaHDN='HDN'+CONVERT(NVARCHAR(7),@Max)
	RETURN @MaHDN
END

CREATE PROCEDURE TimTenDL 
	@MaDL NVARCHAR(10)
AS
BEGIN
	SELECT TENDL FROM dbo.DAILI WHERE MaDL=@MaDL
END
GO


-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 26/4/2018
-- Description:	Danh Sách Chi tiết phiếu nhập
-- =============================================
CREATE PROCEDURE DSChiTietPhieuNhap 
AS
BEGIN
	SELECT*FROM dbo.CHITIETHOADONNHAP
END

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 26/4/2018
-- Description:	Thêm chi tiết phiếu nhập
-- =============================================
CREATE PROCEDURE ThemChiTietPHNhap 
	@MaHDN NVARCHAR(10), 
	@MaSPDL NVARCHAR(10),
	@SoLuong INT
AS
BEGIN
	INSERT INTO dbo.CHITIETHOADONNHAP(MaHDN,MaSPDL,SoLuong)VALUES(@MaHDN,@MaSPDL,@SoLuong) 
END
GO

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 26/4/2018
-- Description:	Thêm chi tiết phiếu nhập
-- =============================================
CREATE  PROCEDURE SuaChiTietPHNhap
	@MaHDN NVARCHAR(10), 
	@MaSPDL NVARCHAR(10),
	@SoLuong INT
AS
BEGIN
	UPDATE dbo.CHITIETHOADONNHAP SET SoLuong=@SoLuong WHERE MaHDN=@MaHDN AND MaSPDL=@MaSPDL
END

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Công Hậu
-- Create date: 26/4/2018
-- Description:	Thêm chi tiết phiếu nhập
-- =============================================
CREATE  PROCEDURE XoaChiTietPHNhap
	@MaSPDL NVARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.CHITIETHOADONNHAP WHERE MaSPDL=@MASPDL
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tô Cồng Hậu
-- Create date: 11/5/2018
-- Description:	Cập nhật Tổng tiền cho Hóa đơn nhập hàng
-- =============================================
CREATE TRIGGER TRG_CTHDN_HDN 
ON  dbo.CHITIETHOADONNHAP
FOR INSERT,UPDATE
AS 
BEGIN
	DECLARE @TongTien MONEY
	DECLARE @MaHDN NVARCHAR(10)

	SELECT @MaHDN=MaHDN
	FROM Inserted

	SELECT @TongTien=Sum(B.SoLuong*A.Gia)
	FROM dbo.SANPHAMDL A,dbo.CHITIETHOADONNHAP B
	WHERE A.MaSPDL=B.MaSPDL AND B.MaHDN=@MaHDN
	GROUP BY B.MaHDN

	UPDATE dbo.HOADONNHAPHANG SET TongTien=@TongTien WHERE MaHDN=@MaHDN

END
GO

CREATE TRIGGER TRG_CTHDN_HDN1 
ON  dbo.CHITIETHOADONNHAP
FOR DELETE 
AS 
BEGIN
	DECLARE @TongTien MONEY
	DECLARE @MaHDN NVARCHAR(10)

	SELECT @MaHDN=MaHDN
	FROM Deleted

	SELECT @TongTien=Sum(B.SoLuong*A.Gia)
	FROM dbo.SANPHAMDL A,dbo.CHITIETHOADONNHAP B
	WHERE A.MaSPDL=B.MaSPDL AND B.MaHDN=@MaHDN
	GROUP BY B.MaHDN

	UPDATE dbo.HOADONNHAPHANG SET TongTien=@TongTien WHERE MaHDN=@MaHDN

END
GO
















EXEC dbo.TimTenDL @MADL= 'DL00000001'

INSERT INTO dbo.SANPHAMDL
(
    MaSPDL,
    TenSP,
    MaDL,
    Gia,
    DonVi,
    SoLuong
)
VALUES
(   N'SP00000006',  --  - nvarchar(10)
    N'jh',  -- TenSP - nvarchar(50)
    N'DL00000003',  -- MaDL - nvarchar(10)
    NULL, -- Gia - money
    N'33',  -- DonVi - nvarchar(20)
    0     -- SoLuong - int
    )
	DROP TABLE SanPhamDL  
	DELETE FROM dbo.SANPHAMDL WHERE MaSPDL='SP00000006'
	SELECT *FROM  dbo.SANPHAMDL