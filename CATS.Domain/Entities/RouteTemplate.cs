using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class RouteTemplate : BaseEntity
{
    [Required]
    public string? Title { get; set; }
    [Required]
    public RouteType Type { get; set; }
    public string? Instructions { get; set; }
    
    public ICollection<Assignment>? Assignments { get; set; }
}