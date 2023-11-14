using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyThuVien.ConnectSQL;

namespace QuanLyThuVien.View
{
    public partial class ThongKe_Sach : Form
    {

        public ThongKe_Sach()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void getData()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = ToTalSach.Instance.TotalSach();
            
        }
        private void ThongKe_Sach_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
