using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.View
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
            hiddenSubMenu();
        }

        private void hiddenSubMenu()
        {
            pnlMenuQLMuonTra.Visible = false;
            pnlMenuQLTaiLieu.Visible = false;
            pnlMenuThongKe.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hiddenSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildHome.Controls.Add(childForm);
            panelChildHome.Tag = childForm;
            // panelLeftMenu.Visible = false;
            childForm.BringToFront();
            childForm.Show();

        }


        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenuQLTaiLieu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnTaiLieu_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiLieu());
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            openChildForm(new TacGia());
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            openChildForm(new TheLoai());
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            openChildForm(new NhaXuatBan());
        }

        private void pnlMenuQLMuonTra_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            openChildForm(new PhieuMuon());
        }

        private void btnCTMuon_Tra_Click(object sender, EventArgs e)
        {
            openChildForm(new CTMuon_Tra());
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            openChildForm(new QuyDinh());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDocGIa_Click(object sender, EventArgs e)
        {
            openChildForm(new DocGia());
        }

        private void btnQLTL_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMenuQLTaiLieu);
        }

        private void btnQLMT_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMenuQLMuonTra);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMenuThongKe);
        }

        private void pnlMenuThongKe_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnThongKeSach_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe_Sach());
        }

        private void btnThongKeDocGia_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe_DocGia());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void panelChildHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
