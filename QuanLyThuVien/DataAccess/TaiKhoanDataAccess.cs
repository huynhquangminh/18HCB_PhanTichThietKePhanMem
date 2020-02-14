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

    }
}
