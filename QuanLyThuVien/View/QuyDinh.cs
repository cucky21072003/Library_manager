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
    public partial class QuyDinh : Form
    {
        public QuyDinh()
        {
            InitializeComponent();
        }
        public void getData()
        {
            dgvQuyDinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuyDinh.DataSource = QuyDinhSQL.Instance.GetAllS();
            txtTenQD.Text = "";
            txtMoTa.Text = "";
        }
        private void QuyDinh_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgvQuyDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvQuyDinh.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvQuyDinh.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtTenQD.Text = selectedRow.Cells[1].Value.ToString();
                txtMoTa.Text = selectedRow.Cells[2].Value.ToString();
                DateNgayBH.Value = (DateTime)dgvQuyDinh.Rows[e.RowIndex].Cells[3].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string dayBH = DateNgayBH.Value.ToString("yyyy-MM-dd");
            if (QuyDinhSQL.Instance.InsertA(txtTenQD.Text, txtMoTa.Text, dayBH
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
            string dayBH = DateNgayBH.Value.ToString("yyyy-MM-dd");
            if (QuyDinhSQL.Instance.UpdateA(txtId.Text,txtTenQD.Text, txtMoTa.Text, dayBH
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
            if (QuyDinhSQL.Instance.DeleteA(txtId.Text))
            {
                MessageBox.Show($"Xóa thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show($"Xóa thất bại!!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvQuyDinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuyDinh.DataSource = DocGiaSQL.Instance.SearchS(txtTimKiem.Text);
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
