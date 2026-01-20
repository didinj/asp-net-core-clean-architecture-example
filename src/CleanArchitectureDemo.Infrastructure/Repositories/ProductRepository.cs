using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<IReadOnlyList<Product>> GetAllAsync()
    {
        return await _context.Products.AsNoTracking().ToListAsync();
    }
}
