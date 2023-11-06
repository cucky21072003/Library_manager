using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class NhanVienSQL
    {
        static private NhanVienSQL instance;

        public static NhanVienSQL Instance
        {
            get { if (instance == null) instance = new NhanVienSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertA(string name, string diachi, string ngaysinh, string gioitinh, int sdt)
        {
            string query = $"insert into NhanVien (TenNhanVien,DiaChi,NgaySinh,GioiTinh,SoDienThoai) " +
                $"values ('{name}','{diachi}','{ngaysinh}','{gioitinh}',{sdt})";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool DeleteA(string Id)
        {
            string query = $"DELETE FROM NhanVien WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool UpdateA(string Id, string name, string diachi, string ngaysinh, string gioitinh, int sdt)
        {
            string query = $"UPDATE NhanVien SET TenNhanVien=N'{name}', DiaChi='{diachi}', NgaySinh='{ngaysinh}', GioiTinh=N'{gioitinh}', SoDienThoai='{sdt}' WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM NhanVien";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable SearchS(string name)
        {
            string query = $"SELECT * FROM NhanVien WHERE TenNhanVien LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
