using Domain.Entities;
using Application.DTOs;

namespace Application.Interfaces.ServiceInterfaces;

public interface ISlotAdmin
{
    Task PostSlotAsync(ConfigurationDto config);
    Task  PutSlotAsync(ConfigurationDto config);
    Task<IEnumerable<Slot>> GetSlotsAsync();
    Task DeleteSlotAsync(int slotId);
}