namespace QuanLyThuVien.View
{
    partial class ThongKe_Sach
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
            this.btnExportToPDF.Location = new System.Drawing.Point(383, 619);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(208, 50);
            this.btnExportToPDF.TabIndex = 19;
            this.btnExportToPDF.Text = "In";
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(22, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 506);
            this.panel2.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(63, 298);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(809, 106);
            this.dataGridView2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(378, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thống kê tài liệu";
            // 
            // ThongKe_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 690);
            this.Controls.Add(this.btnExportToPDF);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThongKe_Sach";
            this.Text = "ThongKe_Sach";
            this.Load += new System.EventHandler(this.ThongKe_Sach_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
    }
}