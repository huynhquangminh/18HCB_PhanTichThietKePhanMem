namespace QuanLyThuVien.Layout
{
    partial class Register
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTKDK_thongbao2 = new System.Windows.Forms.Label();
            this.lbTKDK_thongbao = new System.Windows.Forms.Label();
            this.btnTKDK_clear = new System.Windows.Forms.Button();
            this.btnTKDK_dangky = new System.Windows.Forms.Button();
            this.txtTKDK_diachi = new System.Windows.Forms.RichTextBox();
            this.dateTKDK_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTKDK_tendangnhap = new System.Windows.Forms.TextBox();
            this.txtTKDK_nhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.txtTKDK_matkhau = new System.Windows.Forms.TextBox();
            this.txtTKDK_tentaikhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 464);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đăng ký tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTKDK_thongbao2);
            this.groupBox1.Controls.Add(this.lbTKDK_thongbao);
            this.groupBox1.Controls.Add(this.btnTKDK_clear);
            this.groupBox1.Controls.Add(this.btnTKDK_dangky);
            this.groupBox1.Controls.Add(this.txtTKDK_diachi);
            this.groupBox1.Controls.Add(this.dateTKDK_ngaysinh);
            this.groupBox1.Controls.Add(this.txtTKDK_tendangnhap);
            this.groupBox1.Controls.Add(this.txtTKDK_nhaplaimatkhau);
            this.groupBox1.Controls.Add(this.txtTKDK_matkhau);
            this.groupBox1.Controls.Add(this.txtTKDK_tentaikhoan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng ký";
            // 
            // lbTKDK_thongbao2
            // 
            this.lbTKDK_thongbao2.AutoSize = true;
            this.lbTKDK_thongbao2.ForeColor = System.Drawing.Color.Red;
            this.lbTKDK_thongbao2.Location = new System.Drawing.Point(152, 307);
            this.lbTKDK_thongbao2.Name = "lbTKDK_thongbao2";
            this.lbTKDK_thongbao2.Size = new System.Drawing.Size(122, 13);
            this.lbTKDK_thongbao2.TabIndex = 5;
            this.lbTKDK_thongbao2.Text = "(*) Mật khẩu khác nhau!";
            this.lbTKDK_thongbao2.Visible = false;
            // 
            // lbTKDK_thongbao
            // 
            this.lbTKDK_thongbao.AutoSize = true;
            this.lbTKDK_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lbTKDK_thongbao.Location = new System.Drawing.Point(152, 292);
            this.lbTKDK_thongbao.Name = "lbTKDK_thongbao";
            this.lbTKDK_thongbao.Size = new System.Drawing.Size(259, 13);
            this.lbTKDK_thongbao.TabIndex = 5;
            this.lbTKDK_thongbao.Text = "(*) Đăng ký thất bại, bạn phải nhập tất cả các trường!";
            this.lbTKDK_thongbao.Visible = false;
            // 
            // btnTKDK_clear
            // 
            this.btnTKDK_clear.Location = new System.Drawing.Point(312, 331);
            this.btnTKDK_clear.Name = "btnTKDK_clear";
            this.btnTKDK_clear.Size = new System.Drawing.Size(75, 23);
            this.btnTKDK_clear.TabIndex = 4;
            this.btnTKDK_clear.Text = "Clear";
            this.btnTKDK_clear.UseVisualStyleBackColor = true;
            this.btnTKDK_clear.Click += new System.EventHandler(this.btnTKDK_clear_Click);
            // 
            // btnTKDK_dangky
            // 
            this.btnTKDK_dangky.Location = new System.Drawing.Point(225, 331);
            this.btnTKDK_dangky.Name = "btnTKDK_dangky";
            this.btnTKDK_dangky.Size = new System.Drawing.Size(75, 23);
            this.btnTKDK_dangky.TabIndex = 4;
            this.btnTKDK_dangky.Text = "Đăng ký";
            this.btnTKDK_dangky.UseVisualStyleBackColor = true;
            this.btnTKDK_dangky.Click += new System.EventHandler(this.btnTKDK_dangky_Click);
            // 
            // txtTKDK_diachi
            // 
            this.txtTKDK_diachi.Location = new System.Drawing.Point(153, 229);
            this.txtTKDK_diachi.Name = "txtTKDK_diachi";
            this.txtTKDK_diachi.Size = new System.Drawing.Size(234, 60);
            this.txtTKDK_diachi.TabIndex = 3;
            this.txtTKDK_diachi.Text = "";
            // 
            // dateTKDK_ngaysinh
            // 
            this.dateTKDK_ngaysinh.CustomFormat = "yyyy/MM/dd";
            this.dateTKDK_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTKDK_ngaysinh.Location = new System.Drawing.Point(153, 196);
            this.dateTKDK_ngaysinh.Name = "dateTKDK_ngaysinh";
            this.dateTKDK_ngaysinh.Size = new System.Drawing.Size(234, 20);
            this.dateTKDK_ngaysinh.TabIndex = 2;
            // 
            // txtTKDK_tendangnhap
            // 
            this.txtTKDK_tendangnhap.Location = new System.Drawing.Point(155, 40);
            this.txtTKDK_tendangnhap.Name = "txtTKDK_tendangnhap";
            this.txtTKDK_tendangnhap.Size = new System.Drawing.Size(234, 20);
            this.txtTKDK_tendangnhap.TabIndex = 1;
            // 
            // txtTKDK_nhaplaimatkhau
            // 
            this.txtTKDK_nhaplaimatkhau.Location = new System.Drawing.Point(153, 121);
            this.txtTKDK_nhaplaimatkhau.Name = "txtTKDK_nhaplaimatkhau";
            this.txtTKDK_nhaplaimatkhau.PasswordChar = '*';
            this.txtTKDK_nhaplaimatkhau.Size = new System.Drawing.Size(234, 20);
            this.txtTKDK_nhaplaimatkhau.TabIndex = 1;
            // 
            // txtTKDK_matkhau
            // 
            this.txtTKDK_matkhau.Location = new System.Drawing.Point(153, 84);
            this.txtTKDK_matkhau.Name = "txtTKDK_matkhau";
            this.txtTKDK_matkhau.PasswordChar = '*';
            this.txtTKDK_matkhau.Size = new System.Drawing.Size(234, 20);
            this.txtTKDK_matkhau.TabIndex = 1;
            // 
            // txtTKDK_tentaikhoan
            // 
            this.txtTKDK_tentaikhoan.Location = new System.Drawing.Point(153, 156);
            this.txtTKDK_tentaikhoan.Name = "txtTKDK_tentaikhoan";
            this.txtTKDK_tentaikhoan.Size = new System.Drawing.Size(234, 20);
            this.txtTKDK_tentaikhoan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nơi ở ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = " Ngày sinh ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 464);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTKDK_thongbao;
        private System.Windows.Forms.Button btnTKDK_clear;
        private System.Windows.Forms.Button btnTKDK_dangky;
        private System.Windows.Forms.RichTextBox txtTKDK_diachi;
        private System.Windows.Forms.DateTimePicker dateTKDK_ngaysinh;
        private System.Windows.Forms.TextBox txtTKDK_tendangnhap;
        private System.Windows.Forms.TextBox txtTKDK_nhaplaimatkhau;
        private System.Windows.Forms.TextBox txtTKDK_matkhau;
        private System.Windows.Forms.TextBox txtTKDK_tentaikhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTKDK_thongbao2;
        private System.Windows.Forms.Label label7;
    }
}