using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.ConnectSQL
{
    internal class QuyDinhSQL
    {
        static private QuyDinhSQL instance;

        public static QuyDinhSQL Instance
        {
            get { if (instance == null) instance = new QuyDinhSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertA(string name, string mota, string  ngaybanhanh)
        {
            string query = $"insert into QuyDinh (TenQuyDinh, MoTa, NgayBanHanh) values ('{name}','{mota}','{ngaybanhanh}')";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool DeleteA(string Id)
        {
            string query = $"DELETE FROM QuyDinh WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool UpdateA(string Id, string name, string mota, string ngaybanhanh)
        {
            string query = $"UPDATE QuyDinh SET TenQuyDinh=N'{name}', MoTa=N'{mota}', NgayBanHanh='{ngaybanhanh}' WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM QuyDinh";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable SearchS(string name)
        {
            string query = $"SELECT * FROM QuyDinh WHERE TenQuyDinh LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }

        
    }
}
