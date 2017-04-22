using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class CoSoVatChatObject
    {
        public Guid ID { get; set; }

        [DisplayName("Giới thiệu"), Required(ErrorMessage = " Không được để rỗng ")]
        public string GioiThieu { get; set; }

        [DisplayName("Ảnh"), Required(ErrorMessage = " Không được để rỗng ")]
        public string LinkImage { get; set; }

        [DisplayName("Thứ tự hiện thị"), Required(ErrorMessage = " Không được để rỗng ")]
        public Nullable<int> Index { get; set; }

        [DisplayName("Link ajax"), Required(ErrorMessage = " Không được để rỗng ")]
        public string hrefAjax { get; set; }
    }
}
