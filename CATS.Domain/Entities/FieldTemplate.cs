using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class FieldTemplate : BaseEntity
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Value { get; set; }
    [Required]
    public FieldType Field { get; set; }
    [Required]
    public FormType Form { get; set; }
}

public enum FieldType
{
    Source,
    Response,
    Instructions
}

public enum FormType
{
    Task,
    Route,
    Assignee
}