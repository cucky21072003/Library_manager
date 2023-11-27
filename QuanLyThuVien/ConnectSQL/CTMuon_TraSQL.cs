using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class CTMuon_TraSQL
    {
        static private CTMuon_TraSQL instance;

        public static CTMuon_TraSQL Instance
        {
            get { if (instance == null) instance = new CTMuon_TraSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertA(string Note, string ngaymuon, string ngayhentra, string ngatra, int phieumuonId, int tailieuId, int quydinhId, int SoLuong)
        {
            if (SoLuong < 0)
            {
                return false;
            }
            string query = $"insert into CTMuon_Tra (Note,NgayMuon,NgayHenTra,NgayTra,PhieuMuonId,TaiLieuId,QuyDinhId,SoLuong) " +
                $"values ('{Note}','{ngaymuon}','{ngayhentra}','{ngatra}',{phieumuonId},{tailieuId},{quydinhId},{SoLuong})";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool DeleteA(string Id)
        {
            string query = $"DELETE FROM CTMuon_Tra WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool UpdateA(string Id, string note, string ngaymuon, string ngayhentra, string ngaytra, int phieumuonId, int tailieuId, int quydinhId, int SoLuong)
        {
            if (SoLuong < 0)
            {
                return false;
            }
            string query = $"UPDATE CTMuon_Tra SET Note=N'{note}', NgayMuon='{ngaymuon}', NgayHenTra='{ngayhentra}', NgayTra='{ngaytra}', PhieuMuonId='{phieumuonId}',TaiLieuId='{tailieuId}',QuyDinhId='{quydinhId}',SoLuong='{SoLuong}' WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM CTMuon_Tra";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable SearchS(string name)
        {
            string query = $"SELECT * FROM CTMuon_Tra WHERE Id LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
