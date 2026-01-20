using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Interfaces;

public interface IProductRepository
{
    Task AddAsync(Product product);
    Task<Product?> GetByIdAsync(Guid id);
    Task<IReadOnlyList<Product>> GetAllAsync();
}
