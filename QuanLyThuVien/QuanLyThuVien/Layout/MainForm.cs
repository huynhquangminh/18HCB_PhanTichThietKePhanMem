using BusinessLogic;
using DataAccess.parameter;
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
    public partial class MainForm : Form
    {
        private readonly SachBusinessLogic sachBus = new SachBusinessLogic();
        private readonly MuonSachBusinessLogic muonSachBus = new MuonSachBusinessLogic();
        public static SachParameter thongTinSachDetail = new SachParameter();
        private int idMuonSach = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var thongtin = Login.thongtintaikhoan;
            checkTypeLogin();
            //((Control)this.tabThuvien).Enabled = false;
        }

        private void checkTypeLogin()
        {
            if (Login.thongtintaikhoan.loaitaikhoan == 2)
            {
                ((Control)this.tabQuanlysach).Enabled = false;
                ((Control)this.tabQuanlytaikhoan).Enabled = false;
                ((Control)this.tabThuvien).Enabled = false;
                tabManager.SelectedTab = tabChucnangnguoidung;
            }
            if (Login.thongtintaikhoan.loaitaikhoan == 1)
            {
                ((Control)this.tabQuanlysach).Enabled = false;
                ((Control)this.tabThuvien).Enabled = false;
                ((Control)this.tabChucnangnguoidung).Enabled = false;
                tabManager.SelectedTab = tabQuanlytaikhoan;
            }

            if (Login.thongtintaikhoan.loaitaikhoan == 3 || Login.thongtintaikhoan.loaitaikhoan == 4)
            {
                ((Control)this.tabChucnangnguoidung).Enabled = false;
                tabManager.SelectedTab = tabQuanlysach;
                dataSach_QuanLySach.DataSource = sachBus.GetAllSach();
                cbbQLS_timkiem_loaisach.ValueMember = "id";
                cbbQLS_timkiem_loaisach.DisplayMember = "tenloaisach";
                cbbQLS_timkiem_loaisach.DataSource = sachBus.GetAll_LoaiSach();
                cbbQLS_thongtin_loaisach.ValueMember = "id";
                cbbQLS_thongtin_loaisach.DisplayMember = "tenloaisach";
                cbbQLS_thongtin_loaisach.DataSource = cbbQLS_timkiem_loaisach.DataSource;
            }
        }

        private void tabManager_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (Login.thongtintaikhoan.loaitaikhoan == 2)
            {
                MessageBox.Show("tabChucnangnguoidung");
            }
            if (Login.thongtintaikhoan.loaitaikhoan == 1)
            {
                MessageBox.Show("tabQuanlytaikhoan");
            }
            if (Login.thongtintaikhoan.loaitaikhoan == 3 || Login.thongtintaikhoan.loaitaikhoan == 4)
            {
                dataSach_QuanLySach.DataSource = sachBus.GetAllSach();
                GetDSMuonSachAll();
                cbbQLS_timkiem_loaisach.ValueMember = "id";
                cbbQLS_timkiem_loaisach.DisplayMember = "tenloaisach";
                cbbQLS_timkiem_loaisach.DataSource = sachBus.GetAll_LoaiSach();
            }

        }

        private void btnQLS_timkiem_tieude_Click(object sender, EventArgs e)
        {
            if (txtQLS_timkiem_tieude.Text != "")
            {
                var param = new TimkiemSachParameter();
                param.TieuDe = txtQLS_timkiem_tieude.Text;
                dataSach_QuanLySach.DataSource = sachBus.TimKiemTieuDe_Sach(param);
            }
        }

        private void btnQLS_timkiem_masach_Click(object sender, EventArgs e)
        {
            if (txtQLS_timkiem_masach.Text != "")
            {
                var param = new TimkiemSachParameter();
                param.MaSach = txtQLS_timkiem_masach.Text;
                dataSach_QuanLySach.DataSource = sachBus.TimKiemMaSach_Sach(param);
            }
        }

        private void btnQLS_timkiem_tacgia_Click(object sender, EventArgs e)
        {
            if (txtQLS_timkiem_tacgia.Text != "")
            {
                var param = new TimkiemSachParameter();
                param.TacGia = txtQLS_timkiem_tacgia.Text;
                dataSach_QuanLySach.DataSource = sachBus.TimKiemTacGia_Sach(param);
            }
        }

        private void btnQLS_timkiem_loaisach_Click(object sender, EventArgs e)
        {
            var param = new TimkiemSachParameter();
            param.LoaiSach = Convert.ToInt32(cbbQLS_timkiem_loaisach.SelectedValue);
            dataSach_QuanLySach.DataSource = sachBus.TimKiemLoaiSach_Sach(param);

        }

        private void dataSach_QuanLySach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQLS_thongtin_masach.Enabled = false;
            int i;
            i = dataSach_QuanLySach.CurrentRow.Index;
            txtQLS_thongtin_masach.Text = dataSach_QuanLySach.Rows[i].Cells[0].Value.ToString();
            txtQLS_thongtin_tieude.Text = dataSach_QuanLySach.Rows[i].Cells[1].Value.ToString();
            txtQLS_thongtin_tacgia.Text = dataSach_QuanLySach.Rows[i].Cells[2].Value.ToString();
            numQLS_thongtin_soluong.Value = Convert.ToInt32(dataSach_QuanLySach.Rows[i].Cells[3].Value.ToString());
            cbbQLS_thongtin_loaisach.SelectedValue = Convert.ToInt32(dataSach_QuanLySach.Rows[i].Cells[6].Value.ToString());
        }

        private void btnQLS_themmoi_Click(object sender, EventArgs e)
        {
            if (validateSach())
            {
                DateTime aDate = DateTime.Now;
                var strDate = aDate.ToString("yyMMdd");
                var strTime = aDate.ToString("HHmmss");
                txtQLS_thongtin_masach.Text = "MS" + strDate + strTime;
                var param = new SachParameter()
                {
                    masach = "MS" + strDate + strTime,
                    tieude = txtQLS_thongtin_tieude.Text,
                    tacgia = txtQLS_thongtin_tacgia.Text,
                    idloaisach = Convert.ToInt32(cbbQLS_thongtin_loaisach.SelectedValue),
                    soluong = Convert.ToInt32(numQLS_thongtin_soluong.Value),
                    trangthai = 1
                };
                var result = sachBus.Them_Sach(param);
                var message = "Thêm sách Thất bại!";
                if (result)
                {
                    dataSach_QuanLySach.DataSource = sachBus.GetAllSach();
                    message = "Thêm sách thành công!";
                }
                MessageBox.Show(message);

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
        }

        private void btnQLS_chinhsua_Click(object sender, EventArgs e)
        {
            if (validateSach())
            {
                var param = new SachParameter()
                {
                    masach = txtQLS_thongtin_masach.Text,
                    tieude = txtQLS_thongtin_tieude.Text,
                    tacgia = txtQLS_thongtin_tacgia.Text,
                    idloaisach = Convert.ToInt32(cbbQLS_thongtin_loaisach.SelectedValue),
                    soluong = Convert.ToInt32(numQLS_thongtin_soluong.Value),
                    trangthai = 1
                };
                var result = sachBus.Update_Sach(param);
                var message = "Sửa thông tin sách Thất bại!";
                if (result)
                {
                    dataSach_QuanLySach.DataSource = sachBus.GetAllSach();
                    message = "Sửa thông tin sách thành công!";
                }
                MessageBox.Show(message);
            }
        }

        private void btnQLS_xoa_Click(object sender, EventArgs e)
        {
            if (txtQLS_thongtin_masach.Text != "")
            {
                var param = new SachParameter()
                {
                    masach = txtQLS_thongtin_masach.Text
                };
                var dialogResult = MessageBox.Show("Bạn có muốn xóa sách này không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = sachBus.Delete_Sach(param);
                    dataSach_QuanLySach.DataSource = sachBus.GetAllSach();
                    txtQLS_thongtin_masach.Text = "";
                    txtQLS_thongtin_tieude.Text = "";
                    txtQLS_thongtin_tacgia.Text = "";
                    numQLS_thongtin_soluong.Value = 0;
                }
            }
        }

        private void btnQLS_thongtinmuonsach_Click(object sender, EventArgs e)
        {
            if (txtQLS_thongtin_masach.Text != "")
            {
                thongTinSachDetail.masach = txtQLS_thongtin_masach.Text;
                thongTinSachDetail.tieude = txtQLS_thongtin_tieude.Text;
                thongTinSachDetail.tacgia = txtQLS_thongtin_tacgia.Text;
                DanhSachNguoiMuon dsNguoiMuon = new DanhSachNguoiMuon();
                dsNguoiMuon.Show();
            }

        }

        private void GetDSMuonSachAll()
        {
            var result = muonSachBus.GetDanhSachMuonSachAll();
            dataMuonSach.DataSource = result;
        }

        private bool validateSach()
        {
            if (txtQLS_thongtin_tieude.Text == "" || txtQLS_thongtin_tacgia.Text == "" || numQLS_thongtin_soluong.Value <= 0)
            {
                return false;
            }

            return true;
        }

        private void btnMuonSach_muonsach_Click(object sender, EventArgs e)
        {
            if (txtMuonSach_masach.Text != "" && txtMuonSach_matk.Text != "")
            {
                var param = new MuonSachParameter()
                {
                    matk = txtMuonSach_matk.Text,
                    masach = txtMuonSach_masach.Text,
                    ngaymuon = DateTime.Now.ToString("yyyy/MM/dd"),
                    ngaytra = null,
                    phuthu = 0,
                    trangthai = false
                };
                var result = muonSachBus.MuonSach(param);
                var textMessage = "Mượn sách thất bại!";
                if (result)
                {
                    GetDSMuonSachAll();
                    textMessage = "Mượn sách thành công!";
                    txtMuonSach_masach.Text = "";
                    txtMuonSach_matk.Text = "";
                }
                MessageBox.Show(textMessage);
            }

        }

        private void btnMuonSach_trasach_Click(object sender, EventArgs e)
        {
            if(idMuonSach != 0 && txtMuonSach_masach.Text != "" && txtMuonSach_matk.Text != "")
            {
                 var param = new MuonSachParameter()
                {
                    id = idMuonSach,
                    ngaytra = DateTime.Now.ToString("yyyy/MM/dd"),
                    trangthai = true
                };
                var result = muonSachBus.TraMuonSach(param);
                if (result)
                {
                    GetDSMuonSachAll();
                    MessageBox.Show( "Trả sách thành công .Vui lòng thanh toán nếu có phụ thu!");
                    txtMuonSach_masach.Text = "";
                    txtMuonSach_matk.Text = "";
                }
            } else
            {
                MessageBox.Show("Thông tin trả sách thiếu!");
            }
        }

        private void dataMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataMuonSach.CurrentRow.Index;
            idMuonSach =Convert.ToInt32(dataMuonSach.Rows[i].Cells[0].Value);
            txtMuonSach_masach.Text = dataMuonSach.Rows[i].Cells[3].Value.ToString();
            txtMuonSach_matk.Text = dataMuonSach.Rows[i].Cells[1].Value.ToString();
        }
    }
}
