using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Group : BaseEntity
{
    [Required]
    public string? Name { get; set; }

    public ICollection<User>? Users { get; set; }
}