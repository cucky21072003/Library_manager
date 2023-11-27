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
    public partial class PhieuMuon : Form
    {
        public PhieuMuon()
        {
            InitializeComponent();
        }
        public void getData()
        {
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.DataSource = PhieuMuonSQL.Instance.GetAllS();

            cmbDG.DisplayMember = "TenDocGia";
            cmbDG.ValueMember = "Id";
            cmbDG.DataSource = DocGiaSQL.Instance.GetAllS();

            cmbNV.DisplayMember = "TenNhanVien";
            cmbNV.ValueMember = "Id";
            cmbNV.DataSource = NhanVienSQL.Instance.GetAllS();
        }
        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhieuMuon.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvPhieuMuon.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                cmbDG.SelectedValue = selectedRow.Cells[1].Value;
                cmbNV.SelectedValue = selectedRow.Cells[2].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (PhieuMuonSQL.Instance.InsertA( (int)cmbDG.SelectedValue,
                (int)cmbNV.SelectedValue))
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
            if (PhieuMuonSQL.Instance.UpdateA(txtId.Text, (int)cmbDG.SelectedValue,
                (int)cmbNV.SelectedValue))
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
            if (PhieuMuonSQL.Instance.DeleteA(txtId.Text))
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
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable result = PhieuMuonSQL.Instance.SearchS(txtSearch.Text);

            if (result.Rows.Count > 0)
            {
                dgvPhieuMuon.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable emptyTable = new DataTable();
                foreach (DataGridViewColumn col in dgvPhieuMuon.Columns)
                {
                    emptyTable.Columns.Add(col.Name, col.ValueType);
                }

                emptyTable.Rows.Add(emptyTable.NewRow());

                dgvPhieuMuon.DataSource = emptyTable;
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
