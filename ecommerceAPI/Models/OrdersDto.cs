namespace ecommerceAPI.Models
{
    public class OrdersDto
    {
        //to do: shiping address
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public double Amount { get; set; }

        public string ShippingAddress { get; set; } = string.Empty;
    }
}
