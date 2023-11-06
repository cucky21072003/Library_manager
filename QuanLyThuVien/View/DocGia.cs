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
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
            cmbGioiTinh.SelectedIndex = 0;
        }
        public void getData()
        {
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.DataSource = DocGiaSQL.Instance.GetAllS();
            txtTenDG.Text = "";
            txtLop.Text = "";
            txtSDT.Text = "";
          
        }
        private void DocGia_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDocGia.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDocGia.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtTenDG.Text = selectedRow.Cells[1].Value.ToString();
                txtLop.Text = selectedRow.Cells[2].Value.ToString();
                DateTimeNgS.Value = (DateTime)dgvDocGia.Rows[e.RowIndex].Cells[3].Value;
                cmbGioiTinh.SelectedItem = selectedRow.Cells[4].Value;
                txtSDT.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
     
            string birthOfDate = DateTimeNgS.Value.ToString("yyyy-MM-dd");
            if (DocGiaSQL.Instance.InsertA(txtTenDG.Text, txtLop.Text, birthOfDate,
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

        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            string birthOfDate = DateTimeNgS.Value.ToString("yyyy-MM-dd");
            if (DocGiaSQL.Instance.UpdateA(txtId.Text, txtTenDG.Text, txtLop.Text, birthOfDate,
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
            if (DocGiaSQL.Instance.DeleteA(txtId.Text))
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

        private void btnSearchDG_Click(object sender, EventArgs e)
        {
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.DataSource = DocGiaSQL.Instance.SearchS(txtSearch.Text);
        }
    }
}
