using Application.DTOs;
namespace Application.Interfaces.ServiceInterfaces;
public interface IRegisterUsuario
{
    Task<String> PostUsuario(RegisterUsuarioDto registerUsuario);
    Task<UsuarioDto> GetUsuario(bool verifiedUser);
}