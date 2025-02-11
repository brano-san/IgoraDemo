namespace IgoraDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("services$")]
    public partial class services_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public services_()
        {
            orders_ = new HashSet<orders_>();
        }

        [Key]
        public int id_service { get; set; }

        [StringLength(255)]
        public string service { get; set; }

        [StringLength(255)]
        public string code_service { get; set; }

        [StringLength(255)]
        public string available { get; set; }

        public double? cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders_> orders_ { get; set; }
    }
}
