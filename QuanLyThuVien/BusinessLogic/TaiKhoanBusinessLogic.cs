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
    }
}
