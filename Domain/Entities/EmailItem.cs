using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class EmailItem
{
    [Key]
    public int Id { get; set; }
    public int? ReservationId { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool Sent { get; set; } = false;
    public DateTimeOffset SentAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
}