namespace IgoraDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("orders$")]
    public partial class orders_
    {
        [Key]
        public int id_order { get; set; }

        public int? order_number { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        public DateTime? create_time { get; set; }

        public DateTime? order_time { get; set; }

        public int? id_client { get; set; }

        public int? id_service { get; set; }

        public int? status_id { get; set; }

        public DateTime? close_date { get; set; }

        public int? session_minutes { get; set; }

        public virtual clients_ clients_ { get; set; }

        public virtual services_ services_ { get; set; }

        public virtual statuses_ statuses_ { get; set; }
    }
}
