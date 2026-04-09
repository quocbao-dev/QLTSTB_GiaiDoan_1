using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    [NotMapped]
    internal class PhanQuyen
    {
        public static string CurrentUser { get; set; } = "";
        public static string QuyenHan { get; set; } = "";
        public static bool IsAdmin() => QuyenHan == "Admin";
        public static bool Login(string tenDN, string mk)
        {
            using var db = new QLTSTBDbContext();
            var tk = db.TaiKhoans.FirstOrDefault(t =>
                t.TenDangNhap == tenDN && t.MatKhau == mk);
            if (tk != null)
            {
                CurrentUser = tk.HoTen;
                QuyenHan = tk.QuyenHan;
                return true;
            }
            return false;
        }
    }
}
