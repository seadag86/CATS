using System.ComponentModel.DataAnnotations;

namespace CATS.Domain.Entities;

public class Favorite : BaseEntity
{
    [Required]
    public string? Title { get; set; }
    [Required]
    public FavoriteType Type { get; set; }
    public Task? Task { get; set; }
}

public enum FavoriteType
{
    Search,
    Tasks
}