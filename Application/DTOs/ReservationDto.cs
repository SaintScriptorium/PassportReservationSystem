namespace Application.DTOs;

public class ReservationDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid SlotId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string Status { get; set; }
    public int StationNumber { get; set; }
}
