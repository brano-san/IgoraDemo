using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IgoraDemo
{
    public partial class IgoraDB : DbContext
    {
        public IgoraDB()
            : base("name=IgoraDB")
        {
        }

        public virtual DbSet<clients_> clients_ { get; set; }
        public virtual DbSet<enter_type_> enter_type_ { get; set; }
        public virtual DbSet<orders_> orders_ { get; set; }
        public virtual DbSet<posts_> posts_ { get; set; }
        public virtual DbSet<services_> services_ { get; set; }
        public virtual DbSet<statuses_> statuses_ { get; set; }
        public virtual DbSet<worker_> worker_ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<statuses_>()
                .HasMany(e => e.orders_)
                .WithOptional(e => e.statuses_)
                .HasForeignKey(e => e.status_id);
        }
    }
}
