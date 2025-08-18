using Application.DTOs;
namespace Application.Interfaces;
public interface IReservationService
{
    Task <string> GenerateReservationAsync(CreateReservationDto reservationrRequest);
    Task <IEnumerable<ReservationDto>> GetReservationsAsync(Guid userId);
}
