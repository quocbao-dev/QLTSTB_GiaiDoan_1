using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLTSTB.Data
{
    internal class NhanVien
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string MaNV { get; set; }
        [Required]
        public string HoTen { get; set; }
        public string Email { get; set; }
        public int PhongBanID { get; set; }
        public virtual PhongBan PhongBan { get; set; }
    }
}
