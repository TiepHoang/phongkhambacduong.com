using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.BussinessObject.EntityObject
{
    public class SloganObject
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public System.Guid ID { get; set; }

        [DisplayName("#DichVu")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string DichVu { get; set; }

        [DisplayName("Phương châm Dịch vụ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Slogan_DichVu { get; set; }

        [DisplayName("#VeChungToi")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string VeChungToi { get; set; }

        [DisplayName("Phương châm")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Slogan_VeChungToi { get; set; }

        [DisplayName("#nameContent_VeChungToi")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string nameContent_VeChungToi { get; set; }

        [DisplayName("Nội dung giới thiệu Phòng khám")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Content_VeChungToi { get; set; }

        [DisplayName("Cơ sở vật chất")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string CSVC { get; set; }

        [DisplayName("Phương châm Cơ sở vật chất")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Slogan_CSVC { get; set; }

        [DisplayName("Bác sĩ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string BacSi { get; set; }

        [DisplayName("Phương châm Bác sĩ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Slogan_BacSi { get; set; }

        [DisplayName("Liên hệ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string LienHe { get; set; }

        [DisplayName("Phương châm Liên hệ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Slogan_Lienhe { get; set; }

        [DisplayName("Giới thiệu")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string GioiThieu { get; set; }

        [DisplayName("Ảnh Phòng khám")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string ImageGioiThieu { get; set; }

        [DisplayName("Ảnh trang chủ")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string ImagePage { get; set; }

        [DisplayName("Phương châm Page")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string SloganPage { get; set; }

        [DisplayName("Logo Page")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string LogoPage { get; set; }
    }
}
