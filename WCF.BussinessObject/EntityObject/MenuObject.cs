using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class MenuObject
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Guid ID { get; set; }

        [DisplayName("Tên hiện thị")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Display { get; set; }

        [DisplayName("Thứ tự hiện thị")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public Nullable<int> Rank { get; set; }

        [DisplayName("Neo")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Neo { get; set; }
    }
}
