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
            var products = JsonSerializer.Deserialize<List<Product>>(json);

            for(int i = 1; i <= products.Count(); i++)
            {
                products[i - 1].Id = i;
                modelBuilder.Entity<Product>().HasData(products[i - 1]);
            }

            var order = new Order()
            {
                Id = 1,
                OrderDate = DateTime.Today,
                OrderNumber = "12345"
            };

            modelBuilder.Entity<Order>().HasData(order);

            //var orderItem = new OrderItem()
            //{
            //    Id = 1,
            //    OrderId = order.Id,
            //    ProductId = products.First().Id,
            //    Product = products.First(),
            //    Order = order,
            //    Quantity = 5,
            //    UnitPrice = products.First().Price
            //};

            //modelBuilder.Entity<OrderItem>().HasData(orderItem);
        }
    }
}
