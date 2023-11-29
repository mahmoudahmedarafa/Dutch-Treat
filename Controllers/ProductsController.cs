using Dutch_Treat.Data;
using Dutch_Treat.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IDutchRepository repository;

        public ProductsController(IDutchRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(repository.GetAllProducts());
        }
    }
}
