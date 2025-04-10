using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IOfferRepository : IGenericRepository<Offer>
{
    Task<IEnumerable<Offer>> GetActiveOffersAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<Offer>> GetActiveOffersByCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default);
    Task<IEnumerable<Offer>> GetExpiredOffersAsync(DateTime threshold, CancellationToken cancellationToken = default);
}