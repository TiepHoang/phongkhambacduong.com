using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{

    [DisplayName("Tài khoản")]
    public class AccountObject
    {
        [DisplayName("Tên đăng nhập"), Required(ErrorMessage = "Không được bỏ trống")]
        public string Username { get; set; }

        [DisplayName("Mật khẩu"), Required(ErrorMessage = "Không được bỏ trống")]
        public string Password { get; set; }

        [DisplayName("Email liên hệ"), Required(ErrorMessage = "Không được bỏ trống")]
        public string Email { get; set; }

        [DisplayName("Giới tính"), Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<bool> Sex { get; set; }

        [DisplayName("Họ tên người dùng"), Required(ErrorMessage = "Không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Ngày sinh"), Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<System.DateTime> Birthday { get; set; }

        [DisplayName("Địa chỉ"), Required(ErrorMessage = "Không được bỏ trống")]
        public string Adress { get; set; }

        [DisplayName("Số điện thoại"), Required(ErrorMessage = "Không được bỏ trống")]
        public string Phone { get; set; }

        [DisplayName("Phân quyền"), Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<System.Guid> ID_Position { get; set; }

        [DisplayName("Ảnh đại diện"), Required(ErrorMessage = "Không được bỏ trống")]
        public string Avatar { get; set; }
    }
}
