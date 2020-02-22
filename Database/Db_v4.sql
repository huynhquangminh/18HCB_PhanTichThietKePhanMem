USE [QuanLyThuVien_PTTKPM]
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_TimKiem]    Script Date: 2/22/2020 3:09:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_TaiKhoan_TimKiem]
	-- Add the parameters for the stored procedure here
	@matk varchar(100),
	@tentaikhoan nvarchar(200),
	@ngaysinh date,
	@diachi nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	IF ((@matk IS NULL) AND (@tentaikhoan IS NULL) AND (@ngaysinh IS NULL) AND (@diachi IS NULL))
	BEGIN
		SELECT tk.matk, tk.tentaikhoan, tk.ngaysinh, tk.diachi, l.LoaiTaiKhoan
		FROM TaiKhoan tk, LoaiTaiKhoan l
	END
	ELSE 
	BEGIN
			SELECT DISTINCT tk.matk, tk.tentaikhoan, tk.ngaysinh, tk.diachi, l.LoaiTaiKhoan
			FROM TaiKhoan tk
			INNER JOIN LoaiTaiKhoan l
			ON tk.loaitaikhoan = l.id
			WHERE tk.matk LIKE '%' + @matk + '%'
			AND (tk.tentaikhoan LIKE '%' + @tentaikhoan + '%'
			OR tk.ngaysinh = @ngaysinh
			OR tk.diachi LIKE '%' + @diachi + '%')
	END
END
