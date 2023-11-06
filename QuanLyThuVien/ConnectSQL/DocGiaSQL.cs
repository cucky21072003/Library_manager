using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThuVien.ConnectSQL
{
    internal class DocGiaSQL
    {
        static private DocGiaSQL instance;

        public static DocGiaSQL Instance
        {
            get { if (instance == null) instance = new DocGiaSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertA(string name, string lop, string ngaysinh, string gioitinh, int sdt)
        {
            string query = $"insert into DocG (TenDocGia,Lop,NgaySinh,GioiTinh,SoDienThoai) " +
                $"values ('{name}','{lop}','{ngaysinh}','{gioitinh}',{sdt})";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool DeleteA(string Id)
        {
            string query = $"DELETE FROM DocG WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool UpdateA(string Id, string name, string lop, string ngaysinh, string gioitinh, int sdt)
        {
            string query = $"UPDATE DocG SET TenDocGia=N'{name}', Lop='{lop}', NgaySinh='{ngaysinh}', GioiTinh=N'{gioitinh}', SoDienThoai='{sdt}' WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM DocG";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable SearchS(string name)
        {
            string query = $"SELECT * FROM DocG WHERE TenDocGia LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
