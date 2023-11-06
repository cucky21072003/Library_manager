namespace QuanLyThuVien.View
{
    partial class PhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMuon));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDG = new System.Windows.Forms.ComboBox();
            this.cmbNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pcPhieuMuon = new System.Windows.Forms.PictureBox();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(708, 492);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Tìm kiếm ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDG);
            this.groupBox1.Controls.Add(this.cmbNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(165, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 171);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(129, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 22);
            this.txtId.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id";
            // 
            // cmbDG
            // 
            this.cmbDG.FormattingEnabled = true;
            this.cmbDG.Location = new System.Drawing.Point(129, 73);
            this.cmbDG.Name = "cmbDG";
            this.cmbDG.Size = new System.Drawing.Size(180, 24);
            this.cmbDG.TabIndex = 18;
            // 
            // cmbNV
            // 
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.Location = new System.Drawing.Point(129, 112);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(180, 24);
            this.cmbNV.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã DG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(485, 300);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 22);
            this.txtSearch.TabIndex = 49;
            // 
            // pcPhieuMuon
            // 
            this.pcPhieuMuon.Image = ((System.Drawing.Image)(resources.GetObject("pcPhieuMuon.Image")));
            this.pcPhieuMuon.Location = new System.Drawing.Point(12, 92);
            this.pcPhieuMuon.Name = "pcPhieuMuon";
            this.pcPhieuMuon.Size = new System.Drawing.Size(294, 253);
            this.pcPhieuMuon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPhieuMuon.TabIndex = 56;
            this.pcPhieuMuon.TabStop = false;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(361, 92);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(422, 201);
            this.dgvPhieuMuon.TabIndex = 55;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(708, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(708, 428);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(708, 460);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(708, 521);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(708, 299);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(371, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Phiếu mượn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tìm kiếm ";
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 598);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pcPhieuMuon);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PhieuMuon";
            this.Text = "PhieuMuon";
            this.Load += new System.EventHandler(this.PhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDG;
        private System.Windows.Forms.ComboBox cmbNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pcPhieuMuon;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
    }
}