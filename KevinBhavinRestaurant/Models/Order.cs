namespace KevinBhavinRestaurant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [ScaffoldColumn(false)]
        public int id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? datetime { get; set; }

        [ScaffoldColumn(false)]
        public string name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(256)]
        public string address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(40)]
        public string city { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(40)]
        public string state { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(256)]
        public string country { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [StringLength(6)]
        public string postalcode { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(256)]
        public string phone { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [StringLength(256)]
        public string email { get; set; }

        [Column(TypeName = "numeric")]
        [ScaffoldColumn(false)]
        public decimal total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
