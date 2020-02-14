namespace QuanLyThuVien.Layout
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTK_thongbaodangnhap = new System.Windows.Forms.Label();
            this.linkTK_dangkytaikhoan = new System.Windows.Forms.LinkLabel();
            this.btnTK_clear = new System.Windows.Forms.Button();
            this.btnTK_dangnhap = new System.Windows.Forms.Button();
            this.txtTK_tendangnhap = new System.Windows.Forms.TextBox();
            this.txtTK_matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTK_thongbaodulieusai = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 299);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTK_thongbaodulieusai);
            this.groupBox1.Controls.Add(this.lbTK_thongbaodangnhap);
            this.groupBox1.Controls.Add(this.linkTK_dangkytaikhoan);
            this.groupBox1.Controls.Add(this.btnTK_clear);
            this.groupBox1.Controls.Add(this.btnTK_dangnhap);
            this.groupBox1.Controls.Add(this.txtTK_tendangnhap);
            this.groupBox1.Controls.Add(this.txtTK_matkhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbTK_thongbaodangnhap
            // 
            this.lbTK_thongbaodangnhap.AutoSize = true;
            this.lbTK_thongbaodangnhap.ForeColor = System.Drawing.Color.Red;
            this.lbTK_thongbaodangnhap.Location = new System.Drawing.Point(85, 168);
            this.lbTK_thongbaodangnhap.Name = "lbTK_thongbaodangnhap";
            this.lbTK_thongbaodangnhap.Size = new System.Drawing.Size(232, 13);
            this.lbTK_thongbaodangnhap.TabIndex = 4;
            this.lbTK_thongbaodangnhap.Text = "(*)Tên đăng nhập hoặc mật khẩu không đúng !";
            this.lbTK_thongbaodangnhap.Visible = false;
            // 
            // linkTK_dangkytaikhoan
            // 
            this.linkTK_dangkytaikhoan.AutoSize = true;
            this.linkTK_dangkytaikhoan.Location = new System.Drawing.Point(137, 237);
            this.linkTK_dangkytaikhoan.Name = "linkTK_dangkytaikhoan";
            this.linkTK_dangkytaikhoan.Size = new System.Drawing.Size(96, 13);
            this.linkTK_dangkytaikhoan.TabIndex = 3;
            this.linkTK_dangkytaikhoan.TabStop = true;
            this.linkTK_dangkytaikhoan.Text = "Đăng kí tài khoản ";
            this.linkTK_dangkytaikhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTK_dangkytaikhoan_LinkClicked);
            // 
            // btnTK_clear
            // 
            this.btnTK_clear.Location = new System.Drawing.Point(140, 193);
            this.btnTK_clear.Name = "btnTK_clear";
            this.btnTK_clear.Size = new System.Drawing.Size(75, 23);
            this.btnTK_clear.TabIndex = 2;
            this.btnTK_clear.Text = "Clear";
            this.btnTK_clear.UseVisualStyleBackColor = true;
            this.btnTK_clear.Click += new System.EventHandler(this.btnTK_clear_Click);
            // 
            // btnTK_dangnhap
            // 
            this.btnTK_dangnhap.Location = new System.Drawing.Point(239, 193);
            this.btnTK_dangnhap.Name = "btnTK_dangnhap";
            this.btnTK_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.btnTK_dangnhap.TabIndex = 2;
            this.btnTK_dangnhap.Text = "Đăng nhập";
            this.btnTK_dangnhap.UseVisualStyleBackColor = true;
            this.btnTK_dangnhap.Click += new System.EventHandler(this.btnTK_dangnhap_Click);
            // 
            // txtTK_tendangnhap
            // 
            this.txtTK_tendangnhap.Location = new System.Drawing.Point(130, 64);
            this.txtTK_tendangnhap.Name = "txtTK_tendangnhap";
            this.txtTK_tendangnhap.Size = new System.Drawing.Size(174, 20);
            this.txtTK_tendangnhap.TabIndex = 1;
            // 
            // txtTK_matkhau
            // 
            this.txtTK_matkhau.Location = new System.Drawing.Point(130, 113);
            this.txtTK_matkhau.Name = "txtTK_matkhau";
            this.txtTK_matkhau.PasswordChar = '*';
            this.txtTK_matkhau.Size = new System.Drawing.Size(174, 20);
            this.txtTK_matkhau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // lbTK_thongbaodulieusai
            // 
            this.lbTK_thongbaodulieusai.AutoSize = true;
            this.lbTK_thongbaodulieusai.ForeColor = System.Drawing.Color.Red;
            this.lbTK_thongbaodulieusai.Location = new System.Drawing.Point(85, 146);
            this.lbTK_thongbaodulieusai.Name = "lbTK_thongbaodulieusai";
            this.lbTK_thongbaodulieusai.Size = new System.Drawing.Size(240, 13);
            this.lbTK_thongbaodulieusai.TabIndex = 4;
            this.lbTK_thongbaodulieusai.Text = "(*) Bạn chưa nhập tên đăng nhập hoặc mật khẩu";
            this.lbTK_thongbaodulieusai.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 299);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTK_thongbaodangnhap;
        private System.Windows.Forms.LinkLabel linkTK_dangkytaikhoan;
        private System.Windows.Forms.Button btnTK_clear;
        private System.Windows.Forms.Button btnTK_dangnhap;
        private System.Windows.Forms.TextBox txtTK_tendangnhap;
        private System.Windows.Forms.TextBox txtTK_matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTK_thongbaodulieusai;
    }
}