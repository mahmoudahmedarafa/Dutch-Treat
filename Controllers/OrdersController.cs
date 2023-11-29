using Dutch_Treat.Data;
using Dutch_Treat.Data.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.Controllers
{
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IDutchRepository repository;

        public OrdersController(IDutchRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Get(bool includeItems = true)
        {
            return Ok(repository.GetAllOrders(includeItems));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = repository.GetOrderById(id);

            if(order != null)
            {
                return Ok(order);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Order model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repository.AddEntity(model);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest(ex.Message);
            }

            return Created($"/api/orders/{model.Id}", model);
        }
    }
}
