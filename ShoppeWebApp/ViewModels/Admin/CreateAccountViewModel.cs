using System.ComponentModel.DataAnnotations;

namespace ShoppeWebApp.ViewModels.Admin
{
    public class CreateAccountViewModel
    {
        [Required(ErrorMessage = "Tên người dùng là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên người dùng không được vượt quá 100 ký tự.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên người dùng không được vượt quá 100 ký tự.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "CCCD là bắt buộc.")]
        [StringLength(12, MinimumLength = 9, ErrorMessage = "CCCD phải có từ 9 đến 12 ký tự.")]
        public string? Cccd { get; set; }

        [Required(ErrorMessage = "SĐT là bắt buộc.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "SĐT phải có từ 10 ký tự.")]
        public string? Sdt { get; set; }

        [StringLength(200, ErrorMessage = "Địa chỉ không được vượt quá 200 ký tự.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Vai trò là bắt buộc.")]
        public int Role { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Xác nhận mật khẩu là bắt buộc.")]
        [Compare("Password", ErrorMessage = "Mật khẩu và xác nhận mật khẩu không khớp.")]
        public string? ConfirmPassword { get; set; }
    }
}