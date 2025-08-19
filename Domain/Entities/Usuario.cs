using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Usuario
{
    [Key]
    public int Id { get; set; }
    [Required,EmailAddress,MaxLength(100)]
    public string Email { get; set; }
    [Required,MinLength(8)]
    public string Password { get; set; }
    [Required,StringLength(11, MinimumLength = 11)]
    public string Cedula { get; set; }
    [Required, MaxLength(50)]
    public string Nombre { get; set; }
    [Required, MaxLength(50)]
    public string Apellido { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
}