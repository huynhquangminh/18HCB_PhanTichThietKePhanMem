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
            if(Login.thongtintaikhoan.loaitaikhoan == 2)
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

            if (Login.thongtintaikhoan.loaitaikhoan == 3 && Login.thongtintaikhoan.loaitaikhoan == 4)
            {
                ((Control)this.tabChucnangnguoidung).Enabled = false;
                tabManager.SelectedTab = tabQuanlysach;
            }
        }

        private void tabManager_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if(Login.thongtintaikhoan.loaitaikhoan == 2)
            {
                MessageBox.Show("tabChucnangnguoidung");
            }
            if (Login.thongtintaikhoan.loaitaikhoan == 1)
            {
                MessageBox.Show("tabQuanlytaikhoan");
            }
            if (Login.thongtintaikhoan.loaitaikhoan == 3 &&  Login.thongtintaikhoan.loaitaikhoan == 4)
            {
                MessageBox.Show("tabQuanlysach");
            }

        }
    }
}
