using Domain.Entities;
namespace Application.Interfaces.RepositoryInterfaces;

public interface IConfiguratorRepository
{
    Task AddConfigurationAsync(Configuration config);
    Task UpdateConfigurationAsync(Configuration config);
    Task <IEnumerable<Configuration>>ListConfigurationAsync();
    Task DeleteConfigurationAsync(int configId);
}