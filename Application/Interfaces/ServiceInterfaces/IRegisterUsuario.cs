using Application.DTOs;
namespace Application.Interfaces.ServiceInterfaces;
public interface IRegisterUsuario
{
    Task<string> PostUsuario(RegisterUsuarioDto registerUsuario);
}