using Domain.Entities;
namespace Application.Interfaces.RepositoryInterfaces;

public interface ILoggingRepository
{
    Task<bool> VerifyUsuarioAsync(string email, string password);
    Task<Usuario> GetUsuarioAsync(bool verifieduser);
}