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
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            dgvTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTL.DataSource = TheLoaiSQL.Instance.GetAllS();
            txtTenTL.Text = "";
        }
        private void dgvTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTL.CurrentCell.RowIndex;
            txtId.Text = dgvTL.Rows[i].Cells[0].Value.ToString();
            txtTenTL.Text = dgvTL.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTL.DataSource = TheLoaiSQL.Instance.searchS(txtSearch.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TheLoaiSQL.Instance.insertA(txtTenTL.Text))
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
            if (TheLoaiSQL.Instance.updateA(txtId.Text, txtTenTL.Text))
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
            if (TheLoaiSQL.Instance.deleteA(txtId.Text))
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
