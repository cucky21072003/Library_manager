using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.ConnectSQL;
using QuanLyThuVien.Model;


namespace QuanLyThuVien.View
{
    public partial class NhaXuatBan : Form
    {
        public NhaXuatBan()
        {
            InitializeComponent();
        }
        public void getData()
        {
            dgvNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNXB.DataSource = NhaXuatBanSQL.Instance.GetAllS();
            txtTenNXB.Text = "";
            txtDiaChi.Text = ""; 
            txtSDT.Text = "";
        }
        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgvNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNXB.CurrentCell.RowIndex;
            txtId.Text = dgvNXB.Rows[i].Cells[0].Value.ToString();
            txtTenNXB.Text = dgvNXB.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNXB.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvNXB.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable result = NhaXuatBanSQL.Instance.SearchS(txtSearch.Text);

            if (result.Rows.Count > 0)
            {
                dgvNXB.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable emptyTable = new DataTable();
                foreach (DataGridViewColumn col in dgvNXB.Columns)
                {
                    emptyTable.Columns.Add(col.Name, col.ValueType);
                }

                emptyTable.Rows.Add(emptyTable.NewRow());

                dgvNXB.DataSource = emptyTable;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (NhaXuatBanSQL.Instance.InsertA(txtTenNXB.Text,txtDiaChi.Text,txtSDT.Text))
            {
                MessageBox.Show($"Thêm thành công!");
                getData();
            }
            else
            {
                MessageBox.Show($"Thêm thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (NhaXuatBanSQL.Instance.UpdateA(txtId.Text, txtTenNXB.Text,txtDiaChi.Text,txtSDT.Text))
            {
                MessageBox.Show($"Sửa thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show($"Sửa thất bại!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NhaXuatBanSQL.Instance.DeleteA(txtId.Text))
            {
                MessageBox.Show($"Xóa thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show($"Xóa thất bại!!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
