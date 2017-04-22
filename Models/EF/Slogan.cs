namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slogan")]
    public partial class Slogan
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string itemName_DichVu { get; set; }

        public string ItemSlogan_DichVu { get; set; }

        [StringLength(50)]
        public string itemName_VeChungToi { get; set; }

        public string itemSlogan_VeChungToi { get; set; }

        [StringLength(50)]
        public string itemName_CSVC { get; set; }

        public string itemSlogan_CSVC { get; set; }

        [StringLength(50)]
        public string itemName_BacSi { get; set; }

        public string itemSlogan_BacSi { get; set; }

        [StringLength(50)]
        public string itemName_LienHe { get; set; }

        public string itemSlogan_Lienhe { get; set; }

        public string itemGioiThieu { get; set; }

        [StringLength(50)]
        public string ImageGioiThieu { get; set; }

        [StringLength(50)]
        public string ImagePage { get; set; }

        [StringLength(50)]
        public string SloganPage { get; set; }

        [StringLength(50)]
        public string LogoPage { get; set; }
    }
}
