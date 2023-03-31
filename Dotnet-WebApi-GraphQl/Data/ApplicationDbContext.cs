using Dotnet_WebApi_GraphQl.Data.ContextConfigurations;
using Dotnet_WebApi_GraphQl.Model;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_WebApi_GraphQl.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Generate three GUIDS and place them in an arrays
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            // Apply configuration for the three contexts in our application
            // This will create the demo data for our GraphQL endpoint.
            builder.ApplyConfiguration(new ProductContextConfiguration(ids));
            builder.ApplyConfiguration(new CategoryContextConfiguration(ids));
        }

        // Add the DbSets for each of our models we would like at our database
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
