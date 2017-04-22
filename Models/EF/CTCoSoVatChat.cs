namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTCoSoVatChat")]
    public partial class CTCoSoVatChat
    {
        public int ID { get; set; }

        public int? ID_CoSoVatChat { get; set; }

        [StringLength(50)]
        public string LinkImage { get; set; }

        public string NoiDung { get; set; }

        public virtual CoSoVatChat CoSoVatChat { get; set; }
    }
}
