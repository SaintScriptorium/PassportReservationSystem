using Application.DTOs;
namespace Application.Interfaces.ServiceInterfaces;

public interface ISlotClient
{
      Task<IEnumerable<SlotDto>> GetSlotsAsync();
}