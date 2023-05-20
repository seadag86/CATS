using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Assignment : BaseEntity
{
    [Required] 
    public User? Assignee { get; set; }
    [Required]
    public AssignmentState State { get; set; } = AssignmentState.NotStarted;
    [Required]
    public AssignmentType? Type { get; set; }
    [Required]
    public int Order { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    public DateTimeOffset? StartedOn { get; set; }
    public DateTimeOffset? EndedOn { get; set; }
    public string? Instructions { get; set; }
    [Required]
    public Route? Route { get; set; }
    [Required]
    public Task? Task { get; set; }
    
    public ICollection<Message>? Messages { get; set; }
}

public enum AssignmentType
{
    Informational,
    Response,
    Concur,
    Approval
}

public enum AssignmentState
{
    NotStarted,
    Unread,
    Pending,
    Read,
    Completed,
    Concurred,
    Approved,
    CorrectionNeeded,
    NonConcurred,
    NotApproved,
    Stopped
}