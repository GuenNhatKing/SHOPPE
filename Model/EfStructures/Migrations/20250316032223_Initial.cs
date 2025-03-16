using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.EfStructures.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    IdNguoiDung = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CCCD = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    VaiTro = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime", nullable: true),
                    ThoiGianXoa = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.IdNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    IdCuaHang = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdNguoiDung = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenCuaHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UrlAnh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ThoiGianXoa = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.IdCuaHang);
                    table.ForeignKey(
                        name: "FK_CuaHang_NguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung");
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    IdNguoiDung = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Username = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.IdNguoiDung);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinLienHe",
                columns: table => new
                {
                    IdLienHe = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdNguoiDung = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinLienHe", x => x.IdLienHe);
                    table.ForeignKey(
                        name: "FK_ThongTinLienHe_NguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    IdSanPham = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdDanhMuc = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdCuaHang = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UrlAnh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SoLuongKho = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GiaGoc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongDIemGiaBan = table.Column<int>(type: "int", nullable: false),
                    SoLuongDanhGia = table.Column<int>(type: "int", nullable: false),
                    SoLuongBan = table.Column<int>(type: "int", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ThoiGianXoa = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.IdSanPham);
                    table.ForeignKey(
                        name: "FK_SanPham_CuaHang",
                        column: x => x.IdCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "IdCuaHang");
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    IdDanhGia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdNguoiDung = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdSanPham = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DiemDanhGia = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ThoiGianDG = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.IdDanhGia);
                    table.ForeignKey(
                        name: "FK_DanhGia_NguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung");
                    table.ForeignKey(
                        name: "FK_DanhGia_SanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "IdSanPham");
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    IdDonHang = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdLienHe = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdSanPham = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ThoiGianGiao = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.IdDonHang);
                    table.ForeignKey(
                        name: "FK_DonHang_SanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "IdSanPham");
                    table.ForeignKey(
                        name: "FK_DonHang_ThongTinLienHe",
                        column: x => x.IdLienHe,
                        principalTable: "ThongTinLienHe",
                        principalColumn: "IdLienHe");
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    IdThanhToan = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    IdDonHang = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoaiThanhToan = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.IdThanhToan);
                    table.ForeignKey(
                        name: "FK_ThanhToan_DonHang",
                        column: x => x.IdDonHang,
                        principalTable: "DonHang",
                        principalColumn: "IdDonHang");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuaHang_IdNguoiDung",
                table: "CuaHang",
                column: "IdNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_IdNguoiDung",
                table: "DanhGia",
                column: "IdNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_IdSanPham",
                table: "DanhGia",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_IdLienHe",
                table: "DonHang",
                column: "IdLienHe");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_IdSanPham",
                table: "DonHang",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdCuaHang",
                table: "SanPham",
                column: "IdCuaHang");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_IdDonHang",
                table: "ThanhToan",
                column: "IdDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinLienHe_IdNguoiDung",
                table: "ThongTinLienHe",
                column: "IdNguoiDung");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "ThongTinLienHe");

            migrationBuilder.DropTable(
                name: "CuaHang");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
