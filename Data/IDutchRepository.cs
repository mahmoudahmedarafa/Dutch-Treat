using Dutch_Treat.Data.Entities;

namespace Dutch_Treat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        bool SaveAll();
        IEnumerable<Order> GetAllOrders(bool includeItems);
        Order GetOrderById(string userName, int id);
        void AddEntity(object model);
        IEnumerable<Order> GetAllOrdersByUser(string userName, bool includeItems);
    }
}