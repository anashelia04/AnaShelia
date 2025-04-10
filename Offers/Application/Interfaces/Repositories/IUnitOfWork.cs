namespace Application.Interfaces.Repositories;

public interface IUnitOfWork : IAsyncDisposable
{
    ICategoryRepository Categories { get; }
    IOfferRepository Offers { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}