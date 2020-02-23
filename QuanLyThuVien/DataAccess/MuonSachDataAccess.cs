using DataAccess.parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MuonSachDataAccess
    {
        QuanLyThuVien_PTTKPMEntities db = new QuanLyThuVien_PTTKPMEntities();

        public List<MuonSach_DsTaiKhoanMuonSach_Result> DsTaiKhoanMuonSach(string masach)
        {
            return db.MuonSach_DsTaiKhoanMuonSach(masach).ToList();
        }

        public List<MuonSach_TimKiemTaiKhoanMuonSach_Result> TimKiemTaiKhoanMuonSach(string masach, string matk)
        {
            return db.MuonSach_TimKiemTaiKhoanMuonSach(masach, matk).ToList();
        }

        public List<MuonSach_DanhSachMuonSachAll_Result> GetDanhSachMuonSachAll()
        {
            return db.MuonSach_DanhSachMuonSachAll().ToList();
        }

        public bool MuonSach(MuonSachParameter param)
        {
            var result = db.sp_MuonSach_Them(param.matk, param.masach, param.ngaymuon, param.ngaytra, param.phuthu, param.trangthai);
            return result > 0 ? true : false;
        }

        public bool TraMuonSach(MuonSachParameter param)
        {
            var result = db.sp_MuonSach_TraSach(param.id, param.ngaytra, param.trangthai);
            return result > 0 ? true : false;
        }

        public bool HuyMuonSach(int id)
        {
            var result = db.MuonSach_HuyMuonSach(id);
            return result > 0 ? true : false;
        }

        public List<TimKiemThongTinMuonSach_Result> TimKieThongTinMuonSach(string tensach, string masach, string matk)
        {
            return db.TimKiemThongTinMuonSach(tensach, masach, matk).ToList();
        }

        public List<TimThongTinMuonSachTheoDate_Result> TimKieThongTinMuonSachTheoDate(string dateStart, string dateEnd)
        {
            return db.TimThongTinMuonSachTheoDate(dateStart, dateEnd).ToList();
        }

    }
}
