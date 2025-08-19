using System.ComponentModel.DataAnnotations;
using Domain.Enums;
namespace Domain.Entities;

public class Configuration
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public Turno Turno { get; set; }
    [Required]
    public TimeSpan StartTime { get; set; }
    [Required]
    public TimeSpan EndTime { get; set; }
    [Required]
    public int SlotDuration { get; set; }
    [Required]
    public int Stations { get; set; }
}