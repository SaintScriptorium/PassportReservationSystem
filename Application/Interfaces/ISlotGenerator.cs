namespace Application.Interfaces;

public interface ISlotGenerator
{
    Task GenerateSlotAsync(int ConfigId, CancellationToken ct = default);
}