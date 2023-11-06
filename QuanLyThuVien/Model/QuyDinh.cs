using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class QuyDinh
    {
        public int Id { get; set; }

        public string TenQuyDinh { get; set; }

        public string MoTa { get; set; }

        public DateTime NgayBanHanh { get; set; }

        public QuyDinh() { }
        public QuyDinh(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.TenQuyDinh = row["TenQuyDinh"].ToString();
            this.MoTa = row["MoTa"].ToString();
            this.NgayBanHanh = (DateTime)row["NgayBanHanh"];
        }
    }
}
