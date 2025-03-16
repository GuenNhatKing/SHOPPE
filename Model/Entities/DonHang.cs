using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shoppe.Model.Entities;

[Table("DonHang")]
public partial class DonHang
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string IdDonHang { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string IdLienHe { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string IdSanPham { get; set; } = null!;

    public int SoLuong { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DonGia { get; set; }

    public int TrangThai { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ThoiGianTao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ThoiGianGiao { get; set; }

    [ForeignKey("IdLienHe")]
    [InverseProperty("DonHangs")]
    public virtual ThongTinLienHe IdLienHeNavigation { get; set; } = null!;

    [ForeignKey("IdSanPham")]
    [InverseProperty("DonHangs")]
    public virtual SanPham IdSanPhamNavigation { get; set; } = null!;

    [InverseProperty("IdDonHangNavigation")]
    public virtual ICollection<ThanhToan> ThanhToans { get; set; } = new List<ThanhToan>();
}
