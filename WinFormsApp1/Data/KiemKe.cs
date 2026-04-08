using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class KiemKe
    {

        public int ID { get; set; }
        public DateTime NgayKiemKe { get; set; } = DateTime.Now;
        public string NguoiKiem { get; set; }
        public string TrangThai { get; set; }
        public int ThietBiID { get; set; }
        public ThietBiVanPhong ThietBiVanPhong { get; set; }
    }
}
