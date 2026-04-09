using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class TaiKhoan
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public string QuyenHan { get; set; } 
        public string HoTen { get; set; }
        public int? NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
