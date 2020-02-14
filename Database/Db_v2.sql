USE [master]
GO
/****** Object:  Database [QuanLyThuVien_PTTKPM]    Script Date: 2/14/2020 10:25:26 AM ******/
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
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 2/14/2020 10:25:26 AM ******/
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
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 2/14/2020 10:25:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiTaiKhoan] [varchar](100) NOT NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MuonSach]    Script Date: 2/14/2020 10:25:26 AM ******/
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
/****** Object:  Table [dbo].[Sach]    Script Date: 2/14/2020 10:25:26 AM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/14/2020 10:25:26 AM ******/
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
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] ON 

INSERT [dbo].[LoaiTaiKhoan] ([id], [LoaiTaiKhoan]) VALUES (1, N'admin')
INSERT [dbo].[LoaiTaiKhoan] ([id], [LoaiTaiKhoan]) VALUES (2, N'docgia')
INSERT [dbo].[LoaiTaiKhoan] ([id], [LoaiTaiKhoan]) VALUES (3, N'nhanvienthuvien')
INSERT [dbo].[LoaiTaiKhoan] ([id], [LoaiTaiKhoan]) VALUES (4, N'thuthu')
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] OFF
INSERT [dbo].[TaiKhoan] ([matk], [tendangnhap], [matkhau], [tentaikhoan], [ngaysinh], [diachi], [loaitaikhoan]) VALUES (N'DG0001', N'docgia1', N'1234', N'docgia1', CAST(N'1996-02-10' AS Date), N'xxxx', 2)
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
/****** Object:  StoredProcedure [dbo].[DangKy_TaiKhoan]    Script Date: 2/14/2020 10:25:26 AM ******/
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
/****** Object:  StoredProcedure [dbo].[DangNhap_TaiKhoan]    Script Date: 2/14/2020 10:25:26 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAll_Sach]    Script Date: 2/14/2020 10:25:26 AM ******/
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
USE [master]
GO
ALTER DATABASE [QuanLyThuVien_PTTKPM] SET  READ_WRITE 
GO
