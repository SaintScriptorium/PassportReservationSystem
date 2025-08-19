using Domain.Entities;
namespace Application.Interfaces.RepositoryInterfaces;

public interface ISlotClientRepository
{
    Task<IEnumerable<Slot>> ShowSlots();
}