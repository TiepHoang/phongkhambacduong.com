namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoSoVatChat")]
    public partial class CoSoVatChat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoSoVatChat()
        {
            CTCoSoVatChats = new HashSet<CTCoSoVatChat>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string GioiThieu { get; set; }

        [StringLength(50)]
        public string LinkImage { get; set; }

        public int? Index { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTCoSoVatChat> CTCoSoVatChats { get; set; }
    }
}
