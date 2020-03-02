using BusinessLogic;
using DataAccess.parameter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Layout
{
    public partial class MainForm : Form
    {
        private readonly SachBusinessLogic sachBus = new SachBusinessLogic();
        private readonly MuonSachBusinessLogic muonSachBus = new MuonSachBusinessLogic();
        private readonly TaiKhoanBusinessLogic taikhoanBus = new TaiKhoanBusinessLogic();
        public static TaikhoanParameter thongTinTaiKhoanDetail = new TaikhoanParameter();
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
                cbbCNND_loaisach.ValueMember = "id";
                cbbCNND_loaisach.DisplayMember = "tenloaisach";
                cbbCNND_loaisach.DataSource = sachBus.GetAll_LoaiSach(); ;
            }
            if (Login.thongtintaikhoan.loaitaikhoan == 1)
            {
                ((Control)this.tabQuanlysach).Enabled = false;
                ((Control)this.tabThuvien).Enabled = false;
                ((Control)this.tabChucnangnguoidung).Enabled = false;
                tabManager.SelectedTab = tabQuanlytaikhoan;
                GetDsTaiKhoanTimKiemAll();
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
                GetDsTaiKhoanTimKiemAll();
            }
        }

        private void tabManager_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (Login.thongtintaikhoan.loaitaikhoan == 2)
            {
                dataQLND.DataSource = sachBus.GetAllSach();
            }
            if (Login.thongtintaikhoan.loaitaikhoan == 1)
            {
                GetDsTaiKhoanTimKiemAll();
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
                    sachBus.CapNhapSoLuongSach(txtMuonSach_masach.Text, false);
                    GetDSMuonSachAll();
                    textMessage = "Mượn sách thành công!";
                    txtMuonSach_masach.Text = "";
                    txtMuonSach_matk.Text = "";
                } else
                {
                    textMessage = "Mượn sách thất bại vui lòng kiểm tra lại thông tin sách đã mượn";
                }
                MessageBox.Show(textMessage);
            }

        }

        private void btnMuonSach_trasach_Click(object sender, EventArgs e)
        {
            if (idMuonSach != 0 && txtMuonSach_masach.Text != "" && txtMuonSach_matk.Text != "")
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
                    sachBus.CapNhapSoLuongSach(txtMuonSach_masach.Text, true);
                    GetDSMuonSachAll();
                    MessageBox.Show("Trả sách thành công .Vui lòng thanh toán nếu có phụ thu!");
                    txtMuonSach_masach.Text = "";
                    txtMuonSach_matk.Text = "";
                    idMuonSach = 0;
                }
            }
            else
            {
                MessageBox.Show("Thông tin trả sách thiếu!");
            }
        }

        private void dataMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataMuonSach.CurrentRow.Index;
            idMuonSach = Convert.ToInt32(dataMuonSach.Rows[i].Cells[0].Value);
            txtMuonSach_masach.Text = dataMuonSach.Rows[i].Cells[3].Value.ToString();
            txtMuonSach_matk.Text = dataMuonSach.Rows[i].Cells[1].Value.ToString();
        }

        private void btnMuonSach_huymuonsach_Click(object sender, EventArgs e)
        {
            if (idMuonSach != 0 && txtMuonSach_masach.Text != "" && txtMuonSach_matk.Text != "")
            {
                var dialogResult = MessageBox.Show("Bạn có muốn hủy mượn sách này không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = muonSachBus.HuyMuonSach(idMuonSach);
                    sachBus.CapNhapSoLuongSach(txtMuonSach_masach.Text, true);
                    GetDSMuonSachAll();
                    MessageBox.Show("Hủy sách thành công!", "Thông báo");
                    txtMuonSach_masach.Text = "";
                    txtMuonSach_matk.Text = "";
                    idMuonSach = 0;
                }
            }
        }

        private void dataQLND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var resultListSach = sachBus.GetAllSach();
                var masach = resultListSach[e.RowIndex].masach;
                var dialogResult = MessageBox.Show("Bạn có muốn mượn cuốn sách này không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var param = new MuonSachParameter()
                    {
                        matk = Login.thongtintaikhoan.matk,
                        masach = masach,
                        ngaymuon = DateTime.Now.ToString("yyyy/MM/dd"),
                        ngaytra = null,
                        phuthu = 0,
                        trangthai = false
                    };
                    var result = muonSachBus.MuonSach(param);
                    if (result == true)
                    {
                        sachBus.CapNhapSoLuongSach(masach, false);
                        MessageBox.Show("Bạn đã mượn thành công!", "Thông báo");
                    } else
                    {
                        MessageBox.Show("Mượn sách thất bại!", "Thông báo");
                    }
                }
            }
        }

        private void btnCNND_lichsumuonsach_Click(object sender, EventArgs e)
        {
            var formLichSuMuonSach = new TaiKhoanMuonSach();
            formLichSuMuonSach.Show();
        }

        private void btnCNND_timkiemtieude_Click(object sender, EventArgs e)
        {
            if (txtCNND_tieude.Text != "")
            {
                var param = new TimkiemSachParameter();
                param.TieuDe = txtCNND_tieude.Text;
                dataQLND.DataSource = sachBus.TimKiemTieuDe_Sach(param);
            }
        }

        private void btnCNND_timkiemmasach_Click(object sender, EventArgs e)
        {
            if (txtCNND_masach.Text != "")
            {
                var param = new TimkiemSachParameter();
                param.MaSach = txtCNND_masach.Text;
                dataQLND.DataSource = sachBus.TimKiemMaSach_Sach(param);
            }
        }

        private void btnCNND_timkiemtacgia_Click(object sender, EventArgs e)
        {
            if (txtCNND_tacgia.Text != "")
            {
                var param = new TimkiemSachParameter();
                param.TacGia = txtCNND_tacgia.Text;
                dataQLND.DataSource = sachBus.TimKiemTacGia_Sach(param);
            }
        }

        private void btnCNND_timkiemloaisach_Click(object sender, EventArgs e)
        {
            var param = new TimkiemSachParameter();
            param.LoaiSach = Convert.ToInt32(cbbCNND_loaisach.SelectedValue);
            dataQLND.DataSource = sachBus.TimKiemLoaiSach_Sach(param);
        }

        private void btnCNND_thongtintaikhoan_Click(object sender, EventArgs e)
        {
            var formThongTinTaiKhoan = new ThongTinTaiKhoan();
            formThongTinTaiKhoan.ShowDialog();
            if (ThongTinTaiKhoan.resultUpdateInfo == true)
            {

                Thread thread = new Thread(new ThreadStart(ShowLoginForm)); //Tạo luồng mới
                thread.Start(); //Khởi chạy luồng
                this.Close();
            }
        }

        private void ShowLoginForm()
        {
            Login formLogin = new Login();
            formLogin.ShowDialog();
        }

        private void GetDsTaiKhoanTimKiemAll()
        {
            dataQLTK.DataSource = taikhoanBus.GetDsTaiKhoanAll();
        }

        private void btnQLTK_timkiem_Click(object sender, EventArgs e)
        {
            if (txtQLTK_timkiem_matk.Text != "" || txtQLTK_timkiem_tentaikhoan.Text != "" || txtQLTK_timkiem_diachi.Text != "")
            {
                var param = new TaikhoanParameter()
                {
                    matk = txtQLTK_timkiem_matk.Text == "" ? null : txtQLTK_timkiem_matk.Text,
                    tentaikhoan = txtQLTK_timkiem_tentaikhoan.Text == "" ? null : txtQLTK_timkiem_tentaikhoan.Text,
                    diachi = txtQLTK_timkiem_diachi.Text == "" ? null : txtQLTK_timkiem_diachi.Text
                };
                dataQLTK.DataSource = taikhoanBus.GetTaiKhoanTimKiem(param);
            }
            else
            {
                GetDsTaiKhoanTimKiemAll();
            }


        }

        private void dataQLTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataQLTK.CurrentRow.Index;
            txtQLTK_thongtin_matk.Text = dataQLTK.Rows[i].Cells[0].Value.ToString();
            txtQLTK_thongtin_tentk.Text = dataQLTK.Rows[i].Cells[1].Value.ToString();
            dateQLTK_ngaysinh.Text = dataQLTK.Rows[i].Cells[2].Value.ToString();
            txtQLTK_thongtin_diachi.Text = dataQLTK.Rows[i].Cells[3].Value.ToString();
        }

        private void btnQLTK_clear_Click(object sender, EventArgs e)
        {
            txtQLTK_thongtin_matk.Text = "";
            txtQLTK_thongtin_tentk.Text = "";
            txtQLTK_thongtin_diachi.Text = "";
        }

        private void btnQLTK_themtk_Click(object sender, EventArgs e)
        {
            if (txtQLTK_thongtin_tentk.Text != "" && txtQLTK_thongtin_diachi.Text != "" || dateQLTK_ngaysinh.Text != "")
            {
                DateTime aDate = DateTime.Now;
                var codeRandom = "TK" + aDate.ToString("MMddHHmmss");
                var param = new TaikhoanParameter()
                {
                    matk = codeRandom,
                    tendangnhap = codeRandom,
                    matkhau = codeRandom,
                    tentaikhoan = txtQLTK_thongtin_tentk.Text,
                    ngaysinh = dateQLTK_ngaysinh.Text,
                    diachi = txtQLTK_thongtin_diachi.Text,
                    loaitaikhoan = 2
                };
                var result = taikhoanBus.ThemTaiKhoan(param);
                if (result == false)
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mã tài khoản không hợp lệ!");
                }
                else
                {
                    GetDsTaiKhoanTimKiemAll();
                }
            }
        }

        private void btnQLTK_xoa_Click(object sender, EventArgs e)
        {
            if (txtQLTK_thongtin_matk.Text != "")
            {
                var dialogResult = MessageBox.Show("Bạn có muốn xóa tai khoản này không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = taikhoanBus.XoaTaiKhoan(txtQLTK_thongtin_matk.Text, Login.thongtintaikhoan.loaitaikhoan);
                    GetDsTaiKhoanTimKiemAll();
                    txtQLTK_thongtin_matk.Text = "";
                    txtQLTK_thongtin_tentk.Text = "";
                    txtQLTK_thongtin_diachi.Text = "";
                }
            }
        }

        private void btnQLTK_update_Click(object sender, EventArgs e)
        {
            if (txtQLTK_thongtin_matk.Text != "")
            {
                var dialogResult = MessageBox.Show("Bạn có muốn cập nhập tài khoản này không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = taikhoanBus.CapNhapThongTinTaiKhoan(txtQLTK_thongtin_matk.Text, txtQLTK_thongtin_tentk.Text, dateQLTK_ngaysinh.Text, txtQLTK_thongtin_diachi.Text);
                    GetDsTaiKhoanTimKiemAll();
                    txtQLTK_thongtin_matk.Text = "";
                    txtQLTK_thongtin_tentk.Text = "";
                    txtQLTK_thongtin_diachi.Text = "";
                }
            }
        }

        private void btnQLTK_xemchitiet_Click(object sender, EventArgs e)
        {
            if(txtQLTK_thongtin_matk.Text != "")
            {
                thongTinTaiKhoanDetail = new TaikhoanParameter()
                {
                    tentaikhoan = txtQLTK_thongtin_tentk.Text,
                    matk = txtQLTK_thongtin_matk.Text,
                    ngaysinh = dateQLTK_ngaysinh.Text,
                    diachi = txtQLTK_thongtin_diachi.Text
                };
                TaiKhoanMuonSach formTKMuonsach = new TaiKhoanMuonSach();
                formTKMuonsach.ShowDialog();
            }
            
        }

        private void btnTV_timkiemthongtinmuonsach_Click(object sender, EventArgs e)
        {
            var tensach = txtTV_timkiem_tensach.Text == "" ? null : txtTV_timkiem_tensach.Text;
             var masach = txtTV_timkiem_masach.Text == "" ? null : txtTV_timkiem_masach.Text;
            var mattk = txtTV_timkiem_matk.Text == "" ? null : txtTV_timkiem_matk.Text;
            var result = muonSachBus.TimKieThongTinMuonSach(tensach, masach, mattk);
            dataMuonSach.DataSource = result;
        }

        private void btnTV_timkiemtheodate_Click(object sender, EventArgs e)
        {
            var result = muonSachBus.TimKieThongTinMuonSachTheoDate(dateTV_start.Text, dateTV_end.Text);
            dataMuonSach.DataSource = result;
        }

        private void dataMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                var resultListMuonSach = muonSachBus.GetDanhSachMuonSachAll();
                var matk = resultListMuonSach[e.RowIndex].matk;
                var tentaikhoan = resultListMuonSach[e.RowIndex].tentaikhoan;
                var masach = resultListMuonSach[e.RowIndex].masach;
                var tensach = resultListMuonSach[e.RowIndex].tieude;
                var ngaymuon = resultListMuonSach[e.RowIndex].ngaymuon;
                var dialogResult = MessageBox.Show("Bạn có muốn in phiếu mượn sách không!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    muonSachBus.downloadPhieuMuonSach(matk, tentaikhoan, masach, tensach, ngaymuon.ToString());
                }
            }
        }
    }
}
