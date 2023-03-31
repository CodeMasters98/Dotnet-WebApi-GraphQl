using Dotnet_WebApi_GraphQl.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet_WebApi_GraphQl.Data.ContextConfigurations
{
    public class ProductContextConfiguration : IEntityTypeConfiguration<Product>
    {
        private Guid[] _ids;

        public ProductContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
        }
    }
}
