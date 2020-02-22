USE [master]
GO
/****** Object:  Database [QuanLyThuVien_PTTKPM]    Script Date: 2/22/2020 10:35:00 PM ******/
CREATE DATABASE [QuanLyThuVien_PTTKPM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien_PTTKPM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyThuVien_PTTKPM.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyThuVien_PTTKPM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyThuVien_PTTKPM_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien_PTTKPM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyThuVien_PTTKPM]
GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenloaisach] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTaiKhoan] [varchar](100) NOT NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MuonSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MuonSach](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[matk] [varchar](100) NULL,
	[masach] [varchar](100) NULL,
	[ngaymuon] [date] NOT NULL,
	[ngaytra] [date] NULL,
	[phuthu] [int] NULL,
	[trangthai] [bit] NOT NULL,
 CONSTRAINT [PK_MuonSach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[masach] [varchar](100) NOT NULL,
	[tieude] [nvarchar](500) NOT NULL,
	[tacgia] [nvarchar](200) NOT NULL,
	[idloaisach] [int] NULL,
	[soluong] [int] NOT NULL,
	[trangthai] [bit] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[matk] [varchar](100) NOT NULL,
	[tendangnhap] [varchar](100) NOT NULL,
	[matkhau] [varchar](100) NOT NULL,
	[tentaikhoan] [nvarchar](200) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[diachi] [nvarchar](max) NOT NULL,
	[loaitaikhoan] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[matk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiSach] ON 

INSERT [dbo].[LoaiSach] ([id], [tenloaisach]) VALUES (1, N'Tin học')
INSERT [dbo].[LoaiSach] ([id], [tenloaisach]) VALUES (2, N'Khoa học')
INSERT [dbo].[LoaiSach] ([id], [tenloaisach]) VALUES (3, N'Tạp chí')
INSERT [dbo].[LoaiSach] ([id], [tenloaisach]) VALUES (4, N'Ngoại ngữ')
INSERT [dbo].[LoaiSach] ([id], [tenloaisach]) VALUES (5, N'Văn học')
SET IDENTITY_INSERT [dbo].[LoaiSach] OFF
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] ON 

INSERT [dbo].[LoaiTaiKhoan] ([id], [TenLoaiTaiKhoan]) VALUES (1, N'admin')
INSERT [dbo].[LoaiTaiKhoan] ([id], [TenLoaiTaiKhoan]) VALUES (2, N'docgia')
INSERT [dbo].[LoaiTaiKhoan] ([id], [TenLoaiTaiKhoan]) VALUES (3, N'nhanvienthuvien')
INSERT [dbo].[LoaiTaiKhoan] ([id], [TenLoaiTaiKhoan]) VALUES (4, N'thuthu')
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] OFF
SET IDENTITY_INSERT [dbo].[MuonSach] ON 

