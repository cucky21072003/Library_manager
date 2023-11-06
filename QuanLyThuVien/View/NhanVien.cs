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

namespace QuanLyThuVien.View
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            cmbGioiTinh.SelectedIndex = 0;
        }
        public void getData()
        {
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.DataSource = NhanVienSQL.Instance.GetAllS();
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string birthOfDate = DateTimeNgS.Value.ToString("yyyy-MM-dd");
            if (NhanVienSQL.Instance.InsertA(txtTenNV.Text, txtDiaChi.Text, birthOfDate,
                 cmbGioiTinh.SelectedItem.ToString(), Convert.ToInt32(txtSDT.Text)
                ))
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
            string birthOfDate = DateTimeNgS.Value.ToString("yyyy-MM-dd");
            if (NhanVienSQL.Instance.UpdateA(txtId.Text, txtTenNV.Text, txtDiaChi.Text, birthOfDate,
                cmbGioiTinh.SelectedItem.ToString(), Convert.ToInt32(txtSDT.Text)
                ))
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
            if (NhanVienSQL.Instance.DeleteA(txtId.Text))
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtTenNV.Text = selectedRow.Cells[1].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells[2].Value.ToString();
                DateTimeNgS.Value = (DateTime)dgvNhanVien.Rows[e.RowIndex].Cells[3].Value;
                cmbGioiTinh.SelectedItem = selectedRow.Cells[4].Value;
                txtSDT.Text = selectedRow.Cells[5].Value.ToString();
            }
        }
    }
}
