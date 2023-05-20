using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Document : BaseEntity
{
    [Required]
    public string? NameWithExtension { get; set; }
    [Required]
    public string? Path { get; set; }
    [Required]
    public DocumentType Type { get; set; }
    [Required]
    public Task? Task { get; set; }
}

public enum DocumentType
{
    File,
    Link
}