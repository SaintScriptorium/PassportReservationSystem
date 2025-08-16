namespace Application.DTOs;

public class SlotDto
{
    public Guid Id { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset End { get; set; }
    public int Capacity {get; set;}
    public int ReservedCount { get; set; }
    public bool IsFull => ReservedCount >= Capacity;
}