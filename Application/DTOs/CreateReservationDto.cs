namespace Application.DTOs;

public class CreateReservationDto
{
    public Guid UserId { get; set; }
    public Guid SlotId { get; set; }
    public int StationNumber { get; set; }
    public string Turno { get; set; }
    public DateTime ReservationDate { get; set; }
}
