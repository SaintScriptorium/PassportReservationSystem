using System.ComponentModel.DataAnnotations;
using Domain.Enums;
namespace Domain.Entities;

public class Reservation
{
    
    [Key]
    public int Id { get; set; }

    [Required]
    public int SlotId { get; set; }

    [Required]
    public int UserId { get; set; }

    public int StationNumber { get; set; }
    
    [Required]
    public string Turno { get; set; }
    [Required]
    public ReservationStatus Status { get; set; } = ReservationStatus.Confirmed;

    [Required]
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
    
    [Required]
    public DateTime ReservationDate { get; set; }

}