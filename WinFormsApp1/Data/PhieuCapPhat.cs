using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class PhieuCapPhat
    {
        public int ID { get; set; }
        public DateTime NgayCapPhat { get; set; } = DateTime.Now;
        public DateTime? NgayTra { get; set; }
        public int ThietBiID { get; set; }
        public int NhanVienID { get; set; }

        public ThietBiVanPhong ThietBiVanPhong { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
