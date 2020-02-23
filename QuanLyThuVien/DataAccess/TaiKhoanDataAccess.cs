using DataAccess.parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TaiKhoanDataAccess
    {
        QuanLyThuVien_PTTKPMEntities db = new QuanLyThuVien_PTTKPMEntities();

        public List<DangNhap_TaiKhoan_Result> DangNhapTaiKhoan(DangNhapParameter param)
        {
            return db.DangNhap_TaiKhoan(param.tendangnhap, param.matkhau).ToList();
        }

        public bool DangKyTaiKhoan(DangKyTaiKhoanParameter param)
        {
            var result = db.DangKy_TaiKhoan(param.matk, param.tendangnhap, param.matkhau, param.tentaikhoan, param.ngaysinh, param.diachi, param.loaitaikhoan);
            return result > 0 ? true : false;
        }

        public List<sp_TaiKhoan_XemTatCaSachMuon_Result> XemTatCaCacSachMuon(string matk)
        {
            return db.sp_TaiKhoan_XemTatCaSachMuon(matk).ToList();
        }

        public List<TaiKhoan_TimSachMuon_Result> TimSachMuon(string keyword)
        {
            return db.TaiKhoan_TimSachMuon(keyword).ToList();
        }

        public bool UpdateThongTinCaNhan(TaikhoanParameter param, string matkhaumoi)
        {
            var result = db.TaiKhoan_UpdateThongTinCaNhan(param.matk, param.tendangnhap, param.tentaikhoan, param.matkhau, matkhaumoi, param.ngaysinh, param.diachi);
            return result > 0 ? true : false;
        }

        public List<Taikhoan_TimKiemThongTin_Result> GetTaiKhoanTimKiem (TaikhoanParameter param)
        {
            return db.Taikhoan_TimKiemThongTin(param.matk, param.tentaikhoan, param.diachi).ToList();
        }

        public List<GETALLTAIKHOAN_Result> GetDsTaiKhoanAll()
        {
            return db.GETALLTAIKHOAN().ToList();
        }

        public bool ThemTaiKhoan (TaikhoanParameter param)
        {
            var result = db.TaiKhoan_Them(param.matk, param.tendangnhap, param.matkhau, param.tentaikhoan, param.ngaysinh, param.diachi, param.loaitaikhoan);
            return result > 0 ? true : false;
        }

        public bool XoaTaiKhoan(string matk, int? loaitaikhoan)
        {
            var result = db.TaiKhoan_Xoa(matk, loaitaikhoan);
            return result > 0 ? true : false;
        }

        public bool CapNhapThongTinTaiKhoan (string matk, string tentaikhoan, string ngaysinh, string diachi)
        {
            var result = db.sp_TaiKhoan_CapNhat(matk, tentaikhoan, ngaysinh, diachi);
            return result > 0 ? true : false;
        }
    }
}
