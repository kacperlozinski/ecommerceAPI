using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ecommerceAPI.Entities
{
    public class Products
    {
        
        [Key]
        public int ProdctId { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Brand { get; set; }
        [Required]
        [MaxLength (20)]
        public string? Name { get; set; }
        [MaxLength (200)]
        public string? Description { get; set; }
        public int CategoryId { get; set; } 
        [Required]
        public double Price     { get; set; }
        public bool IsAvailable { get; set; }

        public virtual Categories Categories { get; set; }
       

    }
}
