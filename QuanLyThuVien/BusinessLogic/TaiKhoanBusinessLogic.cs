using DataAccess;
using DataAccess.parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TaiKhoanBusinessLogic
    {
        private readonly TaiKhoanDataAccess TaikhoanDal = new TaiKhoanDataAccess();

        public DangNhap_TaiKhoan_Result DangNhapTaiKhoan(DangNhapParameter param)
        {
            var result = new DangNhap_TaiKhoan_Result();
            try {
                result = TaikhoanDal.DangNhapTaiKhoan(param).FirstOrDefault();
                if (result != null)
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        public bool DangKyTaiKhoan(DangKyTaiKhoanParameter param)
        {
            var result = false;
            try
            {
                result = TaikhoanDal.DangKyTaiKhoan(param);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<sp_TaiKhoan_XemTatCaSachMuon_Result> XemTatCaCacSachMuon(string matk)
        {
            var result = new List<sp_TaiKhoan_XemTatCaSachMuon_Result>();
            try
            {
                result = TaikhoanDal.XemTatCaCacSachMuon(matk);
                if (result != null)
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        public List<TaiKhoan_TimSachMuon_Result> TimSachMuon(string keyword)
        {
            var result = new List<TaiKhoan_TimSachMuon_Result>();
            try
            {
                result = TaikhoanDal.TimSachMuon(keyword);
                if (result != null)
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
        public bool UpdateThongTinCaNhan(TaikhoanParameter param, string matkhaumoi)
        {
            var result = false;
            try
            {
                result = TaikhoanDal.UpdateThongTinCaNhan(param, matkhaumoi);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<sp_TaiKhoan_TimKiemThongTin_Result> GetTaiKhoanTimKiem(TaikhoanParameter param)
        {
            var result = new List<sp_TaiKhoan_TimKiemThongTin_Result>();
            try
            {
                result = TaikhoanDal.GetTaiKhoanTimKiem(param);
                if (result != null)
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
    }
}
