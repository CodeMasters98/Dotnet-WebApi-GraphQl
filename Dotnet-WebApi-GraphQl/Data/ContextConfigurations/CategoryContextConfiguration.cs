using Dotnet_WebApi_GraphQl.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet_WebApi_GraphQl.Data.ContextConfigurations
{

    public class CategoryContextConfiguration : IEntityTypeConfiguration<Category>
    {
        private Guid[] _ids;

        public CategoryContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {

        }

        
    }
}
