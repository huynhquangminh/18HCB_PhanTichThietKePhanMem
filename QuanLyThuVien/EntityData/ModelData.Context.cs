﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyThuVien_PTTKPMEntities : DbContext
    {
        public QuanLyThuVien_PTTKPMEntities()
            : base("name=QuanLyThuVien_PTTKPMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
        public virtual DbSet<MuonSach> MuonSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
    
        public virtual int DangKy_TaiKhoan(string matk, string tendangnhap, string matkhau, string tentaikhoan, string ngaysinh, string diachi, Nullable<int> loaitaikhoan)
        {
            var matkParameter = matk != null ?
                new ObjectParameter("matk", matk) :
                new ObjectParameter("matk", typeof(string));
    
            var tendangnhapParameter = tendangnhap != null ?
                new ObjectParameter("tendangnhap", tendangnhap) :
                new ObjectParameter("tendangnhap", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            var tentaikhoanParameter = tentaikhoan != null ?
                new ObjectParameter("tentaikhoan", tentaikhoan) :
                new ObjectParameter("tentaikhoan", typeof(string));
    
            var ngaysinhParameter = ngaysinh != null ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var loaitaikhoanParameter = loaitaikhoan.HasValue ?
                new ObjectParameter("loaitaikhoan", loaitaikhoan) :
                new ObjectParameter("loaitaikhoan", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DangKy_TaiKhoan", matkParameter, tendangnhapParameter, matkhauParameter, tentaikhoanParameter, ngaysinhParameter, diachiParameter, loaitaikhoanParameter);
        }
    
        public virtual ObjectResult<DangNhap_TaiKhoan_Result> DangNhap_TaiKhoan(string tendangnhap, string matkhau)
        {
            var tendangnhapParameter = tendangnhap != null ?
                new ObjectParameter("tendangnhap", tendangnhap) :
                new ObjectParameter("tendangnhap", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DangNhap_TaiKhoan_Result>("DangNhap_TaiKhoan", tendangnhapParameter, matkhauParameter);
        }
    
        public virtual ObjectResult<GetAll_LoaiSach_Result> GetAll_LoaiSach()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAll_LoaiSach_Result>("GetAll_LoaiSach");
        }
    
        public virtual ObjectResult<GetAll_Sach_Result> GetAll_Sach()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAll_Sach_Result>("GetAll_Sach");
        }
    
        public virtual ObjectResult<MuonSach_DanhSachMuonSachAll_Result> MuonSach_DanhSachMuonSachAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MuonSach_DanhSachMuonSachAll_Result>("MuonSach_DanhSachMuonSachAll");
        }
    
        public virtual ObjectResult<MuonSach_DsTaiKhoanMuonSach_Result> MuonSach_DsTaiKhoanMuonSach(string masach)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MuonSach_DsTaiKhoanMuonSach_Result>("MuonSach_DsTaiKhoanMuonSach", masachParameter);
        }
    
        public virtual ObjectResult<MuonSach_TimKiemTaiKhoanMuonSach_Result> MuonSach_TimKiemTaiKhoanMuonSach(string masach, string matk)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var matkParameter = matk != null ?
                new ObjectParameter("matk", matk) :
                new ObjectParameter("matk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MuonSach_TimKiemTaiKhoanMuonSach_Result>("MuonSach_TimKiemTaiKhoanMuonSach", masachParameter, matkParameter);
        }
    
        public virtual int sp_MuonSach_Them(string matk, string masach, string ngaymuon, string ngaytra, Nullable<int> phuthu, Nullable<bool> trangthai)
        {
            var matkParameter = matk != null ?
                new ObjectParameter("matk", matk) :
                new ObjectParameter("matk", typeof(string));
    
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var ngaymuonParameter = ngaymuon != null ?
                new ObjectParameter("ngaymuon", ngaymuon) :
                new ObjectParameter("ngaymuon", typeof(string));
    
            var ngaytraParameter = ngaytra != null ?
                new ObjectParameter("ngaytra", ngaytra) :
                new ObjectParameter("ngaytra", typeof(string));
    
            var phuthuParameter = phuthu.HasValue ?
                new ObjectParameter("phuthu", phuthu) :
                new ObjectParameter("phuthu", typeof(int));
    
            var trangthaiParameter = trangthai.HasValue ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MuonSach_Them", matkParameter, masachParameter, ngaymuonParameter, ngaytraParameter, phuthuParameter, trangthaiParameter);
        }
    
        public virtual ObjectResult<sp_MuonSach_TimKiemTaiKhoanMuonSach_Result> sp_MuonSach_TimKiemTaiKhoanMuonSach(string matk, string masach)
        {
            var matkParameter = matk != null ?
                new ObjectParameter("matk", matk) :
                new ObjectParameter("matk", typeof(string));
    
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MuonSach_TimKiemTaiKhoanMuonSach_Result>("sp_MuonSach_TimKiemTaiKhoanMuonSach", matkParameter, masachParameter);
        }
    
        public virtual ObjectResult<sp_MuonSach_XemTatCaSachMuon_TaiKhoan_Result> sp_MuonSach_XemTatCaSachMuon_TaiKhoan(string matk)
        {
            var matkParameter = matk != null ?
                new ObjectParameter("matk", matk) :
                new ObjectParameter("matk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MuonSach_XemTatCaSachMuon_TaiKhoan_Result>("sp_MuonSach_XemTatCaSachMuon_TaiKhoan", matkParameter);
        }
    
        public virtual ObjectResult<sp_Sach_TimKiem_LoaiSach_Result> sp_Sach_TimKiem_LoaiSach(Nullable<int> loaiSach)
        {
            var loaiSachParameter = loaiSach.HasValue ?
                new ObjectParameter("LoaiSach", loaiSach) :
                new ObjectParameter("LoaiSach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Sach_TimKiem_LoaiSach_Result>("sp_Sach_TimKiem_LoaiSach", loaiSachParameter);
        }
    
        public virtual ObjectResult<sp_Sach_TimKiem_MaSach_Result> sp_Sach_TimKiem_MaSach(string maSach)
        {
            var maSachParameter = maSach != null ?
                new ObjectParameter("MaSach", maSach) :
                new ObjectParameter("MaSach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Sach_TimKiem_MaSach_Result>("sp_Sach_TimKiem_MaSach", maSachParameter);
        }
    
        public virtual ObjectResult<sp_Sach_TimKiem_TacGia_Result> sp_Sach_TimKiem_TacGia(string tacGia)
        {
            var tacGiaParameter = tacGia != null ?
                new ObjectParameter("TacGia", tacGia) :
                new ObjectParameter("TacGia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Sach_TimKiem_TacGia_Result>("sp_Sach_TimKiem_TacGia", tacGiaParameter);
        }
    
        public virtual ObjectResult<sp_Sach_TimKiem_TieuDe_Result> sp_Sach_TimKiem_TieuDe(string tieuDe)
        {
            var tieuDeParameter = tieuDe != null ?
                new ObjectParameter("TieuDe", tieuDe) :
                new ObjectParameter("TieuDe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Sach_TimKiem_TieuDe_Result>("sp_Sach_TimKiem_TieuDe", tieuDeParameter);
        }
    
        public virtual int Them_Sach(string masach, string tieude, string tacgia, Nullable<int> idloaisach, Nullable<int> soluong, Nullable<int> trangthai)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var tieudeParameter = tieude != null ?
                new ObjectParameter("tieude", tieude) :
                new ObjectParameter("tieude", typeof(string));
    
            var tacgiaParameter = tacgia != null ?
                new ObjectParameter("tacgia", tacgia) :
                new ObjectParameter("tacgia", typeof(string));
    
            var idloaisachParameter = idloaisach.HasValue ?
                new ObjectParameter("idloaisach", idloaisach) :
                new ObjectParameter("idloaisach", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var trangthaiParameter = trangthai.HasValue ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Them_Sach", masachParameter, tieudeParameter, tacgiaParameter, idloaisachParameter, soluongParameter, trangthaiParameter);
        }
    
        public virtual int Update_Sach(string masach, string tieude, string tacgia, Nullable<int> idloaisach, Nullable<int> soluong, Nullable<int> trangthai)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var tieudeParameter = tieude != null ?
                new ObjectParameter("tieude", tieude) :
                new ObjectParameter("tieude", typeof(string));
    
            var tacgiaParameter = tacgia != null ?
                new ObjectParameter("tacgia", tacgia) :
                new ObjectParameter("tacgia", typeof(string));
    
            var idloaisachParameter = idloaisach.HasValue ?
                new ObjectParameter("idloaisach", idloaisach) :
                new ObjectParameter("idloaisach", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var trangthaiParameter = trangthai.HasValue ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Sach", masachParameter, tieudeParameter, tacgiaParameter, idloaisachParameter, soluongParameter, trangthaiParameter);
        }
    
        public virtual int Delete_Sach(string masach)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Sach", masachParameter);
        }
    
        public virtual int sp_MuonSach_TraSach(Nullable<int> id, string ngaytra, Nullable<bool> trangthai)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var ngaytraParameter = ngaytra != null ?
                new ObjectParameter("ngaytra", ngaytra) :
                new ObjectParameter("ngaytra", typeof(string));
    
            var trangthaiParameter = trangthai.HasValue ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MuonSach_TraSach", idParameter, ngaytraParameter, trangthaiParameter);
        }
    }
}
