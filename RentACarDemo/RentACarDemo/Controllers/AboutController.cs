using Microsoft.AspNetCore.Mvc;

namespace RentACarDemo.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
