using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HandTools.ApplicationCore.Entities;

namespace HandTools.ApplicationCore.Entities;
public class Product : EntityBase
{

    [Required(ErrorMessage = "The Name field is required")]
    [Column(Order = 1, TypeName = "varchar(200)")]
    public string? Name { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? Description { get; set; }

    public string? Barcode { get; set; }

    [MaxLength(500)]
    public string? Link { get; set; }

    public decimal Price { get; set; }

    public decimal SaleOff { get; set; }

    public decimal Cost { get; set; }

    public string? Image { get; set; }
}