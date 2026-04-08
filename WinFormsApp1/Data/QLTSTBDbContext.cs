using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTB.Data
{
    internal class QLTSTBDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             "Server=DESKTOP-RL40ENI;Database=QLBH;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<ThietBiVanPhong> ThietBiVanPhongs { get; set; }
        public DbSet<LoaiThietBi> LoaiThietBis { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<PhieuCapPhat> PhieuCapPhats { get; set; }
        public DbSet<PhieuBaoTri> PhieuBaoTris { get; set; }
        public DbSet<KiemKe> KiemKes { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
    }
}
