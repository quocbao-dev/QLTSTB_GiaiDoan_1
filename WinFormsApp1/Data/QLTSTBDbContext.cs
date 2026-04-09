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
             "Server=DESKTOP-RL40ENI;Database=QLTSTB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
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
