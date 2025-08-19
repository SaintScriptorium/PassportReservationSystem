using Application.DTOs;

namespace Application.Interfaces.ServiceInterfaces;
public interface IConfigurator
{
    
    //discutir con el profesor si es debido crear un private task que devuelva un objeto, y crear un objeto en una public task que tenga un objeto de este task (private) y lo mande al Repositorio
    Task<string> PostConfiguration(ConfigurationDto config);
    Task<string> PutConfiguration(ConfigurationDto config);
    Task<IEnumerable<ConfigurationDto>> GetConfiguration();
    Task<string> DeleteConfiguration(int Id);
}