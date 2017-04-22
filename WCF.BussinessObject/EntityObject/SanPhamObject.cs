using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WCF.BussinessObject.EntityObject
{
    public class SanPhamObject
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public System.Guid ID { get; set; }

        [DisplayName("Ảnh"),DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string LinkImage { get; set; }

        [DisplayName("Tên sản phẩm"),DataType(DataType.Text)]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Giá sản phẩm")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> GiaTien { get; set; }

        [DisplayName("Thứ tự hiện thị")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> Rank { get; set; }

        [DisplayName("Thông tin")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string ThongTin { get; set; }
    }
}
