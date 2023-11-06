﻿using System;
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
    public partial class TacGia : Form
    {
        public TacGia()
        {
            InitializeComponent();
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            dgvTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTG.DataSource = TacGiaSQL.Instance.GetAllStaff();
            txtTenTG.Text = "";
        }

        private void dgvTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTG.CurrentCell.RowIndex;
            txtId.Text = dgvTG.Rows[i].Cells[0].Value.ToString();
            txtTenTG.Text = dgvTG.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTG.DataSource = TacGiaSQL.Instance.searchStaff(txtSearch.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TacGiaSQL.Instance.insertAuthor(txtTenTG.Text))
            {
                MessageBox.Show($"Thêm tác giả thành công!");
                getData();
            }
            else
            {
                MessageBox.Show($"Thêm tác giả thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TacGiaSQL.Instance.updateAuthor(txtId.Text, txtTenTG.Text))
            {
                MessageBox.Show($"Sửa tác giả thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show($"Sửa tác giả thất bại!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TacGiaSQL.Instance.deleteAuthor(txtId.Text))
            {
                MessageBox.Show($"Xóa tác giả thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show($"Xóa tác giả thất bại!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}