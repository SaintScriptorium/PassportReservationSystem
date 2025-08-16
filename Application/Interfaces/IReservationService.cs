using Application.DTOs;
namespace Application.Interfaces;

public class ReservationResult
{
    public bool sucess { get; set; }
    public string ErrorMsg { get; set; }
    public Guid ReservationId { get; set; }
}

public interface IReservationService
{
    Task <ReservationResult> GenerateReservationAsync(Guid userId, Guid SlotId, CancellationToken ct = default);
    Task CancelAsync(Guid ReservationId, Guid UserId, CancellationToken ct = default);
    Task <IEnumerable<ReservationDto>> GetReservationsAsync(Guid userId, CancellationToken ct = default);
}
