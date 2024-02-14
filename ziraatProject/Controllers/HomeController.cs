using Microsoft.AspNetCore.Mvc;

namespace ziraatProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
