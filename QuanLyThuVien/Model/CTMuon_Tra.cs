using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Model
{
    internal class CTMuon_Tra
    {
        public int Id { get; set; }
        public string Note { get; set; }   //.....
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayHenTra { get; set; }
        public DateTime? NgayTra { get; set; }

        public int PhieuMuonId { get; set; }

        public int TaiLieuId { get; set; }

        public int QuyDinhId { get; set; }

        public CTMuon_Tra()
        {

        }

        public CTMuon_Tra(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Note = row["Note"].ToString();
            this.NgayMuon = (DateTime)row["NgayMuon"];
            this.NgayHenTra = (DateTime)row["NgayHenTra"];
            this.NgayTra = (DateTime)row["NgayTra"];
            this.PhieuMuonId = (int)row["PhieuMuonId"];
            this.TaiLieuId = (int)row["TaiLieuId"];
            this.QuyDinhId = (int)row["QuyDinhId"];
        }
    }
}