INSERT [dbo].[MuonSach] ([id], [matk], [masach], [ngaymuon], [ngaytra], [phuthu], [trangthai]) VALUES (11, N'DG0001', N'1', CAST(N'2020-02-21' AS Date), CAST(N'2020-02-21' AS Date), 0, 1)
INSERT [dbo].[MuonSach] ([id], [matk], [masach], [ngaymuon], [ngaytra], [phuthu], [trangthai]) VALUES (15, N'DG0001', N'3', CAST(N'2020-02-21' AS Date), CAST(N'2020-02-21' AS Date), 0, 1)
INSERT [dbo].[MuonSach] ([id], [matk], [masach], [ngaymuon], [ngaytra], [phuthu], [trangthai]) VALUES (16, N'DG0001', N'2', CAST(N'2020-02-21' AS Date), CAST(N'2020-02-21' AS Date), 0, 1)
INSERT [dbo].[MuonSach] ([id], [matk], [masach], [ngaymuon], [ngaytra], [phuthu], [trangthai]) VALUES (18, N'DG0001', N'10', CAST(N'2020-02-10' AS Date), CAST(N'2020-02-21' AS Date), 165000, 1)
INSERT [dbo].[MuonSach] ([id], [matk], [masach], [ngaymuon], [ngaytra], [phuthu], [trangthai]) VALUES (19, N'DG0001', N'5', CAST(N'2020-02-22' AS Date), CAST(N'2020-02-22' AS Date), 0, 1)
INSERT [dbo].[MuonSach] ([id], [matk], [masach], [ngaymuon], [ngaytra], [phuthu], [trangthai]) VALUES (20, N'DG0001', N'6', CAST(N'2020-02-22' AS Date), NULL, 0, 0)
INSERT [dbo].[MuonSach] ([id], [matk], [masach], [ngaymuon], [ngaytra], [phuthu], [trangthai]) VALUES (21, N'DG0001', N'1', CAST(N'2020-02-22' AS Date), NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[MuonSach] OFF
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'1', N'Kỹ thuật lập trình', N'Nhiều tác giả', 1, 10, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'10', N'Những nhà khám phá', N'Daniel J.Boorstin', 2, 10, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'2', N'Cơ sở dữ liệu', N'Nhiều tác giả', 1, 11, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'3', N'Tự học tiếng Anh giao tiếp', N'c', 4, 10, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'4', N'The TIMES', N'St Paul''s School', 3, 10, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'5', N'Tự học tiếng Anh hiệu quả', N'Nguyễn Thị Hà Bắc', 4, 7, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'6', N'3000 Từ vựng Tiếng Anh thông dụng nhất', N' Nhiều tác giả', 4, 5, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'7', N'Bí mật vũ trụ', N'Trần Thoại Lan', 2, 8, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'8', N'Kính vạn hoa', N'Nguyễn Nhật Ánh', 5, 10, 1)
INSERT [dbo].[Sach] ([masach], [tieude], [tacgia], [idloaisach], [soluong], [trangthai]) VALUES (N'9', N'Những người khốn khổ', N'Victor Hugo', 5, 10, 1)
INSERT [dbo].[TaiKhoan] ([matk], [tendangnhap], [matkhau], [tentaikhoan], [ngaysinh], [diachi], [loaitaikhoan]) VALUES (N'AD0001', N'admin1', N'1234', N'admin 1', CAST(N'1996-02-02' AS Date), N'q3', 1)
INSERT [dbo].[TaiKhoan] ([matk], [tendangnhap], [matkhau], [tentaikhoan], [ngaysinh], [diachi], [loaitaikhoan]) VALUES (N'DG0001', N'docgia1', N'12345', N'nguyen van bcccc', CAST(N'1996-02-10' AS Date), N'67 nguyen thi minh khai  q3 hcmx', 2)
INSERT [dbo].[TaiKhoan] ([matk], [tendangnhap], [matkhau], [tentaikhoan], [ngaysinh], [diachi], [loaitaikhoan]) VALUES (N'DG0002', N'docgia2', N'1234', N'docgia2', CAST(N'1996-02-10' AS Date), N'xxxx', 2)
INSERT [dbo].[TaiKhoan] ([matk], [tendangnhap], [matkhau], [tentaikhoan], [ngaysinh], [diachi], [loaitaikhoan]) VALUES (N'DG202002140844', N'text1', N'text1', N'text1', CAST(N'2020-02-14' AS Date), N'text1', 2)
INSERT [dbo].[TaiKhoan] ([matk], [tendangnhap], [matkhau], [tentaikhoan], [ngaysinh], [diachi], [loaitaikhoan]) VALUES (N'NV0001', N'nhanvien1', N'1234', N'nhanvien1', CAST(N'1996-02-01' AS Date), N'xxx', 3)
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_Sach] FOREIGN KEY([masach])
REFERENCES [dbo].[Sach] ([masach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [FK_MuonSach_Sach]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_TaiKhoan] FOREIGN KEY([matk])
REFERENCES [dbo].[TaiKhoan] ([matk])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [FK_MuonSach_TaiKhoan]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_LoaiSach] FOREIGN KEY([idloaisach])
REFERENCES [dbo].[LoaiSach] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_LoaiSach]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan] FOREIGN KEY([loaitaikhoan])
REFERENCES [dbo].[LoaiTaiKhoan] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_LoaiTaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[DangKy_TaiKhoan]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangKy_TaiKhoan] (
	@matk nvarchar(100),
	@tendangnhap varchar(100),
	@matkhau varchar(100),
	@tentaikhoan nvarchar(100),
	@ngaysinh varchar(100),
	@diachi varchar(100),
	@loaitaikhoan int
) 
AS BEGIN
	 IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE tendangnhap = @tendangnhap AND matkhau = @matkhau)
	 BEGIN
		 INSERT INTO TaiKhoan (matk, tendangnhap, matkhau, tentaikhoan, ngaysinh, diachi, loaitaikhoan)
		 VALUES (@matk, @tendangnhap, @matkhau, @tentaikhoan, @ngaysinh, @diachi, @loaitaikhoan)
	 END
