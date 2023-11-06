using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class TheLoai
    {
        public string Id { get; set; }
        public string TenTheLoai { get; set; }

        public TheLoai() { }

        public TheLoai(DataRow row)
        {
            this.Id = row["Id"].ToString();
            this.TenTheLoai = row["TenTheLoai"].ToString();
        }
    }
}
