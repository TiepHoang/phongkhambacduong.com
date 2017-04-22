using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class CTCoSoVatChatObject
    {
        [Required(ErrorMessage = "Không được để rỗng")]
        public System.Guid ID { get; set; }

        [DisplayName("ID Cơ sở vật chất"), Required(ErrorMessage = "Không được để rỗng")]
        public Nullable<System.Guid> ID_CoSoVatChat { get; set; }

        [DisplayName("Ảnh"), Required(ErrorMessage = "Không được để rỗng")]
        public string LinkImage { get; set; }

        [DisplayName("Nội dung"), Required(ErrorMessage = "Không được để rỗng")]
        public string NoiDung { get; set; }
    }
}
