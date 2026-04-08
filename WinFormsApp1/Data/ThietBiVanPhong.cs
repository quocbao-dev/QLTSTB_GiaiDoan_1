using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class ThietBiVanPhong
    {
        public int ID { get; set; }
        [Required] public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public decimal GiaTri { get; set; }
        public DateTime NgayMua { get; set; } = DateTime.Now;
        public string TrangThai { get; set; } = "Hoạt động";
        public int LoaiThietBiID { get; set; }
        public int PhongBanID { get; set; }

        public LoaiThietBi LoaiThietBi { get; set; }
        public PhongBan PhongBan { get; set; }
        public ICollection<PhieuCapPhat> PhieuCapPhats { get; set; }
        public ICollection<PhieuBaoTri> PhieuBaoTris { get; set; }
        public ICollection<KiemKe> KiemKes { get; set; }
    }
}
