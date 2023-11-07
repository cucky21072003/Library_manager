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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartDocGia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThongKeDG = new System.Windows.Forms.TextBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartDocGia);
            this.panel2.Location = new System.Drawing.Point(31, 209);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 457);
            this.panel2.TabIndex = 17;
            // 
            // chartDocGia
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDocGia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDocGia.Legends.Add(legend1);
            this.chartDocGia.Location = new System.Drawing.Point(63, 30);
            this.chartDocGia.Name = "chartDocGia";
            this.chartDocGia.Size = new System.Drawing.Size(864, 397);
            this.chartDocGia.TabIndex = 4;
            this.chartDocGia.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(388, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thống kê số phiếu mượn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập năm";
            // 
            // txtThongKeDG
            // 
            this.txtThongKeDG.Location = new System.Drawing.Point(452, 133);
            this.txtThongKeDG.Name = "txtThongKeDG";
            this.txtThongKeDG.Size = new System.Drawing.Size(152, 22);
            this.txtThongKeDG.TabIndex = 19;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(633, 132);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(104, 23);
            this.btnThongKe.TabIndex = 20;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // ThongKe_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 677);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.txtThongKeDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThongKe_DocGia";
            this.Text = "ThongKe_DocGia";
            this.Load += new System.EventHandler(this.ThongKe_DocGia_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThongKeDG;
        private System.Windows.Forms.Button btnThongKe;
    }
}