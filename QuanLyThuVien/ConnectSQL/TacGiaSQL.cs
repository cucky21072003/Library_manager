using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class TacGiaSQL
    {
        static private TacGiaSQL instance;

        public static TacGiaSQL Instance
        {
            get { if (instance == null) instance = new TacGiaSQL(); return instance; }
            private set => instance = value;
        }

        public bool insertAuthor(string nameAuthor)
        {
            string query = $"insert into TacGia (TenTacGIa) values ('{nameAuthor}')";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool deleteAuthor(string TacGiaId)
        {
            string query = $"DELETE FROM TacGia WHERE Id='{TacGiaId}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool updateAuthor(string TacGiaId, string nameAuthor)
        {
            string query = $"UPDATE TacGia SET TenTacGia=N'{nameAuthor}' WHERE Id='{TacGiaId}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllStaff()
        {
            string query = $"SELECT * FROM TacGia";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable searchStaff(string name)
        {
            string query = $"SELECT * FROM TacGia WHERE TenTacGia LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
