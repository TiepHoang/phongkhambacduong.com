using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class GopYObject
    {
        [DisplayName("ID")]
        public System.Guid ID { get; set; }

        [DisplayName("Thời gian")]
        public Nullable<System.DateTime> ThoiGian { get; set; }

        [DisplayName("Họ tên Người gửi")]
        public string HoTen { get; set; }


        [DisplayName("Số điện thoại")]
        public string DienThoai { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Nội dung")]
        public string NoiDung { get; set; }
    }
}
