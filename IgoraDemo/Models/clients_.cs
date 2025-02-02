namespace IgoraDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("clients$")]
    public partial class clients_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clients_()
        {
            orders_ = new HashSet<orders_>();
        }

        [Key]
        public int id_client { get; set; }

        [StringLength(255)]
        public string fio { get; set; }

        public double? code { get; set; }

        [StringLength(255)]
        public string pasport { get; set; }

        [Column(TypeName = "date")]
        public DateTime? born_date { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orders_> orders_ { get; set; }
    }
}
