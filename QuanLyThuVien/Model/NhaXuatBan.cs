using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class NhaXuatBan
    {
       
            public string Id { get; set; }
            public string TenNhaXuatBan { get; set; }
            public string DiaChi { get; set; }
            public string SoDienThoai { get; set; }

            public NhaXuatBan() { }

            public NhaXuatBan(DataRow row)
            {
                this.Id = row["Id"].ToString();
            this.TenNhaXuatBan = row["TenNhaXuatBan"].ToString();
                this.DiaChi = row["DiaChi"].ToString();
                this.SoDienThoai = row["SoDienThoai"].ToString();
        }
    }
}
