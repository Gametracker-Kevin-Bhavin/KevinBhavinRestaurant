namespace KevinBhavinRestaurant
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuItem")]
    public partial class MenuItem
    {
        public int id { get; set; }

        [StringLength(15)]
        public string type { get; set; }

        [StringLength(256)]
        public string name { get; set; }

        [StringLength(256)]
        public string smallPhoto { get; set; }

        [StringLength(256)]
        public string largePhoto { get; set; }

        [StringLength(256)]
        public string shortDescription { get; set; }

        [StringLength(256)]
        public string longDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal price { get; set; }
    }
}
