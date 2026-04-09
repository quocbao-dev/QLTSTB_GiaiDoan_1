using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLTSTB.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiThietBis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiThietBis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenPhong = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongBanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_PhongBanID",
                        column: x => x.PhongBanID,
                        principalTable: "PhongBans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThietBiVanPhongs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTri = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiThietBiID = table.Column<int>(type: "int", nullable: false),
                    PhongBanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBiVanPhongs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThietBiVanPhongs_LoaiThietBis_LoaiThietBiID",
                        column: x => x.LoaiThietBiID,
                        principalTable: "LoaiThietBis",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThietBiVanPhongs_PhongBans_PhongBanID",
                        column: x => x.PhongBanID,
                        principalTable: "PhongBans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuyenHan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_NhanViens_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KiemKes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayKiemKe = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiKiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThietBiID = table.Column<int>(type: "int", nullable: false),
                    ThietBiVanPhongID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KiemKes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KiemKes_ThietBiVanPhongs_ThietBiVanPhongID",
                        column: x => x.ThietBiVanPhongID,
                        principalTable: "ThietBiVanPhongs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuBaoTris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayBaoTri = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChiPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThietBiID = table.Column<int>(type: "int", nullable: false),
                    ThietBiVanPhongID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuBaoTris", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuBaoTris_ThietBiVanPhongs_ThietBiVanPhongID",
                        column: x => x.ThietBiVanPhongID,
                        principalTable: "ThietBiVanPhongs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuCapPhats",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayCapPhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThietBiID = table.Column<int>(type: "int", nullable: false),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    ThietBiVanPhongID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuCapPhats", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuCapPhats_NhanViens_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanViens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuCapPhats_ThietBiVanPhongs_ThietBiVanPhongID",
                        column: x => x.ThietBiVanPhongID,
                        principalTable: "ThietBiVanPhongs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KiemKes_ThietBiVanPhongID",
                table: "KiemKes",
                column: "ThietBiVanPhongID");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanID",
                table: "NhanViens",
                column: "PhongBanID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuBaoTris_ThietBiVanPhongID",
                table: "PhieuBaoTris",
                column: "ThietBiVanPhongID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuCapPhats_NhanVienID",
                table: "PhieuCapPhats",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuCapPhats_ThietBiVanPhongID",
                table: "PhieuCapPhats",
                column: "ThietBiVanPhongID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_NhanVienID",
                table: "TaiKhoans",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiVanPhongs_LoaiThietBiID",
                table: "ThietBiVanPhongs",
                column: "LoaiThietBiID");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiVanPhongs_PhongBanID",
                table: "ThietBiVanPhongs",
                column: "PhongBanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KiemKes");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.DropTable(
                name: "PhieuBaoTris");

            migrationBuilder.DropTable(
                name: "PhieuCapPhats");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "ThietBiVanPhongs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "LoaiThietBis");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
