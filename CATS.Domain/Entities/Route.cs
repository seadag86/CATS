using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Route : BaseEntity
{
    [Required]
    public string? Title { get; set; }
    [Required]
    public RouteState State { get; set; } = RouteState.NotStarted;
    [Required]
    public RouteType Type { get; set; }
    public DateTimeOffset? StartedOn { get; set; }
    public DateTimeOffset? EndedOn { get; set; }
    public string? Instructions { get; set; }
    [Required]
    public Task? Task { get; set; }
    
    public ICollection<Assignment>? Assignments { get; set; }
}

public enum RouteType
{
    Serial,
    Parallel
}

public enum RouteState
{
    NotStarted,
    InProgress,
    Completed,
    OnHold,
    Stopped
}