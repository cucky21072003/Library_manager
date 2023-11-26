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
    public partial class TaiLieu : Form
    {
        public TaiLieu()
        {
            InitializeComponent();
        }


        private void TaiLieu_Load(object sender, EventArgs e)
        {
            getData();
            getCombobox();
        }
        public void getData()
        {
            dgvTaiLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiLieu.DataSource = TaiLieuSQL.Instance.GetAllS();
            txtTenTaiLieu.Text = "";
            txtNamXuatBan.Text = "";
            txtSoLuong.Text = "";
            txtTinhTrang.Text = "";
        }
        public void getCombobox()
        {
            cmbTL.DisplayMember = "TenTheLoai";
            cmbTL.ValueMember = "Id";
            cmbTL.DataSource = TheLoaiSQL.Instance.GetAllS();

            cmbTG.DisplayMember = "TenTacGia";
            cmbTG.ValueMember = "Id";
            cmbTG.DataSource = TacGiaSQL.Instance.GetAllStaff();

            cmbNXB.DisplayMember = "TenNhaXuatBan";
            cmbNXB.ValueMember = "Id";
            cmbNXB.DataSource = NhaXuatBanSQL.Instance.GetAllS();
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TaiLieuSQL.Instance.InsertA(txtTenTaiLieu.Text, txtNamXuatBan.Text, 
                txtSoLuong.Text, txtTinhTrang.Text, (int)cmbTG.SelectedValue,(int) cmbTL.SelectedValue,
                (int)cmbNXB.SelectedValue))
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
            if (TaiLieuSQL.Instance.UpdateA(txtId.Text, txtTenTaiLieu.Text, txtNamXuatBan.Text,
                txtSoLuong.Text, txtTinhTrang.Text,
                (int)cmbTG.SelectedValue, (int)cmbTL.SelectedValue,
                (int)cmbNXB.SelectedValue))
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
            if (TaiLieuSQL.Instance.DeleteA(txtId.Text))
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTaiLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiLieu.DataSource = TaiLieuSQL.Instance.SearchS(txtSearch.Text);
        }

        private void dgvTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTaiLieu.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvTaiLieu.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtTenTaiLieu.Text = selectedRow.Cells[1].Value.ToString();
                txtNamXuatBan.Text = selectedRow.Cells[2].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[3].Value.ToString();
                txtTinhTrang.Text = selectedRow.Cells[4].Value.ToString();

                // Select the appropriate item in ComboBox
                cmbTG.SelectedValue = selectedRow.Cells[5].Value;
                cmbTL.SelectedValue = selectedRow.Cells[6].Value;
                cmbNXB.SelectedValue = selectedRow.Cells[7].Value;
            }
        }
    }
}
