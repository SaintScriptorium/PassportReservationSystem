using Domain.Entities;
namespace Application.Interfaces.RepositoryInterfaces;

public interface IRegisterUsuarioRepository
{
    Task AddUsuario(Usuario user); 
}