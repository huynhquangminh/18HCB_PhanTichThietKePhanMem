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
    public partial class ThongTinTaiKhoan : Form
    {
        private TaiKhoanBusinessLogic taikhoanBus = new TaiKhoanBusinessLogic();
        public static bool resultUpdateInfo = false;
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTTTK_tentaikhoan.Text = Login.thongtintaikhoan.tentaikhoan;
            txtTTTK_tendangnhap.Text = Login.thongtintaikhoan.tendangnhap;
            txtTTTK_matkhau.Text = Login.thongtintaikhoan.matkhau;
            cbTTTK_doimatkhau.Checked = false;
            txtTTTK_matkhaumoi.Text = "";
            dateTTTK_ngaysinh.Text = Login.thongtintaikhoan.ngaysinh.ToString("dd/MM/yyyy");
            txtTTTK_diachi.Text = Login.thongtintaikhoan.diachi;
            lbTTTK_thongbaonhapmk.Visible = false;
        }

        private void cbTTTK_doimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTTTK_doimatkhau.Checked == true)
            {
                txtTTTK_matkhau.Text = "";
                txtTTTK_matkhau.ReadOnly = false;
                txtTTTK_matkhaumoi.ReadOnly = false;
                lbTTTK_thongbaonhapmk.Visible = true;
            } else
            {
                txtTTTK_matkhau.Text = Login.thongtintaikhoan.matkhau;
                txtTTTK_matkhaumoi.Text = "";
                txtTTTK_matkhau.ReadOnly = true;
                txtTTTK_matkhaumoi.ReadOnly = true;
                lbTTTK_thongbaonhapmk.Visible = false;
            }
        }

        private void btnTTTK_updatethongtin_Click(object sender, EventArgs e)
        {
            if(validateThongTinTaiKhoan())
            {
                var param = new TaikhoanParameter()
                {
                    matk = Login.thongtintaikhoan.matk,
                    tendangnhap = txtTTTK_tendangnhap.Text,
                    tentaikhoan = txtTTTK_tentaikhoan.Text,
                    matkhau = txtTTTK_matkhau.Text,
                    ngaysinh = dateTTTK_ngaysinh.Text,
                    diachi = txtTTTK_diachi.Text  

                 };
                var result = taikhoanBus.UpdateThongTinCaNhan(param, txtTTTK_matkhaumoi.Text);
                if(result == true)
                {
                    resultUpdateInfo = true;
                    MessageBox.Show("Cập nhập thông tin thành công, vui lòng đănng nhập lại!", "Thông báo");
                    this.Close();
                    //MainForm mainForm = new MainForm();
                    //mainForm.Closed += (s, args) => this.Close();
                    //mainForm.Hide();
                    //Login loginForm = new Login();
                    //loginForm.Closed += (s, args) => this.Close();
                    //loginForm.Show();
                } else
                {
                    MessageBox.Show("Cập nhập thông tin thất bại, vui lòng kiểm tra lại!", "Thông báo");
                }
            } else
            {
                lbTTTK_thongbavalidate.Visible = true;
            }
        }

        private bool validateThongTinTaiKhoan ()
        {
            if(cbTTTK_doimatkhau.Checked == true && txtTTTK_matkhaumoi.Text == "")
            {
                return false;
            }
            if (txtTTTK_tentaikhoan.Text == "" || txtTTTK_tendangnhap.Text == "" || txtTTTK_matkhau.Text == "" || dateTTTK_ngaysinh.Text == "" || txtTTTK_diachi.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
