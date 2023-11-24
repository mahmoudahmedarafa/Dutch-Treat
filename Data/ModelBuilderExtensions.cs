using Dutch_Treat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Dutch_Treat.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var json = File.ReadAllText("Data/art.json");
            var products = JsonSerializer.Deserialize<IEnumerable<Product>>(json);

            foreach(var p in products)
            {
                modelBuilder.Entity<Product>().HasData(p);
            }

            var order = new Order()
            {
                Id = 1,
                OrderDate = DateTime.Today,
                OrderNumber = "12345"
            };

            var orderItem = new OrderItem()
            {
                Id = 1,
                OrderId = order.Id,
                ProductId = products.First().Id,
                Product = products.First(),
                Quantity = 5,
                UnitPrice = products.First().Price
            };

            modelBuilder.Entity<OrderItem>().HasData(orderItem);
        }
    }
}
