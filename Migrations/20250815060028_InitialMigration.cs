using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRO131_01.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Giay",
                columns: table => new
                {
                    MaGiay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hang = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giay", x => x.MaGiay);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Ma = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    MaVoucher = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenVoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTriApDung = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaTriGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaTriGiamToiDa = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LoaiVoucher = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.MaVoucher);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTienGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MaVoucher = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaNhanVien = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MaKhachHang = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Ma");
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Ma");
                    table.ForeignKey(
                        name: "FK_HoaDon_Voucher_MaVoucher",
                        column: x => x.MaVoucher,
                        principalTable: "Voucher",
                        principalColumn: "MaVoucher");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHDCT = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.MaHDCT);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiayChiTiet",
                columns: table => new
                {
                    MaGiayChiTiet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Mau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<long>(type: "bigint", nullable: false),
                    MaGiay = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MaHoaDonChiTiet = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiayChiTiet", x => x.MaGiayChiTiet);
                    table.ForeignKey(
                        name: "FK_GiayChiTiet_Giay_MaGiay",
                        column: x => x.MaGiay,
                        principalTable: "Giay",
                        principalColumn: "MaGiay",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiayChiTiet_HoaDonChiTiet_MaHoaDonChiTiet",
                        column: x => x.MaHoaDonChiTiet,
                        principalTable: "HoaDonChiTiet",
                        principalColumn: "MaHDCT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiet_MaGiay",
                table: "GiayChiTiet",
                column: "MaGiay");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiet_MaHoaDonChiTiet",
                table: "GiayChiTiet",
                column: "MaHoaDonChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKhachHang",
                table: "HoaDon",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaVoucher",
                table: "HoaDon",
                column: "MaVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaHoaDon",
                table: "HoaDonChiTiet",
                column: "MaHoaDon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiayChiTiet");

            migrationBuilder.DropTable(
                name: "Giay");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Voucher");
        }
    }
}
