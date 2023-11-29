using Dutch_Treat.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dutch_Treat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext context;

        public DutchRepository(DutchContext context)
        {
            this.context = context;
        }

        public void AddEntity(object model)
        {
            context.Add(model);
            SaveAll();
        }

        public IEnumerable<Order> GetAllOrders(bool includeItems)
        {
            if (includeItems)
            {
                return context.Orders.Include(o => o.Items).ThenInclude(oi => oi.Product).ToList();
            }

            return context.Orders.ToList();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products.OrderBy(p => p.Title).ToList();
        }

        public Order GetOrderById(int id)
        {
            return context.Orders.Where(o => o.Id == id)
                                 .Include(o => o.Items)
                                 .ThenInclude(oi => oi.Product)
                                 .FirstOrDefault();
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return context.Products.Where(p => p.Category == category).ToList();
        }

        public bool SaveAll()
        {
            return context.SaveChanges() > 0;
        }
    }
}
