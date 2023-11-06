using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class DocGia
    {
        public int Id { get; set; }
        public string TenDocGia { get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public int SoDienThoai { get; set; }

        public DocGia()
        {

        }

        public DocGia(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.TenDocGia = row["TenDocGia"].ToString();
            this.Lop = row["Lop"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.GioiTinh = row["GioiTinh"].ToString();
            this.SoDienThoai = (int)row["SoDienThoai"];
        }
    }
}
