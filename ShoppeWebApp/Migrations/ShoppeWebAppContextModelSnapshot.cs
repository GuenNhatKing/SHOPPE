﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppeWebApp.Data;

#nullable disable

namespace ShoppeWebApp.Migrations
{
    [DbContext(typeof(ShoppeWebAppContext))]
    partial class ShoppeWebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShoppeWebApp.Models.ChiTietDonHang", b =>
                {
                    b.Property<string>("IdDonHang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdSanPham")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdDonHang", "IdSanPham");

                    b.HasIndex("IdSanPham");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.CuaHang", b =>
                {
                    b.Property<string>("IdCuaHang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IdNguoiDung")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenCuaHang")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ThoiGianTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ThoiGianXoa")
                        .HasColumnType("datetime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("UrlAnh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdCuaHang");

                    b.HasIndex("IdNguoiDung");

                    b.ToTable("CuaHang");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.DanhGium", b =>
                {
                    b.Property<string>("IdDanhGia")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("DiemDanhGia")
                        .HasColumnType("int");

                    b.Property<string>("IdNguoiDung")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdSanPham")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NoiDung")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("ThoiGianDg")
                        .HasColumnType("datetime")
                        .HasColumnName("ThoiGianDG");

                    b.HasKey("IdDanhGia");

                    b.HasIndex("IdNguoiDung");

                    b.HasIndex("IdSanPham");

                    b.ToTable("DanhGia");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.DanhMuc", b =>
                {
                    b.Property<string>("IdDanhMuc")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdDanhMuc");

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.DonHang", b =>
                {
                    b.Property<string>("IdDonHang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdLienHe")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("ThoiGianGiao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ThoiGianTao")
                        .HasColumnType("datetime");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdDonHang");

                    b.HasIndex("IdLienHe");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.GioHang", b =>
                {
                    b.Property<string>("IdNguoiDung")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdSanPham")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasIndex("IdNguoiDung");

                    b.HasIndex("IdSanPham");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.NguoiDung", b =>
                {
                    b.Property<string>("IdNguoiDung")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cccd")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HoVaTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SDT");

                    b.Property<DateTime?>("ThoiGianTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ThoiGianXoa")
                        .HasColumnType("datetime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<int>("VaiTro")
                        .HasColumnType("int");

                    b.HasKey("IdNguoiDung");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.SanPham", b =>
                {
                    b.Property<string>("IdSanPham")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("GiaGoc")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("IdCuaHang")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdDanhMuc")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("SoLuongBan")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongKho")
                        .HasColumnType("int");

                    b.Property<int>("SoLuotDg")
                        .HasColumnType("int")
                        .HasColumnName("SoLuotDG");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ThoiGianTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ThoiGianXoa")
                        .HasColumnType("datetime");

                    b.Property<int>("TongDiemDg")
                        .HasColumnType("int")
                        .HasColumnName("TongDiemDG");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("UrlAnh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdSanPham");

                    b.HasIndex("IdCuaHang");

                    b.HasIndex("IdDanhMuc");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.TaiKhoan", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("IdNguoiDung")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Username");

                    b.HasIndex("IdNguoiDung");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.ThanhToan", b =>
                {
                    b.Property<string>("IdThanhToan")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdDonHang")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("LoaiThanhToan")
                        .HasColumnType("int");

                    b.Property<decimal>("SoTien")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("ThoiGianTao")
                        .HasColumnType("datetime");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdThanhToan");

                    b.HasIndex("IdDonHang");

                    b.ToTable("ThanhToan");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.ThongTinLienHe", b =>
                {
                    b.Property<string>("IdLienHe")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("HoVaTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdNguoiDung")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SDT");

                    b.HasKey("IdLienHe");

                    b.HasIndex("IdNguoiDung");

                    b.ToTable("ThongTinLienHe");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.DonHang", "IdDonHangNavigation")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("IdDonHang")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietDonHang_DonHang");

                    b.HasOne("ShoppeWebApp.Models.SanPham", "IdSanPhamNavigation")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("IdSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietDonHang_SanPham");

                    b.Navigation("IdDonHangNavigation");

                    b.Navigation("IdSanPhamNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.CuaHang", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.NguoiDung", "IdNguoiDungNavigation")
                        .WithMany("CuaHangs")
                        .HasForeignKey("IdNguoiDung")
                        .IsRequired()
                        .HasConstraintName("FK_CuaHang_NguoiDung");

                    b.Navigation("IdNguoiDungNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.DanhGium", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.NguoiDung", "IdNguoiDungNavigation")
                        .WithMany("DanhGia")
                        .HasForeignKey("IdNguoiDung")
                        .IsRequired()
                        .HasConstraintName("FK_DanhGia_NguoiDung");

                    b.HasOne("ShoppeWebApp.Models.SanPham", "IdSanPhamNavigation")
                        .WithMany("DanhGia")
                        .HasForeignKey("IdSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_DanhGia_SanPham");

                    b.Navigation("IdNguoiDungNavigation");

                    b.Navigation("IdSanPhamNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.DonHang", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.ThongTinLienHe", "IdLienHeNavigation")
                        .WithMany("DonHangs")
                        .HasForeignKey("IdLienHe")
                        .IsRequired()
                        .HasConstraintName("FK_DonHang_ThongTinLienHe");

                    b.Navigation("IdLienHeNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.GioHang", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.NguoiDung", "IdNguoiDungNavigation")
                        .WithMany()
                        .HasForeignKey("IdNguoiDung")
                        .IsRequired()
                        .HasConstraintName("FK_GioHang_NguoiDung");

                    b.HasOne("ShoppeWebApp.Models.SanPham", "IdSanPhamNavigation")
                        .WithMany()
                        .HasForeignKey("IdSanPham")
                        .IsRequired()
                        .HasConstraintName("FK_GioHang_SanPham");

                    b.Navigation("IdNguoiDungNavigation");

                    b.Navigation("IdSanPhamNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.SanPham", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.CuaHang", "IdCuaHangNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("IdCuaHang")
                        .IsRequired()
                        .HasConstraintName("FK_SanPham_CuaHang");

                    b.HasOne("ShoppeWebApp.Models.DanhMuc", "IdDanhMucNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("IdDanhMuc")
                        .IsRequired()
                        .HasConstraintName("FK_SanPham_DanhMuc");

                    b.Navigation("IdCuaHangNavigation");

                    b.Navigation("IdDanhMucNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.TaiKhoan", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.NguoiDung", "IdNguoiDungNavigation")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("IdNguoiDung")
                        .IsRequired()
                        .HasConstraintName("FK_TaiKhoan_NguoiDung");

                    b.Navigation("IdNguoiDungNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.ThanhToan", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.DonHang", "IdDonHangNavigation")
                        .WithMany("ThanhToans")
                        .HasForeignKey("IdDonHang")
                        .IsRequired()
                        .HasConstraintName("FK_ThanhToan_DonHang");

                    b.Navigation("IdDonHangNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.ThongTinLienHe", b =>
                {
                    b.HasOne("ShoppeWebApp.Models.NguoiDung", "IdNguoiDungNavigation")
                        .WithMany("ThongTinLienHes")
                        .HasForeignKey("IdNguoiDung")
                        .IsRequired()
                        .HasConstraintName("FK_ThongTinLienHe_NguoiDung");

                    b.Navigation("IdNguoiDungNavigation");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.CuaHang", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.DanhMuc", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.DonHang", b =>
                {
                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("ThanhToans");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.NguoiDung", b =>
                {
                    b.Navigation("CuaHangs");

                    b.Navigation("DanhGia");

                    b.Navigation("TaiKhoans");

                    b.Navigation("ThongTinLienHes");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("DanhGia");
                });

            modelBuilder.Entity("ShoppeWebApp.Models.ThongTinLienHe", b =>
                {
                    b.Navigation("DonHangs");
                });
#pragma warning restore 612, 618
        }
    }
}
