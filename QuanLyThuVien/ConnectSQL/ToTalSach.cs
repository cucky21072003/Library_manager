using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.ConnectSQL
{
    internal class ToTalSach
    {
        static private ToTalSach instance;
        public static ToTalSach Instance
        {
            get { if (instance == null) instance = new ToTalSach(); return instance; }
            private set => instance = value;
        }
        public DataTable TotalSach()
        {
            string query = $"SELECT TaiLieu.Id,TaiLieu.TenTaiLieu, TaiLieu.SoLuong - COALESCE(SUM(CTMuon_Tra.SoLuong), 0) AS TaiLieu_ConLai" +
                $"FROM TaiLieu " +
                $"LEFT JOIN CTMuon_Tra ON  TaiLieu.Id = CTMuon_Tra.Id" +
                $"GROUP BY TaiLieu.Id = , TaiLieu.TenTaiLieu = , TaiLieu.SoLuong ";

            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }

        
    }
}
