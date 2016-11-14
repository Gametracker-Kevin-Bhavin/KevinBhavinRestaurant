namespace KevinBhavinRestaurant
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantConnection")
        {
        }

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
