using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Layout
{
    public partial class TaiKhoanMuonSach : Form
    {
        private TaiKhoanBusinessLogic taikhoanBus = new TaiKhoanBusinessLogic();
        public TaiKhoanMuonSach()
        {
            InitializeComponent();
        }

        private void TaiKhoanMuonSach_Load(object sender, EventArgs e)
        {
            if(Login.thongtintaikhoan.loaitaikhoan == 2)
            {
                txtDSM_tentk.Text = Login.thongtintaikhoan.tentaikhoan;
                txtDSM_matk.Text = Login.thongtintaikhoan.matk;
                txtDSM_diachi.Text = Login.thongtintaikhoan.diachi;
                dateDSM_ngaysinh.Text = Login.thongtintaikhoan.ngaysinh.ToString("dd/MM/yyyy");
                dataTK_dstatcasachmuon.DataSource = taikhoanBus.XemTatCaCacSachMuon(Login.thongtintaikhoan.matk);
            } else
            {
                txtDSM_tentk.Text = MainForm.thongTinTaiKhoanDetail.tentaikhoan;
                txtDSM_matk.Text = MainForm.thongTinTaiKhoanDetail.matk;
                txtDSM_diachi.Text = MainForm.thongTinTaiKhoanDetail.diachi;
                dateDSM_ngaysinh.Text = MainForm.thongTinTaiKhoanDetail.ngaysinh;
                dataTK_dstatcasachmuon.DataSource = taikhoanBus.XemTatCaCacSachMuon(MainForm.thongTinTaiKhoanDetail.matk);
            }
            
        }

        private void btnDSM_timsachmuon_Click(object sender, EventArgs e)
        {
            if(txtDSM_keyword.Text != "")
            {
                dataTK_dstatcasachmuon.DataSource = taikhoanBus.TimSachMuon(txtDSM_keyword.Text);
            }
        }
    }
}
