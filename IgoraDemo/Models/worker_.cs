namespace IgoraDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("worker$")]
    public partial class worker_
    {
        [Key]
        public int id_worker { get; set; }

        public int? id_post { get; set; }

        [StringLength(255)]
        public string fio { get; set; }

        [StringLength(255)]
        public string login { get; set; }

        [StringLength(255)]
        public string pass { get; set; }

        [StringLength(255)]
        public string last_seen { get; set; }

        public int? id_type { get; set; }

        public virtual enter_type_ enter_type_ { get; set; }

        public virtual posts_ posts_ { get; set; }
    }
}
