namespace QuanLyThuVien.View
{
    partial class DocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGia));
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DateTimeNgS = new System.Windows.Forms.DateTimePicker();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuaDG = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSearchDG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pcDocGia = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemDG = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDocGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tìm kiếm";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(12, 395);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(965, 173);
            this.dgvDocGia.TabIndex = 59;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(132, 150);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(267, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "SĐT";
            // 
            // DateTimeNgS
            // 
            this.DateTimeNgS.CustomFormat = "dd-MM-yyyy";
            this.DateTimeNgS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeNgS.Location = new System.Drawing.Point(132, 185);
            this.DateTimeNgS.Name = "DateTimeNgS";
            this.DateTimeNgS.Size = new System.Drawing.Size(267, 22);
            this.DateTimeNgS.TabIndex = 20;
            this.DateTimeNgS.Value = new System.DateTime(2023, 8, 1, 0, 0, 0, 0);
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(132, 71);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(267, 22);
            this.txtTenDG.TabIndex = 10;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(132, 110);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(267, 22);
            this.txtLop.TabIndex = 9;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(132, 225);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cmbGioiTinh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên ĐG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp";
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.Location = new System.Drawing.Point(894, 160);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDG.TabIndex = 56;
            this.btnSuaDG.Text = "Sửa";
            this.btnSuaDG.UseVisualStyleBackColor = true;
            this.btnSuaDG.Click += new System.EventHandler(this.btnSuaDG_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(894, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(894, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSearchDG
            // 
            this.btnSearchDG.Location = new System.Drawing.Point(727, 353);
            this.btnSearchDG.Name = "btnSearchDG";
            this.btnSearchDG.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDG.TabIndex = 53;
            this.btnSearchDG.Text = "Search";
            this.btnSearchDG.UseVisualStyleBackColor = true;
            this.btnSearchDG.Click += new System.EventHandler(this.btnSearchDG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh ";
            // 
            // pcDocGia
            // 
            this.pcDocGia.Image = ((System.Drawing.Image)(resources.GetObject("pcDocGia.Image")));
            this.pcDocGia.Location = new System.Drawing.Point(12, 70);
            this.pcDocGia.Name = "pcDocGia";
            this.pcDocGia.Size = new System.Drawing.Size(311, 306);
            this.pcDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcDocGia.TabIndex = 60;
            this.pcDocGia.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(515, 354);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 22);
            this.txtSearch.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giới tính ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(894, 253);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DateTimeNgS);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.cmbGioiTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(358, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 277);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(132, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(267, 22);
            this.txtId.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Id";
            // 
            // btnThemDG
            // 
            this.btnThemDG.Location = new System.Drawing.Point(894, 104);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(75, 23);
            this.btnThemDG.TabIndex = 57;
            this.btnThemDG.Text = "Thêm";
            this.btnThemDG.UseVisualStyleBackColor = true;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(490, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Độc giả";
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.btnSuaDG);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSearchDG);
            this.Controls.Add(this.pcDocGia);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemDG);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDocGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateTimeNgS;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSearchDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcDocGia;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
    }
}