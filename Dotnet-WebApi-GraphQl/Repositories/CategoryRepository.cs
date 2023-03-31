using Dotnet_WebApi_GraphQl.Data;
using Dotnet_WebApi_GraphQl.Interfaces;

namespace Dotnet_WebApi_GraphQl.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CategoryRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
