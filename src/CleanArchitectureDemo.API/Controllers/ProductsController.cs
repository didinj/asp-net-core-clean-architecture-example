using CleanArchitectureDemo.Application.UseCases.CreateProduct;
using CleanArchitectureDemo.Application.UseCases.GetProducts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly CreateProductHandler _createHandler;
    private readonly GetProductsHandler _getHandler;

    public ProductsController(
        CreateProductHandler createHandler,
        GetProductsHandler getHandler)
    {
        _createHandler = createHandler;
        _getHandler = getHandler;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        var id = await _createHandler.HandleAsync(command);
        return CreatedAtAction(nameof(GetAll), new { id }, null);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _getHandler.HandleAsync();
        return Ok(products);
    }
}
