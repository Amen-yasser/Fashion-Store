namespace MyFashionStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int product_id { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(10)]
        public string product_name { get; set; }
        [Required(ErrorMessage = "*")]
        public int price { get; set; }
        [Required(ErrorMessage = "*")]
        public int category_id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "*")]
        public string product_photo { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
