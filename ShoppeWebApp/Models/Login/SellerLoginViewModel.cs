﻿using System.ComponentModel.DataAnnotations;

namespace ShoppeWebApp.Models.Login
{
    public class SellerLoginViewModel
    {
        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }


    //public class ForgotPasswordModel
    //{
    //}
    //Reuse lai LoginViewModel
}
