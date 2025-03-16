using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Shoppe.Model.Entities;

namespace Shoppe.Model.EFStructures;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CuaHang> CuaHangs { get; set; }

    public virtual DbSet<DanhGia> DanhGia { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ThanhToan> ThanhToans { get; set; }

    public virtual DbSet<ThongTinLienHe> ThongTinLienHes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CuaHang>(entity =>
        {
            entity.HasOne(d => d.IdNguoiDungNavigation).WithMany(p => p.CuaHangs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuaHang_NguoiDung");
        });

        modelBuilder.Entity<DanhGia>(entity =>
        {
            entity.HasOne(d => d.IdNguoiDungNavigation).WithMany(p => p.DanhGia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DanhGia_NguoiDung");

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.DanhGia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DanhGia_SanPham");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasOne(d => d.IdLienHeNavigation).WithMany(p => p.DonHangs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DonHang_ThongTinLienHe");

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.DonHangs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DonHang_SanPham");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasOne(d => d.IdCuaHangNavigation).WithMany(p => p.SanPhams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SanPham_CuaHang");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasOne(d => d.IdNguoiDungNavigation).WithOne(p => p.TaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaiKhoan_NguoiDung");
        });

        modelBuilder.Entity<ThanhToan>(entity =>
        {
            entity.HasOne(d => d.IdDonHangNavigation).WithMany(p => p.ThanhToans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThanhToan_DonHang");
        });

        modelBuilder.Entity<ThongTinLienHe>(entity =>
        {
            entity.HasOne(d => d.IdNguoiDungNavigation).WithMany(p => p.ThongTinLienHes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThongTinLienHe_NguoiDung");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
