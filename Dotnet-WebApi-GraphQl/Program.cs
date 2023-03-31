using Dotnet_WebApi_GraphQl.Data;
using Dotnet_WebApi_GraphQl.Data.ContextConfigurations;
using Dotnet_WebApi_GraphQl.Interfaces;
using Dotnet_WebApi_GraphQl.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>();

builder.Services.AddDbContext<ApplicationDbContext> (o => o.UseInMemoryDatabase("MyDatabase"));

var app = builder.Build();

SeedData.AddCategoryData(app);
SeedData.AddProductData(app);

app.MapGet("/", () => "Hello World!");
app.MapGraphQL(path:"/graphql");

app.Run();
