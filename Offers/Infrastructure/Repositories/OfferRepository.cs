using Application.Interfaces.Repositories;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class OfferRepository : GenericRepository<Offer>, IOfferRepository
{
    public OfferRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Offer>> GetActiveOffersAsync(CancellationToken cancellationToken = default)
    {
        return await _dbSet
            .Where(o => o.Status == OfferStatus.Active && o.EndTime > DateTime.Now)
            .Include(o => o.Category)
            .OrderBy(o => o.EndTime)
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Offer>> GetActiveOffersByCategoryAsync(Guid categoryId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet
            .Where(o => o.Status == OfferStatus.Active &&
                        o.EndTime > DateTime.Now &&
                        o.CategoryId == categoryId)
            .Include(o => o.Category)
            .OrderBy(o => o.EndTime)
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Offer>> GetExpiredOffersAsync(DateTime threshold,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet
            .Where(o => o.Status == OfferStatus.Active && o.EndTime <= threshold)
            .Include(o => o.Category)
            .OrderByDescending(o => o.EndTime)
            .ToListAsync(cancellationToken);
    }
}