using ecommerceAPI.Entities;

namespace ecommerceAPI
{
    public class EcommerceSeeder
    {
        private readonly EcommerceDbContext _dbContext;

        public EcommerceSeeder(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Categories.Any())
                {
                    var categories = GetCategories();
                    _dbContext.Categories.AddRange(categories);
                    await _dbContext.SaveChangesAsync();
                }
                if (!_dbContext.Products.Any())
                {
                    var products = GetProducts();
                    _dbContext.Products.AddRange(products);
                    await _dbContext.SaveChangesAsync();
                }

                
                if( !_dbContext.Orders.Any())
                {
                    var orders = GetOrders();
                    _dbContext.Orders.AddRange(orders);
                   await _dbContext.SaveChangesAsync();   
                }
            }
        }
        private IEnumerable<Products> GetProducts()
        {
            var products = new List<Products>()
            {
                new Products()
                { 
                    Brand = "Sony",
                    Name = "Telewizor 4K",
                    Description = "Nowoczesny telewizor 4K z inteligentnymi funkcjami",
                    CategoryId = 1,
                    Price = 3500.0,
                    IsAvailable = true
                },
                new Products()
                {
                    Brand = "Nike",
                    Name = "Buty sportowe",
                    Description = "Wygodne buty do biegania",
                    CategoryId = 2,
                    Price = 299.99,
                    IsAvailable = true
                }
            };
                return products;
        }

        public List<Categories> GetCategories()
        {
           var categories = new List<Categories>()
            {
                new Categories
                {
                    CategoryName = "Elektronika",
                    CategoryDescription = "Produkty elektroniczne, takie jak telewizory, smartfony i laptopy."
                },
                new Categories
                {
                    CategoryName = "Odzież",
                    CategoryDescription = "Ubrania i akcesoria, w tym buty sportowe i kurtki."
                },
                new Categories
                {
                    CategoryName = "Książki",
                    CategoryDescription = "Książki w wersji papierowej i elektronicznej."
                }
             };
            return categories;
        }


        public List<Orders> GetOrders()
        {
            var orders = new List<Orders>()
            {
                new Orders
                {
                    CustomerId = "cust001",
                    OrderDate = DateTime.Now.AddDays(-3),
                    Amount = 3500.0,
                    ShippingAddress = "ul. Przykładowa 10, Warszawa"
                },
                new Orders
                {
                    CustomerId = "cust002",
                    OrderDate = DateTime.Now.AddDays(-2),
                    Amount = 299.99,
                    ShippingAddress = "ul. Inna 5, Kraków"
                },
                new Orders
                {

                    CustomerId = "cust003",
                    OrderDate = DateTime.Now.AddDays(-1),
                    Amount = 4999.99,
                    ShippingAddress = "ul. Centralna 12, Gdańsk"
                }
            };
                return orders;
        }


    }

}
