using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyThuVien.ConnectSQL;

namespace QuanLyThuVien.View
{
    public partial class ThongKe_DocGia : Form
    {
        public ThongKe_DocGia()
        {
            InitializeComponent();
        }

        
        private void ThongKe_DocGia_Load(object sender, EventArgs e)
        {
            getData();
            
        }

        public void getData()
        {
            chartDocGia.Series.Add("PhieuMuon");
            
            chartDocGia.ChartAreas[0].AxisX.Title = "Tháng";
            chartDocGia.ChartAreas[0].AxisY.Title = "Số phiếu";

            chartDocGia.ChartAreas[0].AxisX.Minimum = 0;
            chartDocGia.ChartAreas[0].AxisX.Maximum = 13;

            
        }

        
        public void SetChart(string year)
        {
            chartDocGia.Series["PhieuMuon"].Points.AddXY("1", Statistic("1", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("2", Statistic("2", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("3", Statistic("3", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("4", Statistic("4", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("5", Statistic("5", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("6", Statistic("6", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("7", Statistic("7", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("8", Statistic("8", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("9", Statistic("9", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("10", Statistic("10", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("11", Statistic("11", year));
            chartDocGia.Series["PhieuMuon"].Points.AddXY("12", Statistic("12", year));
        }

        public int Statistic (string month, string year) 
        { 
            DataTable data;
            data = ThongKe_DocGiaSQL.Instance.TotalPhieuMuon(month, year);
            if (int.TryParse(data.Rows[0]["tongphieu"].ToString(), out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }

        }
        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetChart(txtThongKeDG.Text);
        }
    }
}
