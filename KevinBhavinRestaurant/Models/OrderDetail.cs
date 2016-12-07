namespace KevinBhavinRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int MenuId { get; set; }

        public int Quantity { get; set; }

        public float? UnitPrice { get; set; }

        public virtual MenuItem MenuItem { get; set; }

        public virtual Order Order { get; set; }
    }
}