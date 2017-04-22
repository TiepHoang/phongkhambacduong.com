using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    [DisplayName("Phòng ban")]
    public class PhongBanObject
    {
        [Required(ErrorMessage = "Không được bỏ trống")]
        public System.Guid ID { get; set; }

        [DisplayName("Tên phòng ban")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Miêu tả về phòng ban")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string MoTa { get; set; }
    }
}
