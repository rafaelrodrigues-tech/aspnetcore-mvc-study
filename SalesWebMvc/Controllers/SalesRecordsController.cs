using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc2.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSeach()
        {
            return View();
        }
        public IActionResult GroupingSeach()
        {
            return View();
        }
    }
}
