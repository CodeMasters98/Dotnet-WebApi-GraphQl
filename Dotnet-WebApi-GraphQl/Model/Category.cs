using System.ComponentModel.DataAnnotations;

namespace Dotnet_WebApi_GraphQl.Model
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please specify a name for the superhero")]
        public string Name { get; set; }
    }
}
