using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class TaiLieu
    {
        public string Id { get; set; }
        public string TenTaiLieu { get; set; }
        public string NamXuatBan { get; set; }

        public string SoLuong { get; set; }
        public string TinhTrang { get; set; }
        public int TacGiaID { get; set; }
        public int TheLoaiID { get; set; }
        public int NhaXuatBanId { get; set; }


        public TaiLieu() { }

        public TaiLieu(DataRow row)
        {
            this.Id = row["Id"].ToString();
            this.TenTaiLieu = row["TenTaiLieu"].ToString();
            this.NamXuatBan = row["NamXuatBan"].ToString();
            this.SoLuong = row["SoLuong"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
            this.TacGiaID = (int)row["TacGiaID"];
            this.TheLoaiID = (int)row["TheLoaiID"];
            this.NhaXuatBanId = (int)row["NhaXuatBanId"];

        }
    }
}
