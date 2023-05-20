using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Delegate : BaseEntity
{
    [Required]
    public User? Delegatee { get; set; }
}