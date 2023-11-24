using Dutch_Treat.Data.Entities;
using System.Text.Json;

namespace Dutch_Treat.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext context;

        public DutchSeeder(DutchContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {
                var json = File.ReadAllText("Data/art.json");
                var products = JsonSerializer.Deserialize<IEnumerable<Product>>(json);

                context.Products.AddRange(products);

                var order = new Order()
                {
                    OrderDate = DateTime.Today,
                    OrderNumber = "12345",
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        }
                    }
                };

                context.SaveChanges();
            }
        }
    }
}
