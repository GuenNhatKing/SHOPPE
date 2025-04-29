using System.ComponentModel.DataAnnotations;

namespace ShoppeWebApp.ViewModels.Admin
{
    public class OrderViewModel
    {
        public string IdDonHang { get; set; }
        public string IdLienHe { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime? ThoiGianGiao { get; set; }
        public int TongTien { get; set; }
        public int TrangThai { get; set; }
    }
}