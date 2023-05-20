using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public abstract class BaseEntity
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public DateTimeOffset CreatedOn { get; set; }
    [Required]
    public string? CreatedBy { get; set; }
    [Required]
    public DateTimeOffset ModifiedOn { get; set; }
    [Required]
    public string? ModifiedBy { get; set; }
    public bool IsActive { get; set; } = true;
}