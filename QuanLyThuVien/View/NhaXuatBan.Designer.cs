namespace QuanLyThuVien.View
{
    partial class NhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaXuatBan));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.TenNXB = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcNXB = new System.Windows.Forms.PictureBox();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(742, 463);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(742, 521);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(394, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nhà xuất bản";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(179, 135);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(321, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(179, 99);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(321, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(179, 69);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(321, 22);
            this.txtTenNXB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(67, 105);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(47, 16);
            this.DiaChi.TabIndex = 3;
            this.DiaChi.Text = "Địa chỉ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(742, 321);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(742, 403);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(742, 433);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // TenNXB
            // 
            this.TenNXB.AutoSize = true;
            this.TenNXB.Location = new System.Drawing.Point(67, 75);
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Size = new System.Drawing.Size(61, 16);
            this.TenNXB.TabIndex = 2;
            this.TenNXB.Text = "Tên NXB";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(742, 492);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNXB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DiaChi);
            this.groupBox1.Controls.Add(this.TenNXB);
            this.groupBox1.Location = new System.Drawing.Point(157, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 178);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(179, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(321, 22);
            this.txtId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id";
            // 
            // pcNXB
            // 
            this.pcNXB.Image = ((System.Drawing.Image)(resources.GetObject("pcNXB.Image")));
            this.pcNXB.Location = new System.Drawing.Point(12, 75);
            this.pcNXB.Name = "pcNXB";
            this.pcNXB.Size = new System.Drawing.Size(230, 279);
            this.pcNXB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcNXB.TabIndex = 55;
            this.pcNXB.TabStop = false;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(264, 75);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersWidth = 51;
            this.dgvNXB.RowTemplate.Height = 24;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(581, 228);
            this.dgvNXB.TabIndex = 54;
            this.dgvNXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(489, 322);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 48;
            // 
            // NhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 592);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcNXB);
            this.Controls.Add(this.dgvNXB);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NhaXuatBan";
            this.Text = "NhaXuatBan";
            this.Load += new System.EventHandler(this.NhaXuatBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label TenNXB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcNXB;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
    }
}