using Application.DTOs;
namespace Application.Interfaces.ServiceInterfaces;
public interface IReservationService
{
    Task <string> PostReservationAsync(CreateReservationDto reservationrRequest);
    Task <IEnumerable<ReservationDto>> GetReservationsAsync(int userId);
}
