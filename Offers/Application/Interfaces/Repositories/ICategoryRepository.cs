using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<bool> CategoryExistsAsync(string name, CancellationToken cancellationToken = default);
}