using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.UseCases.CreateProduct;

public class CreateProductHandler
{
    private readonly IProductRepository _repository;

    public CreateProductHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> HandleAsync(CreateProductCommand command)
    {
        var product = new Product(command.Name, command.Price);
        await _repository.AddAsync(product);
        return product.Id;
    }
}
