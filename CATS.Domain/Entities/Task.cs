using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Task : BaseEntity
{
    [Required]
    public string? Number { get; set; }
    [Required]
    public string? Subject { get; set; }
    [Required]
    public Organization? Tier1Org { get; set; }
    [Required]
    public Organization? Tier2Org { get; set; }
    public Organization? Tier3Org { get; set; }
    public TaskState State { get; set; } = TaskState.Draft;
    public TaskPriority Priority { get; set; } = TaskPriority.NA;
    public Group? Group { get; set; }
    [Required]
    public bool? ContainsCui { get; set; }
    public string? Source { get; set; }
    public string? Response { get; set; }
    public DateTimeOffset? CorrespondenceDate { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    public DateTimeOffset? CompletedOn { get; set; }
    public DateTimeOffset? ClosedOn { get; set; }
    public string? Instructions { get; set; }
    
    public ICollection<Document>? Documents { get; set; }
    public ICollection<Route>? Routes { get; set; }
    public ICollection<Message>? Messages { get; set; }
}

public enum TaskState
{
    Draft,
    InProgress,
    PendingClosure,
    Closed
}

public enum TaskPriority
{
    Critical,
    High,
    Medium,
    Low,
    NA
}