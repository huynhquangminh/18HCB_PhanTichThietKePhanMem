using DataAccess;
using DataAccess.parameter;
using EntityData;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
        public bool HuyMuonSach(int id)
        {
            var result = false;
            try
            {
                result = muonSachDal.HuyMuonSach(id);
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TimKiemThongTinMuonSach_Result> TimKieThongTinMuonSach(string tensach, string masach, string matk)
        {
            var result = new List<TimKiemThongTinMuonSach_Result>();
            try
            {
                result = muonSachDal.TimKieThongTinMuonSach(tensach, masach, matk);
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

        public List<TimThongTinMuonSachTheoDate_Result> TimKieThongTinMuonSachTheoDate(string dateStart, string dateEnd)
        {
            var result = new List<TimThongTinMuonSachTheoDate_Result>();
            try
            {
                result = muonSachDal.TimKieThongTinMuonSachTheoDate(dateStart, dateEnd);
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

        public void downloadPhieuMuonSach(string matk, string tentaikhoan, string masach, string tensach,string ngaymuon )
        {
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Created with PDFsharp";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Times New Roman", 12, XFontStyle.Bold);
            graph.DrawString("Phiếu mượn sách", font, XBrushes.Black,
            new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            graph.DrawString("Thư viện :ĐH Khoa Học Tự Nhiên TP.Hồ Chí Minh ", font, XBrushes.Black, 40f, 25f);
            graph.DrawString("Mã người mượn : " + matk, font, XBrushes.Black,40f, 40f);
            graph.DrawString("Tên người mượn : " + tentaikhoan, font, XBrushes.Black, 40f, 60f);
            graph.DrawString("Mã sách : " + masach, font, XBrushes.Black, 40f, 80f);
            graph.DrawString("Tên sách : " + tensach, font, XBrushes.Black, 40f, 100f);
            graph.DrawString("Ngày mượn : " + ngaymuon, font, XBrushes.Black, 40f, 120f);
            string filename = "PhieuMuonSach-"+ matk + "-" + masach + "-" + DateTime.Now.ToString("ddMMyyyyHHmm") + ".pdf";
            string currentPath = System.IO.Directory.GetCurrentDirectory();
            if (!System.IO.Directory.Exists(currentPath + "/Phieu_muon_sach"))
            {
                System.IO.Directory.CreateDirectory(currentPath + "/Phieu_muon_sach");
            }
            pdf.Save(currentPath + "/Phieu_muon_sach/" + filename);
        }
    }
}
