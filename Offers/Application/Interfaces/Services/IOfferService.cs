using Application.DTOs.Offer;

namespace Application.Interfaces.Services;

public interface IOfferService
{
    Task<IEnumerable<OfferDto>> GetAllOffersAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<OfferDto>> GetActiveOffersAsync(CancellationToken cancellationToken = default);
    Task<OfferDto?> GetOfferByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<OfferDto> CreateOfferAsync(CreateOfferDto createOfferDto, CancellationToken cancellationToken = default);
    Task UpdateOfferAsync(Guid id, UpdateOfferDto updateOfferDto, CancellationToken cancellationToken = default);
    Task DeleteOfferAsync(Guid id, CancellationToken cancellationToken = default);
    Task CancelOfferAsync(Guid id, CancellationToken cancellationToken);
}