using ecommerceAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace ecommerceAPI.Models
{
    public class ProductsDto
    {

        [Required]
        [MaxLength(20)]
        public string? Brand { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
