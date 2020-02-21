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
    public partial class DanhSachNguoiMuon : Form
    {
        private MuonSachBusinessLogic muonSachBul = new MuonSachBusinessLogic();
        public DanhSachNguoiMuon()
        {
            InitializeComponent();
        }

        private void DanhSachNguoiMuon_Load(object sender, EventArgs e)
        {
            getDsTaiKhoanMuonSach();
        }

        private void getDsTaiKhoanMuonSach()
        {
            txtDSTKMS_tieude.Text = MainForm.thongTinSachDetail.tieude;
            txtDSTKMS_masach.Text = MainForm.thongTinSachDetail.masach;
            txtDSTKMS_tacgia.Text = MainForm.thongTinSachDetail.tacgia;
            var result = muonSachBul.DsTaiKhoanMuonSach(txtDSTKMS_masach.Text);
            dataDSTKMS.DataSource = result;

        }

        private void btn_DSTKMS_timkiem_Click(object sender, EventArgs e)
        {
            if (txtDSTKMS_timkiem_matk.Text != "")
            {
                var result = muonSachBul.TimKiemTaiKhoanMuonSach(txtDSTKMS_masach.Text, txtDSTKMS_timkiem_matk.Text);
                dataDSTKMS.DataSource = result;
                if (result.Count == 0 || result == null)
                    MessageBox.Show("Không có tài khoản nào mượn sách");
            }
        }
    }
}
