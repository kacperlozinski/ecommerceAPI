using ecommerceAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace ecommerceAPI.Models
{
    public class CategoriesDto
    {
        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; } = "Default";

        public string? CategoryDescription { get; set; }

    }
}
