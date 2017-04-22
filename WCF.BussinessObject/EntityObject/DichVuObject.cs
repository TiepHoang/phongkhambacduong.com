using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class DichVuObject
    {
        [Required(ErrorMessage = "Không được để rỗng")]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Không được để rỗng")]
        [DisplayName("Ảnh"),DataType(DataType.Upload)]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Không được để rỗng")]
        [DisplayName("Tên dịch vụ")]
        public string Name { get; set; }

        [DisplayName("Giới thiệu về dịch vụ")]
        [Required(ErrorMessage = "Không được để rỗng")]
        public string GioiThieu { get; set; }

        [Required(ErrorMessage = "Không được để rỗng")]
        [DisplayName("Link Ajax"),DataType(DataType.Url)]
        public string hrefAjax { get; set; }
    }
}
