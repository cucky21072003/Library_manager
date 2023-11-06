using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class NhaXuatBanSQL
    {
        static private NhaXuatBanSQL instance;

        public static NhaXuatBanSQL Instance
        {
            get { if (instance == null) instance = new NhaXuatBanSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertA(string nameAuthor, string diachi, string sdt)
        {
            string query = $"insert into NhaXuatBan (TenNhaXuatBan, DiaChi, SoDienThoai) values ('{nameAuthor}','{diachi}','{sdt}')";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool DeleteA(string NXBId)
        {
            string query = $"DELETE FROM NhaXuatBan WHERE Id='{NXBId}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool UpdateA(string Id, string name, string diachi, string sdt)
        {
            string query = $"UPDATE NhaXuatBan SET TenNhaXuatBan=N'{name}', DiaChi=N'{diachi}', SoDienThoai='{sdt}' WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM NhaXuatBan";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable SearchS(string name)
        {
            string query = $"SELECT * FROM NhaXuatBan WHERE TenNhaXuatBan LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
