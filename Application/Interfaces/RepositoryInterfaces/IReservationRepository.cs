using Domain.Entities;
namespace Application.Interfaces.RepositoryInterfaces;

public interface IReservationRepository
{
    Task AddReservationAsync(Reservation reservationRequest);
    Task <IEnumerable<Reservation>> ListReservationAsync(int userId);
    Task DeleteReservationAsync(int reservationId);
}