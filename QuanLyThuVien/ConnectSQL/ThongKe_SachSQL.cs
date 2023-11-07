using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class ThongKe_SachSQL
    {
        public static ThongKe_SachSQL Instance
        {
            get { if (Instance == null) Instance = new ThongKe_SachSQL(); return Instance; }
            private set => Instance = value;
        }

        public DataTable TotalxSachMuon()
        {
            string query = $"select  count (*) as tongSachMuon from CTMuon_Tra";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }

        public DataTable TotalTaiLieu()
        {
            string query = $"select  count (*) as tongTaiLieu from TaiLieu";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
