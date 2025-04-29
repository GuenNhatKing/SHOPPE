using Microsoft.AspNetCore.Mvc;
using ShoppeWebApp.ViewModels.Admin;
using ShoppeWebApp.Data;
using System.Linq;

namespace ShoppeWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly ShoppeWebAppContext _context;

        public OrderController(ShoppeWebAppContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? searchQuery, int page = 1, int pageSize = 10)
        {
            var donHangs = _context.DonHangs.AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                donHangs = donHangs.Where(o => o.IdDonHang.Contains(searchQuery) || o.IdLienHe.Contains(searchQuery));
            }

            int totalDonHangs = donHangs.Count();
            var totalPages = (int)Math.Ceiling(totalDonHangs / (double)pageSize);
            var paginatedDonHangs = donHangs
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(o => new OrderViewModel
                {
                    IdDonHang = o.IdDonHang,
                    IdLienHe = o.IdLienHe,
                    ThoiGianTao = o.ThoiGianTao,
                    ThoiGianGiao = o.ThoiGianGiao,
                    TongTien = o.TongTien,
                    TrangThai = o.TrangThai
                })
                .ToList();

            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;

            return View(paginatedDonHangs);
        }

        // Action Chi tiết
        public IActionResult Details(string id)
        {
            var order = _context.DonHangs
                .Where(o => o.IdDonHang == id)
                .Select(o => new OrderViewModel
                {
                    IdDonHang = o.IdDonHang,
                    IdLienHe = o.IdLienHe,
                    ThoiGianTao = o.ThoiGianTao,
                    ThoiGianGiao = o.ThoiGianGiao,
                    TongTien = o.TongTien,
                    TrangThai = o.TrangThai
                })
                .FirstOrDefault();

            if (order == null)
            {
                TempData["ErrorMessage"] = "Không tìm thấy hóa đơn.";
                return RedirectToAction("Index");
            }

            return View(order);
        }

        [HttpGet]
        public IActionResult Cancel(string id)
        {
            var order = _context.DonHangs
                .Where(o => o.IdDonHang == id)
                .Select(o => new OrderViewModel
                {
                    IdDonHang = o.IdDonHang,
                    IdLienHe = o.IdLienHe,
                    ThoiGianTao = o.ThoiGianTao,
                    ThoiGianGiao = o.ThoiGianGiao,
                    TongTien = o.TongTien,
                    TrangThai = o.TrangThai
                })
                .FirstOrDefault();
        
            if (order == null)
            {
                TempData["ErrorMessage"] = "Không tìm thấy hóa đơn.";
                return RedirectToAction("Index");
            }
        
            return View(order);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CancelConfirmed(string id)
        {
            // Tìm đơn hàng theo ID
            var order = _context.DonHangs.FirstOrDefault(o => o.IdDonHang == id);
            if (order == null)
            {
                TempData["ErrorMessage"] = "Không tìm thấy hóa đơn.";
                return RedirectToAction("Index");
            }
        
            // Cập nhật trạng thái hóa đơn thành "Đã hủy"
            order.TrangThai = Constants.HUY_DON_HANG; // 0: Đã hủy
            try
            {
                _context.DonHangs.Update(order);
                _context.SaveChanges();
        
                TempData["SuccessMessage"] = "Hóa đơn đã được hủy thành công.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi hủy hóa đơn: " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}