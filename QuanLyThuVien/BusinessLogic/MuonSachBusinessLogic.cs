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
    public class MuonSachBusinessLogic
    {
        private MuonSachDataAccess muonSachDal = new MuonSachDataAccess();

        public List<MuonSach_DsTaiKhoanMuonSach_Result> DsTaiKhoanMuonSach(string masach)
        {
            var result = new List<MuonSach_DsTaiKhoanMuonSach_Result>();
            try
            {
                result = muonSachDal.DsTaiKhoanMuonSach(masach);
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

        public List<MuonSach_TimKiemTaiKhoanMuonSach_Result> TimKiemTaiKhoanMuonSach(string masach, string matk)
        {
            var result = new List<MuonSach_TimKiemTaiKhoanMuonSach_Result>();
            try
            {
                result = muonSachDal.TimKiemTaiKhoanMuonSach(masach, matk);
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

        public List<MuonSach_DanhSachMuonSachAll_Result> GetDanhSachMuonSachAll()
        {
            var result = new List<MuonSach_DanhSachMuonSachAll_Result>();
            try
            {
                result = muonSachDal.GetDanhSachMuonSachAll();
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

        public bool MuonSach(MuonSachParameter param)
        {
            var result = false;
            try
            {
                result = muonSachDal.MuonSach(param);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool TraMuonSach(MuonSachParameter param)
        {
            var result = false;
            try
            {
                result = muonSachDal.TraMuonSach(param);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
