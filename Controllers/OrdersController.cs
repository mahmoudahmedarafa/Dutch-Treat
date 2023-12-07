using Dutch_Treat.Data;
using Dutch_Treat.Data.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IDutchRepository repository;
        private readonly UserManager<StoreUser> userManager;

        public OrdersController(IDutchRepository repository, UserManager<StoreUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Get(bool includeItems = true)
        {
            var userName = User.Identity.Name;

            return Ok(repository.GetAllOrdersByUser(userName, includeItems));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = repository.GetOrderById(User.Identity.Name, id);

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
        public async Task<IActionResult> Post([FromBody]Order model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.OrderDate = DateTime.Now;

                    var currentUser = await userManager.FindByNameAsync(User.Identity.Name);
                    model.User = currentUser;

                    repository.AddEntity(model);

                    if (repository.SaveAll())
                    {
                        return Created($"/api/orders/{model.Id}", model);
                    }

                    return BadRequest(ModelState);
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
