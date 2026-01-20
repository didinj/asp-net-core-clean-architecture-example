using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.UseCases.CreateProduct;
using CleanArchitectureDemo.Application.UseCases.GetProducts;
using CleanArchitectureDemo.Infrastructure.Persistence;
using CleanArchitectureDemo.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();

// Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Use cases
builder.Services.AddScoped<CreateProductHandler>();
builder.Services.AddScoped<GetProductsHandler>();

var app = builder.Build();

app.MapControllers();
app.UseExceptionHandler("/error");
app.Run();
