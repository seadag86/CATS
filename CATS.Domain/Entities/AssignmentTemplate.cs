using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class AssignmentTemplate : BaseEntity
{
    [Required]
    public User? Assignee { get; set; }
    [Required]
    public AssignmentType? Type { get; set; }
    [Required]
    public int Order { get; set; }
    public string? Instructions { get; set; }
    public DateTimeOffset? DueDate { get; set; }
}