namespace QuanLyThuVien.Layout
{
    partial class DanhSachNguoiMuon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DSTKMS_timkiem = new System.Windows.Forms.Button();
            this.txtDSTKMS_timkiem_matk = new System.Windows.Forms.TextBox();
            this.dataDSTKMS = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentaikhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuthuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.muonSachDsTaiKhoanMuonSachResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDSTKMS_tacgia = new System.Windows.Forms.TextBox();
            this.txtDSTKMS_masach = new System.Windows.Forms.TextBox();
            this.txtDSTKMS_tieude = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSTKMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muonSachDsTaiKhoanMuonSachResultBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DSTKMS_timkiem);
            this.groupBox2.Controls.Add(this.txtDSTKMS_timkiem_matk);
            this.groupBox2.Controls.Add(this.dataDSTKMS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dách sách mượn ";
            // 
            // btn_DSTKMS_timkiem
            // 
            this.btn_DSTKMS_timkiem.Location = new System.Drawing.Point(350, 27);
            this.btn_DSTKMS_timkiem.Name = "btn_DSTKMS_timkiem";
            this.btn_DSTKMS_timkiem.Size = new System.Drawing.Size(94, 23);
            this.btn_DSTKMS_timkiem.TabIndex = 2;
            this.btn_DSTKMS_timkiem.Text = "Tìm";
            this.btn_DSTKMS_timkiem.UseVisualStyleBackColor = true;
            this.btn_DSTKMS_timkiem.Click += new System.EventHandler(this.btn_DSTKMS_timkiem_Click);
            // 
            // txtDSTKMS_timkiem_matk
            // 
            this.txtDSTKMS_timkiem_matk.Location = new System.Drawing.Point(94, 27);
            this.txtDSTKMS_timkiem_matk.Name = "txtDSTKMS_timkiem_matk";
            this.txtDSTKMS_timkiem_matk.Size = new System.Drawing.Size(239, 20);
            this.txtDSTKMS_timkiem_matk.TabIndex = 1;
            // 
            // dataDSTKMS
            // 
            this.dataDSTKMS.AutoGenerateColumns = false;
            this.dataDSTKMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSTKMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.matkDataGridViewTextBoxColumn,
            this.tentaikhoanDataGridViewTextBoxColumn,
            this.ngaymuonDataGridViewTextBoxColumn,
            this.ngaytraDataGridViewTextBoxColumn,
            this.phuthuDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewCheckBoxColumn});
            this.dataDSTKMS.DataSource = this.muonSachDsTaiKhoanMuonSachResultBindingSource;
            this.dataDSTKMS.Location = new System.Drawing.Point(0, 59);
            this.dataDSTKMS.Name = "dataDSTKMS";
            this.dataDSTKMS.Size = new System.Drawing.Size(638, 189);
            this.dataDSTKMS.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // matkDataGridViewTextBoxColumn
            // 
            this.matkDataGridViewTextBoxColumn.DataPropertyName = "matk";
            this.matkDataGridViewTextBoxColumn.HeaderText = "Mã tài khoản";
            this.matkDataGridViewTextBoxColumn.Name = "matkDataGridViewTextBoxColumn";
            // 
            // tentaikhoanDataGridViewTextBoxColumn
            // 
            this.tentaikhoanDataGridViewTextBoxColumn.DataPropertyName = "tentaikhoan";
            this.tentaikhoanDataGridViewTextBoxColumn.HeaderText = "Tên tài khoản";
            this.tentaikhoanDataGridViewTextBoxColumn.Name = "tentaikhoanDataGridViewTextBoxColumn";
            // 
            // ngaymuonDataGridViewTextBoxColumn
            // 
            this.ngaymuonDataGridViewTextBoxColumn.DataPropertyName = "ngaymuon";
            this.ngaymuonDataGridViewTextBoxColumn.HeaderText = "Ngày mượn";
            this.ngaymuonDataGridViewTextBoxColumn.Name = "ngaymuonDataGridViewTextBoxColumn";
            // 
            // ngaytraDataGridViewTextBoxColumn
            // 
            this.ngaytraDataGridViewTextBoxColumn.DataPropertyName = "ngaytra";
            this.ngaytraDataGridViewTextBoxColumn.HeaderText = "Ngày trả";
            this.ngaytraDataGridViewTextBoxColumn.Name = "ngaytraDataGridViewTextBoxColumn";
            // 
            // phuthuDataGridViewTextBoxColumn
            // 
            this.phuthuDataGridViewTextBoxColumn.DataPropertyName = "phuthu";
            this.phuthuDataGridViewTextBoxColumn.HeaderText = "Phụ thu";
            this.phuthuDataGridViewTextBoxColumn.Name = "phuthuDataGridViewTextBoxColumn";
            // 
            // trangthaiDataGridViewCheckBoxColumn
            // 
            this.trangthaiDataGridViewCheckBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewCheckBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewCheckBoxColumn.Name = "trangthaiDataGridViewCheckBoxColumn";
            this.trangthaiDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // muonSachDsTaiKhoanMuonSachResultBindingSource
            // 
            this.muonSachDsTaiKhoanMuonSachResultBindingSource.DataSource = typeof(EntityData.MuonSach_DsTaiKhoanMuonSach_Result);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã tài khoản : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDSTKMS_tacgia);
            this.groupBox4.Controls.Add(this.txtDSTKMS_masach);
            this.groupBox4.Controls.Add(this.txtDSTKMS_tieude);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 153);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin sách";
            // 
            // txtDSTKMS_tacgia
            // 
            this.txtDSTKMS_tacgia.Location = new System.Drawing.Point(75, 85);
            this.txtDSTKMS_tacgia.Name = "txtDSTKMS_tacgia";
            this.txtDSTKMS_tacgia.Size = new System.Drawing.Size(175, 20);
            this.txtDSTKMS_tacgia.TabIndex = 1;
            // 
            // txtDSTKMS_masach
            // 
            this.txtDSTKMS_masach.Location = new System.Drawing.Point(75, 57);
            this.txtDSTKMS_masach.Name = "txtDSTKMS_masach";
            this.txtDSTKMS_masach.ReadOnly = true;
            this.txtDSTKMS_masach.Size = new System.Drawing.Size(175, 20);
            this.txtDSTKMS_masach.TabIndex = 1;
            // 
            // txtDSTKMS_tieude
            // 
            this.txtDSTKMS_tieude.Location = new System.Drawing.Point(75, 32);
            this.txtDSTKMS_tieude.Name = "txtDSTKMS_tieude";
            this.txtDSTKMS_tieude.Size = new System.Drawing.Size(175, 20);
            this.txtDSTKMS_tieude.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tác giả :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã sách :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tiêu đề :";
            // 
            // DanhSachNguoiMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DanhSachNguoiMuon";
            this.Text = "Danh sách người mượn sách ";
            this.Load += new System.EventHandler(this.DanhSachNguoiMuon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSTKMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muonSachDsTaiKhoanMuonSachResultBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DSTKMS_timkiem;
        private System.Windows.Forms.TextBox txtDSTKMS_timkiem_matk;
        private System.Windows.Forms.DataGridView dataDSTKMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDSTKMS_tacgia;
        private System.Windows.Forms.TextBox txtDSTKMS_masach;
        private System.Windows.Forms.TextBox txtDSTKMS_tieude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentaikhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuthuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource muonSachDsTaiKhoanMuonSachResultBindingSource;
    }
}