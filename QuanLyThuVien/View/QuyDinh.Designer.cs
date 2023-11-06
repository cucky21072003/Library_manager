namespace QuanLyThuVien.View
{
    partial class QuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuyDinh));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenQD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.DateNgayBH = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(592, 503);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(34, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 248);
            this.panel2.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mô tả";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(592, 358);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 22);
            this.txtTimKiem.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(812, 357);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(725, 503);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(770, 437);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(651, 437);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(161, 122);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(237, 22);
            this.txtMoTa.TabIndex = 14;
            // 
            // txtTenQD
            // 
            this.txtTenQD.Location = new System.Drawing.Point(161, 86);
            this.txtTenQD.Name = "txtTenQD";
            this.txtTenQD.Size = new System.Drawing.Size(237, 22);
            this.txtTenQD.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên quy định";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(526, 437);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DateNgayBH
            // 
            this.DateNgayBH.CustomFormat = "dd-MM-yyyy";
            this.DateNgayBH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNgayBH.Location = new System.Drawing.Point(163, 167);
            this.DateNgayBH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateNgayBH.Name = "DateNgayBH";
            this.DateNgayBH.Size = new System.Drawing.Size(234, 22);
            this.DateNgayBH.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DateNgayBH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.txtTenQD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 219);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(161, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(236, 22);
            this.txtId.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ngày ban hành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(471, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Quy định";
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Location = new System.Drawing.Point(344, 112);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.RowHeadersWidth = 51;
            this.dgvQuyDinh.Size = new System.Drawing.Size(555, 198);
            this.dgvQuyDinh.TabIndex = 29;
            this.dgvQuyDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyDinh_CellClick);
            // 
            // QuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 602);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQuyDinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuyDinh";
            this.Text = "QuyDinh";
            this.Load += new System.EventHandler(this.QuyDinh_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenQD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker DateNgayBH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuyDinh;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
    }
}