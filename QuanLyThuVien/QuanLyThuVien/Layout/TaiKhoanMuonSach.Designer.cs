namespace QuanLyThuVien.Layout
{
    partial class TaiKhoanMuonSach
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDSM_timsachmuon = new System.Windows.Forms.Button();
            this.txtDSM_keyword = new System.Windows.Forms.TextBox();
            this.dataTK_dstatcasachmuon = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuthuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spTaiKhoanXemTatCaSachMuonResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDSM_diachi = new System.Windows.Forms.RichTextBox();
            this.dateDSM_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDSM_matk = new System.Windows.Forms.TextBox();
            this.txtDSM_tentk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTK_dstatcasachmuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTaiKhoanXemTatCaSachMuonResultBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 522);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDSM_timsachmuon);
            this.groupBox2.Controls.Add(this.txtDSM_keyword);
            this.groupBox2.Controls.Add(this.dataTK_dstatcasachmuon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dách sách mượn ";
            // 
            // btnDSM_timsachmuon
            // 
            this.btnDSM_timsachmuon.Location = new System.Drawing.Point(409, 27);
            this.btnDSM_timsachmuon.Name = "btnDSM_timsachmuon";
            this.btnDSM_timsachmuon.Size = new System.Drawing.Size(94, 23);
            this.btnDSM_timsachmuon.TabIndex = 2;
            this.btnDSM_timsachmuon.Text = "Tìm";
            this.btnDSM_timsachmuon.UseVisualStyleBackColor = true;
            this.btnDSM_timsachmuon.Click += new System.EventHandler(this.btnDSM_timsachmuon_Click);
            // 
            // txtDSM_keyword
            // 
            this.txtDSM_keyword.Location = new System.Drawing.Point(155, 27);
            this.txtDSM_keyword.Name = "txtDSM_keyword";
            this.txtDSM_keyword.Size = new System.Drawing.Size(239, 20);
            this.txtDSM_keyword.TabIndex = 1;
            // 
            // dataTK_dstatcasachmuon
            // 
            this.dataTK_dstatcasachmuon.AutoGenerateColumns = false;
            this.dataTK_dstatcasachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTK_dstatcasachmuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.masachDataGridViewTextBoxColumn,
            this.tieudeDataGridViewTextBoxColumn,
            this.ngaymuonDataGridViewTextBoxColumn,
            this.ngaytraDataGridViewTextBoxColumn,
            this.phuthuDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewCheckBoxColumn});
            this.dataTK_dstatcasachmuon.DataSource = this.spTaiKhoanXemTatCaSachMuonResultBindingSource;
            this.dataTK_dstatcasachmuon.Location = new System.Drawing.Point(6, 59);
            this.dataTK_dstatcasachmuon.Name = "dataTK_dstatcasachmuon";
            this.dataTK_dstatcasachmuon.Size = new System.Drawing.Size(693, 244);
            this.dataTK_dstatcasachmuon.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // masachDataGridViewTextBoxColumn
            // 
            this.masachDataGridViewTextBoxColumn.DataPropertyName = "masach";
            this.masachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.masachDataGridViewTextBoxColumn.Name = "masachDataGridViewTextBoxColumn";
            this.masachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tieudeDataGridViewTextBoxColumn
            // 
            this.tieudeDataGridViewTextBoxColumn.DataPropertyName = "tieude";
            this.tieudeDataGridViewTextBoxColumn.HeaderText = "Tiêu đề";
            this.tieudeDataGridViewTextBoxColumn.Name = "tieudeDataGridViewTextBoxColumn";
            this.tieudeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tieudeDataGridViewTextBoxColumn.Width = 180;
            // 
            // ngaymuonDataGridViewTextBoxColumn
            // 
            this.ngaymuonDataGridViewTextBoxColumn.DataPropertyName = "ngaymuon";
            this.ngaymuonDataGridViewTextBoxColumn.HeaderText = "Ngày mượn";
            this.ngaymuonDataGridViewTextBoxColumn.Name = "ngaymuonDataGridViewTextBoxColumn";
            this.ngaymuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaytraDataGridViewTextBoxColumn
            // 
            this.ngaytraDataGridViewTextBoxColumn.DataPropertyName = "ngaytra";
            this.ngaytraDataGridViewTextBoxColumn.HeaderText = "Ngày trả";
            this.ngaytraDataGridViewTextBoxColumn.Name = "ngaytraDataGridViewTextBoxColumn";
            this.ngaytraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phuthuDataGridViewTextBoxColumn
            // 
            this.phuthuDataGridViewTextBoxColumn.DataPropertyName = "phuthu";
            this.phuthuDataGridViewTextBoxColumn.HeaderText = "Phụ thu";
            this.phuthuDataGridViewTextBoxColumn.Name = "phuthuDataGridViewTextBoxColumn";
            this.phuthuDataGridViewTextBoxColumn.ReadOnly = true;
            this.phuthuDataGridViewTextBoxColumn.Width = 80;
            // 
            // trangthaiDataGridViewCheckBoxColumn
            // 
            this.trangthaiDataGridViewCheckBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewCheckBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewCheckBoxColumn.Name = "trangthaiDataGridViewCheckBoxColumn";
            this.trangthaiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.trangthaiDataGridViewCheckBoxColumn.Width = 50;
            // 
            // spTaiKhoanXemTatCaSachMuonResultBindingSource
            // 
            this.spTaiKhoanXemTatCaSachMuonResultBindingSource.DataSource = typeof(EntityData.sp_TaiKhoan_XemTatCaSachMuon_Result);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên sách hoặc mã sách  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDSM_diachi);
            this.groupBox1.Controls.Add(this.dateDSM_ngaysinh);
            this.groupBox1.Controls.Add(this.txtDSM_matk);
            this.groupBox1.Controls.Add(this.txtDSM_tentk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtDSM_diachi
            // 
            this.txtDSM_diachi.Enabled = false;
            this.txtDSM_diachi.Location = new System.Drawing.Point(94, 98);
            this.txtDSM_diachi.Name = "txtDSM_diachi";
            this.txtDSM_diachi.Size = new System.Drawing.Size(168, 54);
            this.txtDSM_diachi.TabIndex = 2;
            this.txtDSM_diachi.Text = "";
            // 
            // dateDSM_ngaysinh
            // 
            this.dateDSM_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dateDSM_ngaysinh.Enabled = false;
            this.dateDSM_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDSM_ngaysinh.Location = new System.Drawing.Point(94, 71);
            this.dateDSM_ngaysinh.Name = "dateDSM_ngaysinh";
            this.dateDSM_ngaysinh.Size = new System.Drawing.Size(168, 20);
            this.dateDSM_ngaysinh.TabIndex = 2;
            // 
            // txtDSM_matk
            // 
            this.txtDSM_matk.Location = new System.Drawing.Point(94, 45);
            this.txtDSM_matk.Name = "txtDSM_matk";
            this.txtDSM_matk.ReadOnly = true;
            this.txtDSM_matk.Size = new System.Drawing.Size(168, 20);
            this.txtDSM_matk.TabIndex = 1;
            // 
            // txtDSM_tentk
            // 
            this.txtDSM_tentk.Location = new System.Drawing.Point(94, 19);
            this.txtDSM_tentk.Name = "txtDSM_tentk";
            this.txtDSM_tentk.ReadOnly = true;
            this.txtDSM_tentk.Size = new System.Drawing.Size(168, 20);
            this.txtDSM_tentk.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Tk :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên : ";
            // 
            // TaiKhoanMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaiKhoanMuonSach";
            this.Text = "Thông tin sách mượn";
            this.Load += new System.EventHandler(this.TaiKhoanMuonSach_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTK_dstatcasachmuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTaiKhoanXemTatCaSachMuonResultBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataTK_dstatcasachmuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateDSM_ngaysinh;
        private System.Windows.Forms.TextBox txtDSM_matk;
        private System.Windows.Forms.TextBox txtDSM_tentk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDSM_keyword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDSM_timsachmuon;
        private System.Windows.Forms.BindingSource spTaiKhoanXemTatCaSachMuonResultBindingSource;
        private System.Windows.Forms.RichTextBox txtDSM_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuthuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthaiDataGridViewCheckBoxColumn;
    }
}