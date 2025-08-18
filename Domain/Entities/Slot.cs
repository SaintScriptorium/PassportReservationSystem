using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Slot
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public DateTime Start { get; set; }
    [Required]
    public DateTime End { get; set; }
    [Required]
    public int Capacity { get; set; }
    [Required]
    public int ReservedCount { get; set; } = 0;
    [Timestamp]
    public byte[] RowVersion { get; set; }
    
    
    [NotMapped]
    public bool IsFull => ReservedCount >= Capacity;
}