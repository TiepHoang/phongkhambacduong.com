using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class DiaChiObject
    {
        [Required(ErrorMessage= "Không được để rỗng")]
        public Guid ID { get; set; }

        [DisplayName("Số điện thoại"),DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage= "Không được để rỗng")]
        public string Mobile { get; set; }

        [Required(ErrorMessage= "Không được để rỗng")]
        [DisplayName("Địa chỉ"),DataType(DataType.MultilineText)]
        public string Adress { get; set; }

        [Required(ErrorMessage= "Không được để rỗng")]
        public string Hotline { get; set; }
       
    }
}
