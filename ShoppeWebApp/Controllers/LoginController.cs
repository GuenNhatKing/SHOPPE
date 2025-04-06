﻿using Microsoft.AspNetCore.Mvc;
using ShoppeWebApp.Models.Login;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoppeWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<LoginController> _logger;

        public LoginController(ApplicationDbContext context, ILogger<LoginController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/Login/UserLogin.cshtml");
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var account = _context.Accounts
                    .FirstOrDefault(a => a.Username == model.Username && a.Password == model.Password);

                if (account != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Nhập sai mật khẩu hoặc tài khoản.");
                }
            }

            return View("~/Views/Login/UserLogin.cshtml", model);
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View("~/Views/ForgotPassword/ForgotPassword.cshtml");
        }

        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var account = _context.Accounts
                        .FirstOrDefault(a => a.Username == model.Username && a.IdNguoiDungNavigation.Sdt == model.PhoneNumber);

                    if (account != null)
                    {
                        // Redirect to Reset Password page
                        return RedirectToAction("ResetPassword", new { username = model.Username });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Tên đăng nhập hoặc số điện thoại không đúng.");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while resetting the password.");
                    ModelState.AddModelError(string.Empty, "Đã xảy ra lỗi khi đặt lại mật khẩu.");
                }
            }

            return View("~/Views/ForgotPassword/ForgotPassword.cshtml", model);
        }

        [HttpGet]
        public IActionResult ResetPassword(string username)
        {
            var model = new ResetPasswordViewModel { Username = username };
            return View("~/Views/ForgotPassword/ResetPassword.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Check if the new password and confirm password fields match
                if (model.NewPassword == model.ConfirmPassword)
                {
                    var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Username == model.Username);
                    if (account != null)
                    {
                        _logger.LogInformation("Account found for user: {Username}", model.Username);
                        account.Password = model.NewPassword;
                        try
                        {
                            _context.Accounts.Update(account); // Ensure the account is marked as modified
                            await _context.SaveChangesAsync();
                            _logger.LogInformation("Password updated successfully for user: {Username}", model.Username);
                            ViewBag.Message = "Mật khẩu đã được đặt lại thành công.";
                            return RedirectToAction("Index", "Login");
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, "An error occurred while saving the new password for user: {Username}", model.Username);
                            ModelState.AddModelError(string.Empty, "Đã xảy ra lỗi khi lưu mật khẩu mới.");
                        }
                    }
                    else
                    {
                        _logger.LogWarning("Account not found for user: {Username}", model.Username);
                        ModelState.AddModelError(string.Empty, "Tài khoản không tồn tại.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Mật khẩu và xác nhận mật khẩu không khớp.");
                }
            }
            else
            {
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        _logger.LogWarning("ModelState error in {Key}: {ErrorMessage}", state.Key, error.ErrorMessage);
                    }
                }
            }

            return View("~/Views/ForgotPassword/ResetPassword.cshtml", model);
        }

    }
}
