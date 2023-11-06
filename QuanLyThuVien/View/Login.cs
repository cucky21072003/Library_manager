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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string usetName = txtTaiKhoan.Text;
            string passWord = txtMatKhau.Text;

            if (string.IsNullOrEmpty(usetName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
            }
            else if (LoginSQL.Instance.LoginCheck(usetName, passWord))
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Account không hợp lệ. Vui long nhập lại!");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát hệ thống?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK) e.Cancel = true;
        }
    }
}
