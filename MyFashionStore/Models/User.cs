namespace MyFashionStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int user_id { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage ="*")]
        public string username { get; set; }

        [StringLength(50)]
        [RegularExpression(@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}",ErrorMessage ="Invalid E-mail")]
        [Required(ErrorMessage = "*")]
        public string email { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "*")]
        public string address { get; set; }
        [Required(ErrorMessage = "*")]
        public int? password { get; set; }
        [NotMapped]
        [Compare("password",ErrorMessage ="password not match")]
        [Display(Name ="Confirm Password")]
        [Required(ErrorMessage = "*")]
        public int? confirm_password { get; set; }
        [Required(ErrorMessage = "*")]
        public int? phonenumber { get; set; }

        [StringLength(50)]
        [Display(Name ="Photo")]
        [Required(ErrorMessage = "*")]
        public string user_photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
