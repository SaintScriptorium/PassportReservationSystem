using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class LogEntry
{
    [Key]
    public int Id { get; set; }
    public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.Now;
    public string Level { get; set; }
    public string Message { get; set; }
    public string Context { get; set; }
}