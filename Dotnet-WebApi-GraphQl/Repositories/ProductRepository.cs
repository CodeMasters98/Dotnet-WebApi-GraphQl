using Dotnet_WebApi_GraphQl.Data;
using Dotnet_WebApi_GraphQl.Interfaces;

namespace Dotnet_WebApi_GraphQl.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public ProductRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
