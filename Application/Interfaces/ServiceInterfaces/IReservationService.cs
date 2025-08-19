using Application.DTOs;
namespace Application.Interfaces.ServiceInterfaces;
public interface IReservationService
{
    Task PostReservationAsync(CreateReservationDto reservationrRequest);
    Task <IEnumerable<ReservationDto>> GetReservationsAsync(int userId);

    Task DeleteReservationAsync(int reservationId);
}
