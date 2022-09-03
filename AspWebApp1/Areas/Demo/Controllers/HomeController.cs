using Microsoft.AspNetCore.Mvc;

namespace AspWebApp1.Areas.Demo.Controllers
{
    [Area("Demo")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World Bro!");
        }
        public IActionResult Index2()
        {
            return View();
        }

       
    }
}
