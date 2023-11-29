using Dutch_Treat.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.Controllers
{
    [Route("api/orders/{orderid}/items")]
    [ApiController]
    public class OrderItemsController : Controller
    {
        private readonly IDutchRepository repository;

        public OrderItemsController(IDutchRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Get(int orderId)
        {
            var order = repository.GetOrderById(orderId);

            if(order != null)
            {
                return Ok(order.Items);
            }

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int orderId, int id)
        {
            var order = repository.GetOrderById(orderId);

            if (order != null)
            {
                var item = order.Items.Where(oi => oi.Id == id).FirstOrDefault();

                if(item != null)
                {
                    return Ok(item);
                }
            }

            return NotFound();
        }
    }
}
