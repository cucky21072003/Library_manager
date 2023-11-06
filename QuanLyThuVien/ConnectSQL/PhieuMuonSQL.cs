using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class PhieuMuonSQL
    {
        static private PhieuMuonSQL instance;

        public static PhieuMuonSQL Instance
        {
            get { if (instance == null) instance = new PhieuMuonSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertA(int docgiaId, int nhanvienId)
        {
            string query = $"insert into PhieuMuon (DocGId,NhanVienId) values ('{docgiaId}','{nhanvienId}')";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool DeleteA(string Id)
        {
            string query = $"DELETE FROM PhieuMuon WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool UpdateA(string Id, int docgiaId, int nhanvienId)
        {
            string query = $"UPDATE PhieuMuon SET DocGId='{docgiaId}', NhanVienId='{nhanvienId}' WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM PhieuMuon";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable SearchS(string name)
        {
            string query = $"SELECT * FROM PhieuMuon WHERE Id = '{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
