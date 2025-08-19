using Application.DTOs;
namespace Application.Interfaces.ServiceInterfaces;
public interface ILoggin
{
    Task<bool> VerifyUsuarioAsync(string email, string password);
    Task<UsuarioDto> GetUsuarioAsync(bool verifiedUser);

}