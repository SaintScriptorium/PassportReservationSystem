using Domain.Entities;
namespace Application.Interfaces.RepositoryInterfaces;

public interface ISlotAdminRepository
{
    Task AddSlotAsync(Slot slot);
    Task UpdateSlotAsync(Slot slot);
    Task <IEnumerable<Slot>> ListSlotAsync();
    Task DeleteSlotAsync(int slotId);
}