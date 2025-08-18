using Application.DTOs;
namespace Application.Interfaces;

public interface IRegisterUsuario
{
    Task<String> PostUsuario(RegisterUsuarioDto registerUsuario);
}