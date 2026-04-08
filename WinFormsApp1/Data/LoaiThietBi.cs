using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class LoaiThietBi
    {
        public int ID { get; set; }
        [Required] public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public ICollection<ThietBiVanPhong> ThietBiVanPhongs { get; set; }
    }
}
