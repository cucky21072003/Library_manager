using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class NhanVien
    {
        public int Id { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }


        public int SoDienThoai { get; set; }

        public NhanVien() { }

        public NhanVien(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.TenNhanVien = row["TenDocGia"].ToString();
            this.DiaChi = row["Lop"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.GioiTinh = row["GioiTinh"].ToString();
            this.SoDienThoai = (int)row["SoDienThoai"];
        }
    }
}
