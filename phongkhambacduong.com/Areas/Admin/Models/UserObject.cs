using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace phongkhambacduong.com.Areas.Admin.Models
{
    public class UserObject
    {
        [DisplayName("Tên đăng nhập"),Required(ErrorMessage="Nhập tên đăng nhập")]
        public string Username { get; set; }

        [DisplayName("Mật khẩu"),Required(ErrorMessage="Nhập mật khẩu")]
        public string Password { get; set; }

        [DisplayName("Nhớ tài khoản")]
        public bool Remember { get; set; }
    }
}