using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Message : BaseEntity
{
    [Required]
    public string? Subject { get; set; }
    [Required]
    public string? Body { get; set; }
    public Assignment? Assignment { get; set; }
    [Required]
    public Task? Task { get; set; }
}