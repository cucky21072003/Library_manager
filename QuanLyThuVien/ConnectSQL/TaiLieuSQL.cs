using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ConnectSQL
{
    internal class TaiLieuSQL
    {
        static private TaiLieuSQL instance;

        public static TaiLieuSQL Instance
        {
            get { if (instance == null) instance = new TaiLieuSQL(); return instance; }
            private set => instance = value;
        }

        public bool InsertA(string name, string namxb, string soluong, string tinhtrang,int tacgiaid, int theloaiid, int nxbid)
        {
            string query = $"insert into TaiLieu (TenTaiLieu,NamXuatBan,SoLuong,TinhTrang,TacGiaId,TheLoaiId,NhaXuatBanId) " +
                $"values ('{name}','{namxb}','{soluong}','{tinhtrang}',{tacgiaid},{theloaiid},{nxbid})";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool DeleteA(string Id)
        {
            string query = $"DELETE FROM TaiLieu WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public bool UpdateA(string Id, string name, string namxb, string soluong, string tinhtrang, int tacgiaid, int theloaiid, int nxbid)
        {
            string query = $"UPDATE TaiLieu SET TenTaiLieu=N'{name}', NamXuatBan='{namxb}', SoLuong='{soluong}', TinhTrang=N'{tinhtrang}', TacGiaId='{tacgiaid}',TheLoaiId='{theloaiid}',NhaXuatBanId='{nxbid}' WHERE Id='{Id}'";
            return Connect.Instance.ExecuteNonOuery(query);
        }
        public DataTable GetAllS()
        {
            string query = $"SELECT * FROM TaiLieu";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
        public DataTable SearchS(string name)
        {
            string query = $"SELECT * FROM TaiLieu WHERE TenTaiLieu LIKE N'{name}'";
            DataTable retult = Connect.Instance.ExecuteOuery(query);
            return retult;
        }
    }
}
