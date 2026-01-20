namespace CleanArchitectureDemo.Application.UseCases.GetProducts;

using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Domain.Entities;

public class GetProductsHandler
{
    private readonly IProductRepository _repository;

    public GetProductsHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyList<Product>> HandleAsync()
    {
        return await _repository.GetAllAsync();
    }
}