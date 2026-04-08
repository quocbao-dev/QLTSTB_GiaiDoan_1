using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class PhieuBaoTri
    {
        public int ID { get; set; }
        public DateTime NgayBaoTri { get; set; } = DateTime.Now;
        public decimal ChiPhi { get; set; }
        public string MoTa { get; set; }
        public int ThietBiID { get; set; }
        public ThietBiVanPhong ThietBiVanPhong { get; set; }
    }
}
