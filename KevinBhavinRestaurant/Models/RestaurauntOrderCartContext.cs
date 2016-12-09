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
    }
}
