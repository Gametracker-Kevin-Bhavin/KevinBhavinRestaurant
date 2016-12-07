namespace KevinBhavinRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MenuItem")]
        public int MenuId { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        [Required]
        [StringLength(50)]
        public string sessionid { get; set; }

        public virtual MenuItem MenuItem { get; set; }
    }
}
