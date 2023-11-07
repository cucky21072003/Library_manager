using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.ConnectSQL;

namespace QuanLyThuVien.View
{
    public partial class ThongKe_Sach : Form
    {

        public ThongKe_Sach()
        {
            InitializeComponent();
        }
        public void getData()
        {
            chartTaiLieu.Series.Add("TongSachMuon ");
            chartTaiLieu.Series.Add("TongTaiLieu");

            chartTaiLieu.ChartAreas[0].Axes.ToString();
            chartTaiLieu.ChartAreas[0].Axes.ToString();

        }
        public int Statistic(string month, string year)
        {
            DataTable data;
            data = ThongKe_SachSQL.Instance.TotalxSachMuon();
            data = ThongKe_SachSQL.Instance.TotalTaiLieu();
            if (int.TryParse(data.Rows[0]["tongSachMuon"].ToString(), out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }

        }
        private void ThongKe_Sach_Load(object sender, EventArgs e)
        {

        }

    }
}
