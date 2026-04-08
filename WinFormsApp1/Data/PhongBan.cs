using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class PhongBan
    {
        public int ID { get; set; }
        [Required] public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public ICollection<ThietBiVanPhong> ThietBiVanPhongs { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; }
    }
}
