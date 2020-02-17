/****** Object:  StoredProcedure [dbo].[sp_MuonSach_TimKiem_MaSach]    Script Date: 2/17/2020 10:06:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_MuonSach_TimKiem_MaSach]
	@masach varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT tk.tentaikhoan, s.masach, s.tieude, s.tacgia, s.soluong, s.trangthai, s.idloaisach
	FROM SACH s, TaiKhoan tk, MuonSach m
	WHERE s.masach = m.masach 
	AND m.masach = @masach
	AND  tk.matk = m.matk
END
GO

/****** Object:  StoredProcedure [dbo].[sp_MuonSach_TimKiemMuonSach_MaSach]    Script Date: 2/17/2020 10:07:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_MuonSach_TimKiemMuonSach_MaSach]
	@masach varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT tk.tentaikhoan, m.ngaymuon, m.ngaytra, m.phuthu, m.trangthai
	FROM SACH s, TaiKhoan tk, MuonSach m
	WHERE s.masach = m.masach 
	AND m.masach = @masach
	AND  tk.matk = m.matk
END
GO

/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_CapNhat]    Script Date: 2/17/2020 10:07:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_TaiKhoan_CapNhat]
	@matk varchar(100),
	@tendangnhap varchar(100),
	@matkhau varchar(100),
	@tentaikhoan nvarchar(200),
	@ngaysinh date,
	@diachi nvarchar(max),
	@loaitaikhoan int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE TaiKhoan
	SET 
	tendangnhap = @tendangnhap,
	matkhau = @matkhau,
	tentaikhoan = @tentaikhoan,
	ngaysinh = @ngaysinh,
	diachi = @diachi,
	loaitaikhoan = @loaitaikhoan
	WHERE matk = @matk
END
GO

/****** Object:  StoredProcedure [dbo].[sp_MuonSach_Them]    Script Date: 2/17/2020 10:08:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_MuonSach_Them]
	@matk varchar(100),
	@masach varchar(100),
	@ngaymuon date,
	@ngaytra date,
	@phuthu int,
	@soluong int,
	@trangthai bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF (@soluong > 0)
	BEGIN
		INSERT INTO MuonSach(matk, masach, ngaymuon, ngaytra, phuthu, trangthai)
		VALUES (@matk, @masach, @ngaymuon, @ngaytra, @phuthu, @trangthai)
	END
END
GO

/****** Object:  StoredProcedure [dbo].[sp_MuonSach_TinhPhuThu]    Script Date: 2/17/2020 10:11:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_MuonSach_TinhPhuThu]
	@id int,
	@ngaytra date,
	@trangthai bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @ngaymuon date;	
	DECLARE @phuthu int;
	
	SET @ngaymuon = (SELECT m.ngaymuon 
	FROM MuonSach m
		WHERE m.id = @id)

	SET @phuthu = 0

	IF (DATEDIFF(day, @ngaymuon, @ngaytra) > 5)
	BEGIN
		SET @phuthu = DATEDIFF(day, @ngaymuon, @ngaytra) * 15000
	END

	UPDATE MuonSach
	SET 
	phuthu = @phuthu,
	trangthai = @trangthai
	WHERE id = @id
END
GO