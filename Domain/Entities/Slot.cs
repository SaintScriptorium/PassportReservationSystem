using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Slot
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public DateTimeOffset Start { get; set; }
    [Required]
    public DateTimeOffset End { get; set; }
    [Required]
    public int Capacity { get; set; }
    [Required]
    public int ReservedCount { get; set; } = 0;
    [Timestamp]
    public byte[] RowVersion { get; set; }
}