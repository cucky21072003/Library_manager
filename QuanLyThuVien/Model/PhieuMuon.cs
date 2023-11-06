using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class PhieuMuon
    {
        public int Id { get; set; }
        public int NhanVienId { get; set; }
        public int DocGId { get; set; }

        public PhieuMuon() { }

        public PhieuMuon(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.NhanVienId = (int)row["NhanVienId"];
            this.DocGId = (int)row["DocGId"];
        }
    }
}
