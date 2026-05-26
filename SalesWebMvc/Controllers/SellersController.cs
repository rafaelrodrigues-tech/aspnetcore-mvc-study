using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc2.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
