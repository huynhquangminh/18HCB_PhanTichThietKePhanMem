USE [QuanLyThuVien_PTTKPM]
GO

/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_CapNhat]    Script Date: 2/22/2020 7:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_TaiKhoan_CapNhat]
	@matk varchar(100),
	@tendangnhap varchar(100),
	@tentaikhoan nvarchar(200),
	@ngaysinh date,
	@diachi nvarchar(max),
	@loaitaikhoan int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @kt_matk varchar(100)
	SET @kt_matk = (
		SELECT matk
		FROM TaiKhoan
		WHERE matk = @matk
	)

	-- Kiểm tra tài khoản có tồn tại hay không
	IF (@kt_matk IS NOT NULL)
	BEGIN
		IF(@matk IS NOT NULL)
		BEGIN
			UPDATE TaiKhoan
			SET 
				tendangnhap = @tendangnhap,
				tentaikhoan = @tentaikhoan,
				ngaysinh = @ngaysinh,
				diachi = @diachi,
				loaitaikhoan = @loaitaikhoan
			WHERE matk = @matk
		END
	END
END

/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_Them]    Script Date: 2/22/2020 7:59:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TaiKhoan_Them]
	@matk varchar(100),
	@tendangnhap varchar(100),
	@matkhau varchar(100),
	@tentaikhoan nvarchar(200),
	@ngaysinh date,
	@diachi nvarchar(max),
	@loaitaikhoan int 
AS
BEGIN

	DECLARE @kt_matk varchar(100)
	SET @kt_matk = (
		SELECT matk
		FROM TaiKhoan
		WHERE matk = @matk
	)

	-- Kiểm tra tài khoản có tồn tại hay không
	IF (@kt_matk IS NULL)
	BEGIN
		IF(@matk IS NOT NULL)
		BEGIN
			INSERT INTO TaiKhoan(matk, tendangnhap, matkhau, tentaikhoan, ngaysinh, diachi, loaitaikhoan)
			VALUES (@matk, @tendangnhap, @matkhau, @tentaikhoan, @ngaysinh, @diachi, @loaitaikhoan)
		END
	END
END
GO

/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_Xoa]    Script Date: 2/22/2020 7:59:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TaiKhoan_Xoa]
	@matk varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @kt_matk varchar(100)
	SET @kt_matk = (
		SELECT matk
		FROM TaiKhoan
		WHERE matk = @matk
	)

	-- Kiểm tra tài khoản có tồn tại hay không
	IF (@kt_matk IS NOT NULL)
	BEGIN
		IF(@matk IS NOT NULL)
		BEGIN
			DELETE FROM TaiKhoan
			WHERE matk = @matk
		END
	END
END