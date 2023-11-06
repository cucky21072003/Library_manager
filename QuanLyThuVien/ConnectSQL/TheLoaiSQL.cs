using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class TheLoaiSQL
    {
        static private TheLoaiSQL instance;

        public static TheLoaiSQL Instance
        {
            get { if (instance == null) instance = new TheLoaiSQL(); return instance; }
            private set => instance = value;
        }

        public bool insertA(string nameAuthor)
        {
            string query = $"insert into TheLoai (TenTheLoai) values ('{nameAuthor}')";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool deleteA(string TacGiaId)
        {
            string query = $"DELETE FROM TheLoai WHERE Id='{TacGiaId}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool updateA(string TacGiaId, string nameAuthor)
        {
            string query = $"UPDATE TheLoai SET TenTheLoai=N'{nameAuthor}' WHERE Id='{TacGiaId}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM TheLoai";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable searchS(string name)
        {
            string query = $"SELECT * FROM TheLoai WHERE TenTheLoai LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }

    }
}
