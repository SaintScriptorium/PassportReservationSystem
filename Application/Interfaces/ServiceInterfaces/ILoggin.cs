namespace Application.Interfaces.ServiceInterfaces;
public interface ILoggin
{
    Task<bool> VerifyUsuario(string email, string password);
}