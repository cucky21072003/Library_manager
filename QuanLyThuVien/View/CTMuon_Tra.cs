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
    public partial class CTMuon_Tra : Form
    {
        public CTMuon_Tra()
        {
            InitializeComponent();
            cmbNote.SelectedIndex = 0;
        }

        public void getData()
        {
            dgvCTMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTMuonTra.DataSource = CTMuon_TraSQL.Instance.GetAllS();
            txtSoLuong.Text = "";        }
        public void getCombobox()
        {
            cmbMaPhieu.DisplayMember = "Id";
            cmbMaPhieu.ValueMember = "Id";
            cmbMaPhieu.DataSource = PhieuMuonSQL.Instance.GetAllS();

            cmbMaTaiLieu.DisplayMember = "TenTaiLieu";
            cmbMaTaiLieu.ValueMember = "Id";
            cmbMaTaiLieu.DataSource = TaiLieuSQL.Instance.GetAllS();

            cmbQuyDinh.DisplayMember = "TenQuyDinh";
            cmbQuyDinh.ValueMember = "Id";
            cmbQuyDinh.DataSource = QuyDinhSQL.Instance.GetAllS();
        }
        private void CTMuon_Tra_Load(object sender, EventArgs e)
        {
            getData();
            getCombobox();
        }

        private void dgvCTMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCTMuonTra.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvCTMuonTra.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                cmbNote.SelectedItem = selectedRow.Cells[1].Value;
                DateTimeNgayMuon.Value = (DateTime)dgvCTMuonTra.Rows[e.RowIndex].Cells[2].Value;
                DateTimeNgayHenTra.Value = (DateTime)dgvCTMuonTra.Rows[e.RowIndex].Cells[3].Value;
                DateTimeNgayTra.Value = (DateTime)dgvCTMuonTra.Rows[e.RowIndex].Cells[4].Value;
                cmbMaPhieu.SelectedValue = selectedRow.Cells[5].Value;
                cmbMaTaiLieu.SelectedValue = selectedRow.Cells[6].Value;
                cmbQuyDinh.SelectedValue = selectedRow.Cells[7].Value;
                txtSoLuong.Text = selectedRow.Cells[8].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string dateMuon = DateTimeNgayMuon.Value.ToString("yyyy-MM-dd");
            string dateHentra = DateTimeNgayHenTra.Value.ToString("yyyy-MM-dd");
            string dateTra = DateTimeNgayTra.Value.ToString("yyyy-MM-dd");
            if (CTMuon_TraSQL.Instance.InsertA(cmbNote.SelectedItem.ToString(), 
                dateMuon,dateHentra,dateTra,
                (int)cmbMaPhieu.SelectedValue, (int)cmbMaTaiLieu.SelectedValue,(int)cmbQuyDinh.SelectedValue,
                Convert.ToInt32(txtSoLuong.Text)
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
            string dateMuon = DateTimeNgayMuon.Value.ToString("yyyy-MM-dd");
            string dateHentra = DateTimeNgayHenTra.Value.ToString("yyyy-MM-dd");
            string dateTra = DateTimeNgayTra.Value.ToString("yyyy-MM-dd");
            if (CTMuon_TraSQL.Instance.UpdateA(txtId.Text,cmbNote.SelectedItem.ToString(),
                dateMuon, dateHentra, dateTra,
                (int)cmbMaPhieu.SelectedValue, (int)cmbMaTaiLieu.SelectedValue, (int)cmbQuyDinh.SelectedValue,
                Convert.ToInt32(txtSoLuong.Text)
                ))
            {
                MessageBox.Show($"Sửa thành công!");
                getData();
            }
            else
            {
                MessageBox.Show($"Sửa thất bại!!");
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (CTMuon_TraSQL.Instance.DeleteA(txtId.Text))
            {
                MessageBox.Show($"Xóa thành công!!");
                getData();
            }
            else
            {
                MessageBox.Show($"Xóa thất bại!!");
            }
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            getData();
            getCombobox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCTMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTMuonTra.DataSource = CTMuon_TraSQL.Instance.SearchS(txtSearch.Text);
        }
    }
}
