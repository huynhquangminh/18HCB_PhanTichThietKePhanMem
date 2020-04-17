namespace QuanLyThuVien.Layout
{
    partial class ThongTinTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTTTK_thongbavalidate = new System.Windows.Forms.Label();
            this.lbTTTK_thongbaonhapmk = new System.Windows.Forms.Label();
            this.btnTTTK_updatethongtin = new System.Windows.Forms.Button();
            this.cbTTTK_doimatkhau = new System.Windows.Forms.CheckBox();
            this.txtTTTK_diachi = new System.Windows.Forms.RichTextBox();
            this.dateTTTK_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTTTK_matkhaumoi = new System.Windows.Forms.TextBox();
            this.txtTTTK_matkhau = new System.Windows.Forms.TextBox();
            this.txtTTTK_tendangnhap = new System.Windows.Forms.TextBox();
            this.txtTTTK_tentaikhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTTTK_thongbavalidate);
            this.panel1.Controls.Add(this.lbTTTK_thongbaonhapmk);
            this.panel1.Controls.Add(this.btnTTTK_updatethongtin);
            this.panel1.Controls.Add(this.cbTTTK_doimatkhau);
            this.panel1.Controls.Add(this.txtTTTK_diachi);
            this.panel1.Controls.Add(this.dateTTTK_ngaysinh);
            this.panel1.Controls.Add(this.txtTTTK_matkhaumoi);
            this.panel1.Controls.Add(this.txtTTTK_matkhau);
            this.panel1.Controls.Add(this.txtTTTK_tendangnhap);
            this.panel1.Controls.Add(this.txtTTTK_tentaikhoan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 406);
            this.panel1.TabIndex = 0;
            // 
            // lbTTTK_thongbavalidate
            // 
            this.lbTTTK_thongbavalidate.AutoSize = true;
            this.lbTTTK_thongbavalidate.ForeColor = System.Drawing.Color.Red;
            this.lbTTTK_thongbavalidate.Location = new System.Drawing.Point(142, 327);
            this.lbTTTK_thongbavalidate.Name = "lbTTTK_thongbavalidate";
            this.lbTTTK_thongbavalidate.Size = new System.Drawing.Size(188, 13);
            this.lbTTTK_thongbavalidate.TabIndex = 7;
            this.lbTTTK_thongbavalidate.Text = "(*) Dữ liệu thông tin không được trống!";
            this.lbTTTK_thongbavalidate.Visible = false;
            // 
            // lbTTTK_thongbaonhapmk
            // 
            this.lbTTTK_thongbaonhapmk.AutoSize = true;
            this.lbTTTK_thongbaonhapmk.ForeColor = System.Drawing.Color.Red;
            this.lbTTTK_thongbaonhapmk.Location = new System.Drawing.Point(142, 305);
            this.lbTTTK_thongbaonhapmk.Name = "lbTTTK_thongbaonhapmk";
            this.lbTTTK_thongbaonhapmk.Size = new System.Drawing.Size(148, 13);
            this.lbTTTK_thongbaonhapmk.TabIndex = 6;
            this.lbTTTK_thongbaonhapmk.Text = "(*) Vui lòng nhập lại mật khẩu!";
            // 
            // btnTTTK_updatethongtin
            // 
            this.btnTTTK_updatethongtin.Location = new System.Drawing.Point(145, 352);
            this.btnTTTK_updatethongtin.Name = "btnTTTK_updatethongtin";
            this.btnTTTK_updatethongtin.Size = new System.Drawing.Size(168, 42);
            this.btnTTTK_updatethongtin.TabIndex = 5;
            this.btnTTTK_updatethongtin.Text = "Thay đổi thông tin ";
            this.btnTTTK_updatethongtin.UseVisualStyleBackColor = true;
            this.btnTTTK_updatethongtin.Click += new System.EventHandler(this.btnTTTK_updatethongtin_Click);
            // 
            // cbTTTK_doimatkhau
            // 
            this.cbTTTK_doimatkhau.AutoSize = true;
            this.cbTTTK_doimatkhau.Location = new System.Drawing.Point(328, 117);
            this.cbTTTK_doimatkhau.Name = "cbTTTK_doimatkhau";
            this.cbTTTK_doimatkhau.Size = new System.Drawing.Size(89, 17);
            this.cbTTTK_doimatkhau.TabIndex = 4;
            this.cbTTTK_doimatkhau.Text = "Đổi mật khẩu";
            this.cbTTTK_doimatkhau.UseVisualStyleBackColor = true;
            this.cbTTTK_doimatkhau.CheckedChanged += new System.EventHandler(this.cbTTTK_doimatkhau_CheckedChanged);
            // 
            // txtTTTK_diachi
            // 
            this.txtTTTK_diachi.Location = new System.Drawing.Point(142, 237);
            this.txtTTTK_diachi.Name = "txtTTTK_diachi";
            this.txtTTTK_diachi.Size = new System.Drawing.Size(236, 61);
            this.txtTTTK_diachi.TabIndex = 3;
            this.txtTTTK_diachi.Text = "";
            // 
            // dateTTTK_ngaysinh
            // 
            this.dateTTTK_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dateTTTK_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTTTK_ngaysinh.Location = new System.Drawing.Point(142, 193);
            this.dateTTTK_ngaysinh.Name = "dateTTTK_ngaysinh";
            this.dateTTTK_ngaysinh.Size = new System.Drawing.Size(171, 20);
            this.dateTTTK_ngaysinh.TabIndex = 2;
            // 
            // txtTTTK_matkhaumoi
            // 
            this.txtTTTK_matkhaumoi.Location = new System.Drawing.Point(142, 154);
            this.txtTTTK_matkhaumoi.Name = "txtTTTK_matkhaumoi";
            this.txtTTTK_matkhaumoi.ReadOnly = true;
            this.txtTTTK_matkhaumoi.Size = new System.Drawing.Size(171, 20);
            this.txtTTTK_matkhaumoi.TabIndex = 1;
            // 
            // txtTTTK_matkhau
            // 
            this.txtTTTK_matkhau.Location = new System.Drawing.Point(142, 114);
            this.txtTTTK_matkhau.Name = "txtTTTK_matkhau";
            this.txtTTTK_matkhau.PasswordChar = '*';
            this.txtTTTK_matkhau.ReadOnly = true;
            this.txtTTTK_matkhau.Size = new System.Drawing.Size(171, 20);
            this.txtTTTK_matkhau.TabIndex = 1;
            // 
            // txtTTTK_tendangnhap
            // 
            this.txtTTTK_tendangnhap.Location = new System.Drawing.Point(142, 70);
            this.txtTTTK_tendangnhap.Name = "txtTTTK_tendangnhap";
            this.txtTTTK_tendangnhap.Size = new System.Drawing.Size(171, 20);
            this.txtTTTK_tendangnhap.TabIndex = 1;
            // 
            // txtTTTK_tentaikhoan
            // 
            this.txtTTTK_tentaikhoan.Location = new System.Drawing.Point(142, 37);
            this.txtTTTK_tentaikhoan.Name = "txtTTTK_tentaikhoan";
            this.txtTTTK_tentaikhoan.Size = new System.Drawing.Size(171, 20);
            this.txtTTTK_tentaikhoan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản :";
            // 
            // ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 406);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThongTinTaiKhoan";
            this.Text = "Thông tin tài khoản ";
            this.Load += new System.EventHandler(this.ThongTinTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTTTK_thongbaonhapmk;
        private System.Windows.Forms.Button btnTTTK_updatethongtin;
        private System.Windows.Forms.CheckBox cbTTTK_doimatkhau;
        private System.Windows.Forms.RichTextBox txtTTTK_diachi;
        private System.Windows.Forms.DateTimePicker dateTTTK_ngaysinh;
        private System.Windows.Forms.TextBox txtTTTK_matkhaumoi;
        private System.Windows.Forms.TextBox txtTTTK_matkhau;
        private System.Windows.Forms.TextBox txtTTTK_tendangnhap;
        private System.Windows.Forms.TextBox txtTTTK_tentaikhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTTTK_thongbavalidate;
    }
}