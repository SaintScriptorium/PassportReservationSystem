namespace Application.DTOs;

public class CreateReservationDto
{
    public int UserId { get; set; }
    public int SlotId { get; set; }
    public int StationNumber { get; set; }
    public string Turno { get; set; }
    public DateTime ReservationDate { get; set; }
}
