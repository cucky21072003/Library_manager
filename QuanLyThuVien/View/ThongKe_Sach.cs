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
            DataTable dataTable = ToTalSach.Instance.TotalSach();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ToTalSach.Instance.TotalSach());
            dv.RowFilter = $"TenTaiLieu LIKE '%{txtTimKiem.Text}%'";

            if (dv.Count > 0)
            {
                dataGridView1.DataSource = dv;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tạo DataTable mới với cấu trúc giống với DataGridView
                DataTable emptyTable = new DataTable();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    emptyTable.Columns.Add(col.Name, col.ValueType);
                }

                // Thêm một dòng trắng vào DataTable
                emptyTable.Rows.Add(emptyTable.NewRow());

                // Hiển thị DataTable trắng trên DataGridView
                dataGridView1.DataSource = emptyTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
            txtTimKiem.Text = "";
        }
    }
}
