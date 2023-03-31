using Dotnet_WebApi_GraphQl.Model;

namespace Dotnet_WebApi_GraphQl.Data
{
    public static class SeedData
    {
        public static void AddCategoryData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<ApplicationDbContext>();

            var c1 = new Category
            {
                Id = new Guid(),
                Name = "Mobile",
            };

            var c2 = new Category
            {
                Id = new Guid(),
                Name = "tablet",
            };

            db.Categories.Add(c1);
            db.Categories.Add(c2);

            db.SaveChanges();
        }

        public static void AddProductData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<ApplicationDbContext>();

            var p1 = new Product
            {
                Id = new Guid(),
                Name = "Iphone 13",
                Description = "Iphone 13",
                Price = 1000
            };
            var p2 = new Product
            {
                Id = new Guid(),
                Name = "Iphone 13 Pro Max",
                Description = "Iphone 13",
                Price = 1000
            };
            var p3 = new Product
            {
                Id = new Guid(),
                Name = "Iphone 12",
                Description = "Iphone 13",
                Price = 1000
            };

            db.Products.Add(p1);
            db.Products.Add(p2);
            db.Products.Add(p3);

            db.SaveChanges();
        }
    }
}
