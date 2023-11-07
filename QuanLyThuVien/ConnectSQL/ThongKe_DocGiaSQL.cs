using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class ThongKe_DocGiaSQL
    {
        static private ThongKe_DocGiaSQL instance;

        public static ThongKe_DocGiaSQL Instance
        {
            get { if (instance == null) instance = new ThongKe_DocGiaSQL(); return instance; }
            private set => instance = value;
        }

        public DataTable TotalPhieuMuon(string month, string year)
        {
            string query = $"select  count (*) as tongphieu from CTMuon_Tra Where YEAR(NgayMuon) = 2000 and MONTH(NgayMuon) = 1";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
