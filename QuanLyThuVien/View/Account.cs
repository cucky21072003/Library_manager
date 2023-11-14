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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            
        }

        private void Account_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.DataSource = LoginSQL.Instance.GetAllAccount();
            txtId.Text = "";
            txtUserName.Text = "";
            txtPass.Text = "";
            txtFunction.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LoginSQL.Instance.insertAccount(txtUserName.Text, txtPass.Text, txtFunction.Text
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
            if (LoginSQL.Instance.updateAccount(Convert.ToInt32(txtId.Text), txtUserName.Text, txtPass.Text, txtFunction.Text
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
            if (LoginSQL.Instance.deleteAccount(Convert.ToInt32(txtId.Text)))
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
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.DataSource = LoginSQL.Instance.searchAccount(txtSearch.Text);
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvAccount.Rows[e.RowIndex];
            txtId.Text = selectedRow.Cells[0].Value.ToString();
            txtUserName.Text = selectedRow.Cells[1].Value.ToString();
            txtPass.Text = selectedRow.Cells[2].Value.ToString();
            txtFunction.Text = selectedRow.Cells[3].Value.ToString();
        }
    }
}
