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
    public partial class Register : Form
    {
        private readonly TaiKhoanBusinessLogic taikhoanBus = new TaiKhoanBusinessLogic();
        public Register()
        {
            InitializeComponent();
        }

        private void btnTKDK_clear_Click(object sender, EventArgs e)
        {
            txtTKDK_tendangnhap.Text = "";
            txtTKDK_matkhau.Text = "";
            txtTKDK_nhaplaimatkhau.Text = "";
            txtTKDK_tentaikhoan.Text = "";
            txtTKDK_diachi.Text = "";
            dateTKDK_ngaysinh.Text = "";
            lbTKDK_thongbao.Visible = false;
            lbTKDK_thongbao2.Visible = false;
        }

        private void btnTKDK_dangky_Click(object sender, EventArgs e)
        {
            if (vailidateInput())
            {
                if (comparePass())
                {
                    DateTime aDate = DateTime.Now;
                    var strDate = aDate.ToString("HHmm");
                    var strNgaySinh = DateTime.Parse(dateTKDK_ngaysinh.Text).ToString("yyyyMMdd");
                    var param = new DangKyTaiKhoanParameter() {
                        matk = "DG"+ strNgaySinh+ strDate,
                        tendangnhap = txtTKDK_tendangnhap.Text,
                        matkhau = txtTKDK_matkhau.Text,
                        tentaikhoan = txtTKDK_tentaikhoan.Text,
                        ngaysinh = dateTKDK_ngaysinh.Text,
                        diachi = txtTKDK_diachi.Text,
                        loaitaikhoan = 2
                    };
                    var result = taikhoanBus.DangKyTaiKhoan(param);
                    var textMessage = result ? "Đăng ký thành công, vui lòng đăng nhập với tài khoản mới" : "Đăng ký thất bại!";
                    MessageBox.Show(textMessage);
                    //this.Hide();
                    this.Close();
                } else
                {
                    lbTKDK_thongbao2.Visible = true;
                }
            } else
            {
                lbTKDK_thongbao.Visible = true;
            }
        }

        private bool vailidateInput()
        {
            if (txtTKDK_tendangnhap.Text == "" || txtTKDK_matkhau.Text == "" || txtTKDK_nhaplaimatkhau.Text == "" || txtTKDK_tentaikhoan.Text == "" || txtTKDK_diachi.Text == "" || dateTKDK_ngaysinh.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool comparePass()
        {
            if (txtTKDK_matkhau.Text == txtTKDK_nhaplaimatkhau.Text)
            {
                return true;
            }
            return false;
        }
    }
}
