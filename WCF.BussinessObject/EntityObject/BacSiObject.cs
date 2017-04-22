using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class BacSiObject
    {
        [DisplayName("ID"), Required(ErrorMessage = "Không đễ rỗng")]
        public System.Guid ID { get; set; }

        [DisplayName("Tên bác sĩ"), Required(ErrorMessage = "Không đễ rỗng")]
        public string Name { get; set; }

        [DisplayName("Chức vụ")]
        [Required(ErrorMessage = "Không đễ rỗng")]
        public Nullable<Guid> ID_PhongBan { get; set; }

        [DisplayName("Ảnh"), Required(ErrorMessage = "Không để trống")]
        public string LinkImage { get; set; }
    }
}
