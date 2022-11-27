using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandTools.ApplicationCore.Entities;

public abstract class EntityBase
{
    [Key]
    [Column(Order = 0)]
    public string Id { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}