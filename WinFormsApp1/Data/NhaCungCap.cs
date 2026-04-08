using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class NhaCungCap
    {
        public int ID { get; set; }
        [Required] public string TenNCC { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}
