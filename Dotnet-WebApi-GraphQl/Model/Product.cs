﻿using System.ComponentModel.DataAnnotations;

namespace Dotnet_WebApi_GraphQl.Model
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please specify a name for the superhero")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Category category { get; set; }
    }
}
