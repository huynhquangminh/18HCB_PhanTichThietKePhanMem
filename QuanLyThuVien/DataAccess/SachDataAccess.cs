using DataAccess.parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SachDataAccess
    {
        QuanLyThuVien_PTTKPMEntities db = new QuanLyThuVien_PTTKPMEntities();

        public List<GetAll_Sach_Result> GetAllSach()
        {
            return db.GetAll_Sach().ToList();
        }

        public List<sp_Sach_TimKiem_TieuDe_Result> TimKiemTieuDe_Sach(TimkiemSachParameter param)
        {
            return db.sp_Sach_TimKiem_TieuDe(param.TieuDe).ToList();
        }

        public List<sp_Sach_TimKiem_MaSach_Result> TimKiemMaSach_Sach(TimkiemSachParameter param)
        {
            return db.sp_Sach_TimKiem_MaSach(param.MaSach).ToList();
        }

        public List<sp_Sach_TimKiem_TacGia_Result> TimKiemTacGia_Sach(TimkiemSachParameter param)
        {
            return db.sp_Sach_TimKiem_TacGia(param.TacGia).ToList();
        }

        public List<sp_Sach_TimKiem_LoaiSach_Result> TimKiemLoaiSach_Sach(TimkiemSachParameter param)
        {
            return db.sp_Sach_TimKiem_LoaiSach(param.LoaiSach).ToList();
        }

        public List<GetAll_LoaiSach_Result> GetAll_LoaiSach()
        {
            return db.GetAll_LoaiSach().ToList();
        }

        public bool Them_Sach(SachParameter param)
        {
            var result = db.Them_Sach(param.masach, param.tieude, param.tacgia, param.idloaisach, param.soluong, param.trangthai);
            return result > 0 ? true : false;
        }

        public bool Update_Sach(SachParameter param)
        {
            var result = db.Update_Sach(param.masach, param.tieude, param.tacgia, param.idloaisach, param.soluong, param.trangthai);
            return result > 0 ? true : false;
        }

        public bool Delete_Sach(SachParameter param)
        {
            var result = db.Delete_Sach(param.masach);
            return result > 0 ? true : false;
        }

        public bool CapNhapSoLuongSach(string masach, bool trangthai)
        {
            var result = db.sp_Sach_CapNhatSoLuong(masach, trangthai);
            return result > 0 ? true : false;
        }
    }
}
