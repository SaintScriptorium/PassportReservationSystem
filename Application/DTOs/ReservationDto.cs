namespace Application.DTOs;

public class ReservationDto
{
    public int Id { get; set; }
    public int SlotId { get; set; }
    public string NombreCompleto { get; set; }
    public int StationNumber { get; set; }
    public DateTime ReservationDate { get; set; }
    public string Turno { get; set; }
    public string Status { get; set; }
}