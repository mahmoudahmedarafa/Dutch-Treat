using Dutch_Treat.Data;
using Dutch_Treat.Services;
using Dutch_Treat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly DutchContext context;

        public AppController(IMailService mailService, DutchContext context)
        {
            _mailService = mailService;
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("shawn@gmail.com", model.Subject,
                    $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }

        public IActionResult Shop()
        {
            var result = context.Products.OrderBy(p => p.Category).ToList();
            return View(result);
        }
    }
}
