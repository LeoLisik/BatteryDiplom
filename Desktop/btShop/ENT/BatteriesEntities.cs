using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace tuningAtelier.ENT
{
    public partial class BatteriesEntities : DbContext
    {
        public BatteriesEntities()
            : base("name=BatteryDB")
        {
        }

        public virtual DbSet<batteriesBucket> batteriesBucket { get; set; }
        public virtual DbSet<menu> menu { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<statusOrder> statusOrder { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<userGenders> userGenders { get; set; }
        public virtual DbSet<userRoles> userRoles { get; set; }
        public virtual DbSet<userStatus> userStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<menu>()
                .HasMany(e => e.batteriesBucket)
                .WithRequired(e => e.menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.batteriesBucket)
                .WithRequired(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<statusOrder>()
                .HasMany(e => e.order)
                .WithRequired(e => e.statusOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.order)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<userGenders>()
                .HasMany(e => e.user)
                .WithOptional(e => e.userGenders)
                .HasForeignKey(e => e.gender);

            modelBuilder.Entity<userRoles>()
                .HasMany(e => e.user)
                .WithRequired(e => e.userRoles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<userStatus>()
                .HasMany(e => e.user)
                .WithRequired(e => e.userStatus)
                .WillCascadeOnDelete(false);
        }
    }
}
