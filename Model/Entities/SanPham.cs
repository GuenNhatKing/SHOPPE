using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shoppe.Model.Entities;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string IdSanPham { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string IdDanhMuc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string IdCuaHang { get; set; } = null!;

    [StringLength(100)]
    public string TenSanPham { get; set; } = null!;

    [StringLength(100)]
    public string UrlAnh { get; set; } = null!;

    [StringLength(1000)]
    public string? MoTa { get; set; }

    public int SoLuongKho { get; set; }

    public int TrangThai { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal GiaGoc { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal GiaBan { get; set; }

    [Column("TongDIemGiaBan")]
    public int TongDiemGiaBan { get; set; }

    public int SoLuongDanhGia { get; set; }

    public int SoLuongBan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ThoiGianTao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianXoa { get; set; }

    [InverseProperty("IdSanPhamNavigation")]
    public virtual ICollection<DanhGia> DanhGia { get; set; } = new List<DanhGia>();

    [InverseProperty("IdSanPhamNavigation")]
    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    [ForeignKey("IdCuaHang")]
    [InverseProperty("SanPhams")]
    public virtual CuaHang IdCuaHangNavigation { get; set; } = null!;
}
