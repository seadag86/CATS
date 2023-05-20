using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Organization : BaseEntity
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Acronym { get; set; }
    [Required]
    public int Tier { get; set; }
    [Required]
    public Organization? Parent { get; set; }
}