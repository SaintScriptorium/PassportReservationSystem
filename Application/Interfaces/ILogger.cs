namespace Application.Interfaces;

public interface ILogger
{
    Task<Guid> GetUsuario(string email, string password);
}