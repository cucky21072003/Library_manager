using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class TacGia
    {
        public string Id { get; set; }
        public string TenTacGia { get; set; }

        public TacGia() { }

        public TacGia(DataRow row)
        {
            this.Id = row["Id"].ToString();
            this.TenTacGia = row["TenTacGia"].ToString();
        }
    }
}
