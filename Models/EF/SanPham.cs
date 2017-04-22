namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string LinkImage { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? GiaTien { get; set; }

        public int? Rank { get; set; }

        public string ThongTin { get; set; }
    }
}
