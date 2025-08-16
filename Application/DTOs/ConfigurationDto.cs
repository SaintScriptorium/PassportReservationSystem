namespace Application.DTOs;

public class ConfigurationDto
{
    public DateTime date { get; set; }
    public string Turno { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int SlotDuration { get; set; }
    public int Stations { get; set; }
}