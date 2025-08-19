using Application.DTOs;
namespace Application.Interfaces.ServiceInterfaces;
public interface ILoggin
{
    Task<bool> VerifyUsuario(string email, string password);
    Task<UsuarioDto> GetUsuario(bool verifiedUser);

}