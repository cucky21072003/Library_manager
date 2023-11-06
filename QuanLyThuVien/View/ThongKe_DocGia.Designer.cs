namespace QuanLyThuVien.View
{
    partial class ThongKe_DocGia
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
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Location = new System.Drawing.Point(422, 612);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(197, 50);
            this.btnExportToPDF.TabIndex = 18;
            this.btnExportToPDF.Text = "In";
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(33, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 473);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(63, 298);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(902, 134);
            this.dataGridView2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(417, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thống kê độc giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ThongKe_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 677);
            this.Controls.Add(this.btnExportToPDF);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThongKe_DocGia";
            this.Text = "ThongKe_DocGia";
            this.Load += new System.EventHandler(this.ThongKe_DocGia_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label label1;
    }
}