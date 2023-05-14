using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace tuningAtelier.ENT
{
    public partial class BatteriesEntities : DbContext
    {
        public BatteriesEntities()
            : base(nameOrConnectionString: "Data Source=DESKTOP-EF7BU2C;Initial Catalog=Batteries;Integrated Security=True")
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
                .WithRequired(e => e.userGenders)
                .HasForeignKey(e => e.gender)
                .WillCascadeOnDelete(false);

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
