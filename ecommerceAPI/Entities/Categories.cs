using System.ComponentModel.DataAnnotations;

namespace ecommerceAPI.Entities
{
    public class Categories
    {
        [Key]   
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; } = "Default";
        
        public string? CategoryDescription { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
