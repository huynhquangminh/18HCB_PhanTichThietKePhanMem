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
   public class SachBusinessLogic
    {
        private readonly SachDataAccess SachDal = new SachDataAccess();

        public List<GetAll_Sach_Result> GetAllSach()
        {

            var result = new List<GetAll_Sach_Result>();
            try
            {
                result = SachDal.GetAllSach();
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

        public List<sp_Sach_TimKiem_TieuDe_Result> TimKiemTieuDe_Sach(TimkiemSachParameter param)
        {

            var result = new List<sp_Sach_TimKiem_TieuDe_Result>();
            try
            {
                result = SachDal.TimKiemTieuDe_Sach(param);
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

        public List<sp_Sach_TimKiem_MaSach_Result> TimKiemMaSach_Sach(TimkiemSachParameter param)
        {

            var result = new List<sp_Sach_TimKiem_MaSach_Result>();
            try
            {
                result = SachDal.TimKiemMaSach_Sach(param);
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

        public List<sp_Sach_TimKiem_TacGia_Result> TimKiemTacGia_Sach(TimkiemSachParameter param)
        {

            var result = new List<sp_Sach_TimKiem_TacGia_Result>();
            try
            {
                result = SachDal.TimKiemTacGia_Sach(param);
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

        public List<sp_Sach_TimKiem_LoaiSach_Result> TimKiemLoaiSach_Sach(TimkiemSachParameter param)
        {

            var result = new List<sp_Sach_TimKiem_LoaiSach_Result>();
            try
            {
                result = SachDal.TimKiemLoaiSach_Sach(param);
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

        public List<GetAll_LoaiSach_Result> GetAll_LoaiSach ()
        {
            var result = new List<GetAll_LoaiSach_Result>();
            try
            {
                result = SachDal.GetAll_LoaiSach();
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

        public bool Them_Sach(SachParameter param)
        {
            var result = false;
            try
            {
                result = SachDal.Them_Sach(param);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete_Sach(SachParameter param)
        {
            var result = false;
            try
            {
                result = SachDal.Delete_Sach(param);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update_Sach(SachParameter param)
        {
            var result = false;
            try
            {
                result = SachDal.Update_Sach(param);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapNhapSoLuongSach(string masach, bool trangthai)
        {
            var result = false;
            try
            {
                result = SachDal.CapNhapSoLuongSach(masach, trangthai);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
