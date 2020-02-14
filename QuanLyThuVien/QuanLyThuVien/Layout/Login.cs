using BusinessLogic;
using DataAccess.parameter;
using EntityData;
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
    public partial class Login : Form
    {
        private readonly TaiKhoanBusinessLogic taikhoanBus = new TaiKhoanBusinessLogic();
        public static DangNhap_TaiKhoan_Result thongtintaikhoan = new DangNhap_TaiKhoan_Result();
        public Login()
        {
            InitializeComponent();
        }

        private void btnTK_clear_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void linkTK_dangkytaikhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register dangkyForm = new Register();
            dangkyForm.Show();
        }

        private void btnTK_dangnhap_Click(object sender, EventArgs e)
        {
            var param = new DangNhapParameter();
            if (txtTK_tendangnhap.Text != "" && txtTK_matkhau.Text != "")
            {
                param.tendangnhap = txtTK_tendangnhap.Text;
                param.matkhau = txtTK_matkhau.Text;
                var result = taikhoanBus.DangNhapTaiKhoan(param);
                if (result != null)
                {
                    thongtintaikhoan = result;
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();

                } else
                {
                    lbTK_thongbaodangnhap.Visible = true;
                }
            } else
            {
                lbTK_thongbaodulieusai.Visible = true;
            }
        }

        private void clearInput()
        {
            txtTK_tendangnhap.Text = "";
            txtTK_matkhau.Text = "";
            lbTK_thongbaodangnhap.Visible = false;
            lbTK_thongbaodulieusai.Visible = false;
        }
    }
}
