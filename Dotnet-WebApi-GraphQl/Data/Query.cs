using Dotnet_WebApi_GraphQl.Model;

namespace Dotnet_WebApi_GraphQl.Data
{
    public class Query
    {

        //Old
        //public IQueryable<Product> Products => new List<Product>().AsQueryable();
        //New
        public IQueryable<Product> GetProducts([Service] ApplicationDbContext context) => context.Products;

        //Old
        //public IQueryable<Category> Categories => new List<Category>().AsQueryable();
        //New
        public IQueryable<Category> GetCategories([Service] ApplicationDbContext context) => context.Categories;
    }
}
