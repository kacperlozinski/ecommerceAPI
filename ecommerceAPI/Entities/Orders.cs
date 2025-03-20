using System.ComponentModel.DataAnnotations;

namespace ecommerceAPI.Entities
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public double Amount { get; set; }

        public string ShippingAddress { get; set; } = string.Empty;
        

    }
}
