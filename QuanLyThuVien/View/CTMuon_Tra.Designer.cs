namespace QuanLyThuVien.View
{
    partial class CTMuon_Tra
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNote = new System.Windows.Forms.ComboBox();
            this.cmbQuyDinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMaTaiLieu = new System.Windows.Forms.ComboBox();
            this.cmbMaPhieu = new System.Windows.Forms.ComboBox();
            this.DateTimeNgayTra = new System.Windows.Forms.DateTimePicker();
            this.DateTimeNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.DateTimeNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dgvCTMuonTra = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtRefresh = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMuonTra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(621, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 63;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(555, 374);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tìm kiếm ";
            // 
            // cmbNote
            // 
            this.cmbNote.FormattingEnabled = true;
            this.cmbNote.Items.AddRange(new object[] {
            "Chưa trả",
            "Đã trả",
            "Chưa trả quá hạn"});
            this.cmbNote.Location = new System.Drawing.Point(583, 185);
            this.cmbNote.Name = "cmbNote";
            this.cmbNote.Size = new System.Drawing.Size(200, 24);
            this.cmbNote.TabIndex = 30;
            // 
            // cmbQuyDinh
            // 
            this.cmbQuyDinh.FormattingEnabled = true;
            this.cmbQuyDinh.Location = new System.Drawing.Point(170, 159);
            this.cmbQuyDinh.Name = "cmbQuyDinh";
            this.cmbQuyDinh.Size = new System.Drawing.Size(222, 24);
            this.cmbQuyDinh.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Note";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Mã quy định";
            // 
            // cmbMaTaiLieu
            // 
            this.cmbMaTaiLieu.FormattingEnabled = true;
            this.cmbMaTaiLieu.Location = new System.Drawing.Point(170, 117);
            this.cmbMaTaiLieu.Name = "cmbMaTaiLieu";
            this.cmbMaTaiLieu.Size = new System.Drawing.Size(222, 24);
            this.cmbMaTaiLieu.TabIndex = 23;
            // 
            // cmbMaPhieu
            // 
            this.cmbMaPhieu.FormattingEnabled = true;
            this.cmbMaPhieu.Location = new System.Drawing.Point(170, 73);
            this.cmbMaPhieu.Name = "cmbMaPhieu";
            this.cmbMaPhieu.Size = new System.Drawing.Size(222, 24);
            this.cmbMaPhieu.TabIndex = 22;
            // 
            // DateTimeNgayTra
            // 
            this.DateTimeNgayTra.CustomFormat = "dd-MM-yyyy";
            this.DateTimeNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeNgayTra.Location = new System.Drawing.Point(583, 141);
            this.DateTimeNgayTra.Name = "DateTimeNgayTra";
            this.DateTimeNgayTra.Size = new System.Drawing.Size(200, 22);
            this.DateTimeNgayTra.TabIndex = 20;
            // 
            // DateTimeNgayMuon
            // 
            this.DateTimeNgayMuon.CustomFormat = "dd-MM-yyyy";
            this.DateTimeNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeNgayMuon.Location = new System.Drawing.Point(582, 51);
            this.DateTimeNgayMuon.Name = "DateTimeNgayMuon";
            this.DateTimeNgayMuon.Size = new System.Drawing.Size(200, 22);
            this.DateTimeNgayMuon.TabIndex = 19;
            // 
            // DateTimeNgayHenTra
            // 
            this.DateTimeNgayHenTra.CustomFormat = "dd-MM-yyyy";
            this.DateTimeNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeNgayHenTra.Location = new System.Drawing.Point(583, 97);
            this.DateTimeNgayHenTra.Name = "DateTimeNgayHenTra";
            this.DateTimeNgayHenTra.Size = new System.Drawing.Size(200, 22);
            this.DateTimeNgayHenTra.TabIndex = 18;
            // 
            // dgvCTMuonTra
            // 
            this.dgvCTMuonTra.AllowUserToAddRows = false;
            this.dgvCTMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTMuonTra.Location = new System.Drawing.Point(9, 412);
            this.dgvCTMuonTra.Name = "dgvCTMuonTra";
            this.dgvCTMuonTra.RowHeadersWidth = 51;
            this.dgvCTMuonTra.RowTemplate.Height = 24;
            this.dgvCTMuonTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTMuonTra.Size = new System.Drawing.Size(841, 272);
            this.dgvCTMuonTra.TabIndex = 67;
            this.dgvCTMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTMuonTra_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(383, 338);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 24);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(245, 338);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 24);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày mượn ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày hẹn trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã phiếu ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã tài liệu ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(329, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 29);
            this.label13.TabIndex = 69;
            this.label13.Text = "Chi tiết mượn-trả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbNote);
            this.groupBox1.Controls.Add(this.cmbQuyDinh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbMaTaiLieu);
            this.groupBox1.Controls.Add(this.cmbMaPhieu);
            this.groupBox1.Controls.Add(this.DateTimeNgayTra);
            this.groupBox1.Controls.Add(this.DateTimeNgayMuon);
            this.groupBox1.Controls.Add(this.DateTimeNgayHenTra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 245);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(170, 209);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(222, 22);
            this.txtSoLuong.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "SoLuong";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(170, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 22);
            this.txtId.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(302, 380);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 22);
            this.txtSearch.TabIndex = 61;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtRefresh
            // 
            this.txtRefresh.Location = new System.Drawing.Point(507, 338);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(75, 23);
            this.txtRefresh.TabIndex = 70;
            this.txtRefresh.Text = "Refresh";
            this.txtRefresh.UseVisualStyleBackColor = true;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(117, 338);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(89, 24);
            this.btnTraSach.TabIndex = 64;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // CTMuon_Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 706);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCTMuonTra);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CTMuon_Tra";
            this.Text = "CTMuon_Tra";
            this.Load += new System.EventHandler(this.CTMuon_Tra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMuonTra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNote;
        private System.Windows.Forms.ComboBox cmbQuyDinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMaTaiLieu;
        private System.Windows.Forms.ComboBox cmbMaPhieu;
        private System.Windows.Forms.DateTimePicker DateTimeNgayTra;
        private System.Windows.Forms.DateTimePicker DateTimeNgayMuon;
        private System.Windows.Forms.DateTimePicker DateTimeNgayHenTra;
        private System.Windows.Forms.DataGridView dgvCTMuonTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button txtRefresh;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
    }
}