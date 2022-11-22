using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    [Table("product_category")]
    public class ProductCategory
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "The Name field is required")]
        [Column(Order = 1, TypeName = "varchar(200)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? Description { get; set; }

        [MaxLength(500)]
        public string? Link { get; set; }

        public string? Image { get; set; }
    }
}