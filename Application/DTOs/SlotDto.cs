namespace Application.DTOs;

public class SlotDto
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public int Capacity {get; set;}
    public int ReservedCount { get; set; }
    
}