END
GO
/****** Object:  StoredProcedure [dbo].[DangNhap_TaiKhoan]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhap_TaiKhoan](@tendangnhap nvarchar(100), @matkhau varchar(100))
AS BEGIN
	 SELECT matk, tendangnhap, matkhau, tentaikhoan, ngaysinh, diachi, loaitaikhoan
	 FROM TaiKhoan
	 WHERE tendangnhap = @tendangnhap AND matkhau = @matkhau
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_Sach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_Sach] (@masach varchar(100)) 
AS BEGIN 
	DELETE Sach WHERE masach = @masach
END
GO
/****** Object:  StoredProcedure [dbo].[GetAll_LoaiSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAll_LoaiSach]
AS BEGIN 
	SELECT id, tenloaisach
	FROM LoaiSach
END
GO
/****** Object:  StoredProcedure [dbo].[GetAll_Sach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAll_Sach]
AS BEGIN 
	SELECT masach, tieude, tacgia, idloaisach, soluong, trangthai, ls.tenloaisach
	FROM Sach s, LoaiSach ls
	WHERE s.idloaisach = ls.id
END
GO
/****** Object:  StoredProcedure [dbo].[MuonSach_DanhSachMuonSachAll]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MuonSach_DanhSachMuonSachAll]
AS BEGIN 
	SELECT id, ms.matk, tk.tentaikhoan, ms.masach, s.tieude, ngaymuon, ngaytra, phuthu, ms.trangthai
	FROM MuonSach ms, TaiKhoan tk, Sach s
	WHERE ms.matk = tk.matk and ms.masach = s.masach
	ORDER BY ngaymuon DESC
END
GO
/****** Object:  StoredProcedure [dbo].[MuonSach_DsTaiKhoanMuonSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MuonSach_DsTaiKhoanMuonSach] (@masach varchar(100))
AS BEGIN 
	SELECT id, ms.matk, tk.tentaikhoan, ngaymuon, ngaytra,phuthu, trangthai
	FROM MuonSach ms, TaiKhoan tk
	WHERE ms.masach = @masach AND ms.matk = tk.matk
END
GO
/****** Object:  StoredProcedure [dbo].[MuonSach_HuyMuonSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MuonSach_HuyMuonSach](@id int)
AS BEGIN
	DELETE MuonSach WHERE id = @id  
END
GO
/****** Object:  StoredProcedure [dbo].[MuonSach_TimKiemTaiKhoanMuonSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MuonSach_TimKiemTaiKhoanMuonSach](
	@masach varchar(100),
	@matk varchar(100)
) 
AS BEGIN 
	SELECT id, ms.matk, tk.tentaikhoan, ngaymuon, ngaytra,phuthu, trangthai
	FROM MuonSach ms, TaiKhoan tk
	WHERE ms.masach = @masach AND ms.matk = @matk and ms.matk = tk.matk
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MuonSach_Them]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MuonSach_Them]
	@matk varchar(100),
	@masach varchar(100),
	@ngaymuon varchar(100),
	@ngaytra varchar(100),
	@phuthu int,
	@trangthai bit
AS
BEGIN
	--SET NOCOUNT ON;
	DECLARE @soluong int;
	DECLARE @kt_masach varchar(100);
	DECLARE @kt_matk varchar(100);
	DECLARE @kt_trangthai bit = 1;

	SET @soluong = (SELECT s.soluong
	FROM Sach s
	WHERE s.masach = @masach)

	SET @kt_masach = (SELECT s.masach
	FROM Sach s
	WHERE s.masach = @masach)

	SET @kt_matk = (SELECT tk.matk
	FROM TaiKhoan tk
	WHERE tk.matk = @matk)

	IF (@kt_masach = @masach AND @kt_matk = @matk)
	BEGIN
		IF (@soluong > 0)
		BEGIN
			IF NOT EXISTS (SELECT 1 FROM MuonSach m WHERE m.matk = @matk AND m.masach = @masach AND m.trangthai = 0)
			BEGIN
				INSERT INTO MuonSach(matk, masach, ngaymuon, ngaytra, phuthu, trangthai)
				VALUES (@matk, @masach, @ngaymuon, @ngaytra, @phuthu, @trangthai)
			END
		END
	END
END




GO
/****** Object:  StoredProcedure [dbo].[sp_MuonSach_TimKiemTaiKhoanMuonSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MuonSach_TimKiemTaiKhoanMuonSach]
(	@matk varchar(100),
	@masach varchar(100)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT tk.tentaikhoan, s.masach, s.tieude, s.tacgia, s.soluong, s.trangthai, s.idloaisach
	FROM SACH s, TaiKhoan tk, MuonSach m
	WHERE m.masach = @masach
	AND s.masach = m.masach 
	AND  tk.matk = m.matk
	AND m.matk = @matk

END
GO
/****** Object:  StoredProcedure [dbo].[sp_MuonSach_TraSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MuonSach_TraSach]
	@id int,
	@ngaytra varchar(100),
	@trangthai bit
AS
BEGIN

	DECLARE @ngaymuon date;	
	DECLARE @phuthu int;
	
	SET @ngaymuon = (SELECT m.ngaymuon 
	FROM MuonSach m
		WHERE m.id = @id)

	SET @phuthu = 0
	IF NOT EXISTS (SELECT 1 FROM MuonSach WHERE id = @id AND trangthai = 1) 
	BEGIN 
		IF (DATEDIFF(day, @ngaymuon, @ngaytra) > 5)
		BEGIN
			SET @phuthu = DATEDIFF(day, @ngaymuon, @ngaytra) * 15000
		END

		UPDATE MuonSach
		SET 
		phuthu = @phuthu,
		trangthai = @trangthai,
		ngaytra = @ngaytra
		WHERE id = @id
		END
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Sach_CapNhatSoLuong]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Sach_CapNhatSoLuong]
	@masach varchar(100),
	@trangthai bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @kt_masach varchar(100);
	DECLARE @soluong int;

	SET @kt_masach = (SELECT s.masach
	FROM Sach s
	WHERE s.masach = @masach)

	SET @soluong = (SELECT s.soluong
	FROM Sach s
	WHERE s.masach = @masach)

	IF(@kt_masach = @masach)
	BEGIN
		IF (@trangthai = 1)
		BEGIN
			SET @soluong = @soluong + 1
		END
		ELSE
		BEGIN
			SET @soluong = @soluong - 1
		END

		UPDATE Sach
		SET soluong = @soluong
		WHERE masach = @masach
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Sach_TimKiem_LoaiSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Sach_TimKiem_LoaiSach]
	@LoaiSach int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT masach, tieude, tacgia, idloaisach, soluong, trangthai, ls.tenloaisach
	FROM Sach s, LoaiSach ls
	WHERE s.idloaisach = ls.id and s.idloaisach = @LoaiSach
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Sach_TimKiem_MaSach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Sach_TimKiem_MaSach]
	@MaSach varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT masach, tieude, tacgia, idloaisach, soluong, trangthai, ls.tenloaisach
	FROM Sach s, LoaiSach ls
	WHERE masach LIKE '%' + @MaSach + '%' and s.idloaisach = ls.id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Sach_TimKiem_TacGia]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Sach_TimKiem_TacGia]
	@TacGia nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT masach, tieude, tacgia, idloaisach, soluong, trangthai, ls.tenloaisach
	FROM Sach s, LoaiSach ls
	WHERE tacgia LIKE '%' + @TacGia + '%' and s.idloaisach = ls.id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Sach_TimKiem_TieuDe]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Sach_TimKiem_TieuDe]
	@TieuDe nvarchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT masach, tieude, tacgia, idloaisach, soluong, trangthai, ls.tenloaisach
	FROM Sach s, LoaiSach ls
	WHERE tieude LIKE '%' + @TieuDe + '%' and s.idloaisach = ls.id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_TimKiem_DiaChi]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_TimKiem_DiaChi]
	@diachi nvarchar(max)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM TaiKhoan
	WHERE diachi = @diachi
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_TimKiem_MaTK]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_TimKiem_MaTK]
	@matk nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM TaiKhoan
	WHERE matk LIKE '%' + @matk + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_TimKiem_NgaySinh]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_TimKiem_NgaySinh]
	@ngaysinh date
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM TaiKhoan
	WHERE ngaysinh = @ngaysinh
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_TimKiem_TenTaiKhoan]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_TimKiem_TenTaiKhoan]
	@tentaikhoan nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM TaiKhoan
	WHERE tentaikhoan LIKE '%' + @tentaikhoan + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_TimKiemThongTin]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_TimKiemThongTin]
	-- Add the parameters for the stored procedure here
	@matk varchar(100),
	@tentaikhoan nvarchar(200),
	@ngaysinh varchar(100),
	@diachi nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	IF ((@matk IS NULL) AND (@tentaikhoan IS NULL) AND (@ngaysinh IS NULL) AND (@diachi IS NULL))
	BEGIN
		SELECT tk.matk, tk.tentaikhoan, tk.ngaysinh, tk.diachi, l.id
		FROM TaiKhoan tk, LoaiTaiKhoan l
		WHERE tk.loaitaikhoan = l.id
		ORDER BY tk.matk
	END
	ELSE 
	BEGIN
			SELECT tk.matk, tk.tentaikhoan, tk.ngaysinh, tk.diachi, l.id
			FROM TaiKhoan tk
			INNER JOIN LoaiTaiKhoan l
			ON tk.loaitaikhoan = l.id
			WHERE tk.matk LIKE '%' + @matk + '%'
			AND (tk.tentaikhoan LIKE '%' + @tentaikhoan + '%'
			OR tk.ngaysinh = @ngaysinh
			OR tk.diachi LIKE '%' + @diachi + '%')
			ORDER BY tk.matk
	END
END

EXEC sp_TaiKhoan_TimKiemThongTin 'd','d','02/02/1996','q3'
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_XemTatCaSachMuon]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_XemTatCaSachMuon]
	@matk varchar(100)
AS
BEGIN
	SELECT m.id, m.masach, s.tieude, m.ngaymuon, m.ngaytra, m.phuthu, m.trangthai
	FROM MuonSach m, Sach s
	WHERE matk = @matk AND m.masach = s.masach
	ORDER BY m.ngaymuon DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_XemThongTinTaiKhoan]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_XemThongTinTaiKhoan]
	@matk varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT matk, tendangnhap, tentaikhoan, ngaysinh, diachi
	FROM TaiKhoan
	WHERE matk = @matk
END
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_TimSachMuon]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TaiKhoan_TimSachMuon] (@keyword varchar(200)) 
AS BEGIN
	SELECT m.id, m.masach, s.tieude, m.ngaymuon, m.ngaytra, m.phuthu, m.trangthai
	FROM MuonSach m, Sach s
	WHERE (m.masach = s.masach) AND ( m.masach LIKE '%' + @keyword + '%' OR s.tieude LIKE '%' + @keyword + '%') 
END
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_UpdateThongTinCaNhan]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TaiKhoan_UpdateThongTinCaNhan]  (
	@matk varchar(100),
	@tendangnhap varchar(100),
	@tentaikhoan nvarchar(200),
	@matkhau varchar(100),
	@matkhaumoi varchar(100),
	@ngaysinh varchar(100),
	@diachi nvarchar(max)
)
AS BEGIN
	 IF(@matkhaumoi <> '')
	 BEGIN 
		IF EXISTS (SELECT 1 FROM TaiKhoan WHERE matk = @matk and matkhau = @matkhau)
		BEGIN
			UPDATE TaiKhoan
			SET tendangnhap = @tendangnhap,
				tentaikhoan = @tentaikhoan,
				ngaysinh = @ngaysinh,
				diachi = @diachi,
				matkhau = @matkhaumoi
			WHERE matk = @matk
		END 
	 END ELSE 
	 BEGIN
			UPDATE TaiKhoan
			SET tendangnhap = @tendangnhap,
				tentaikhoan = @tentaikhoan,
				ngaysinh = @ngaysinh,
				diachi = @diachi
			WHERE matk = @matk
	 END
END
GO
/****** Object:  StoredProcedure [dbo].[Them_Sach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Them_Sach](
	@masach varchar(100),
	@tieude nvarchar(500),
	@tacgia nvarchar(200),
	@idloaisach int, 
	@soluong int,
	@trangthai int
)
AS BEGIN 
	 IF NOT EXISTS (SELECT 1 FROM Sach WHERE masach = @masach )
	 BEGIN
		 INSERT INTO Sach(masach, tieude, tacgia, idloaisach, soluong, trangthai)
		 VALUES (@masach, @tieude, @tacgia, @idloaisach, @soluong, @trangthai)
	 END
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Sach]    Script Date: 2/22/2020 10:35:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_Sach](
	@masach varchar(100),
	@tieude nvarchar(500),
	@tacgia nvarchar(200),
	@idloaisach int, 
	@soluong int,
	@trangthai int
)
AS BEGIN 
	 UPDATE Sach 
	 SET masach = @masach, tieude = @tieude, tacgia = @tacgia, idloaisach = @idloaisach, soluong = @soluong, trangthai = @trangthai
	 WHERE masach = @masach
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET  READ_WRITE 
GO
