namespace KevinBhavinRestaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurauntOrderCartContext : DbContext
    {
        public RestaurauntOrderCartContext()
            : base("name=RestaurauntOrderCartContext")
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.smallPhoto)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.largePhoto)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.shortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MenuItem>()
                .Property(e => e.longDescription)
                .IsUnicode(false);
        }
    }
}
