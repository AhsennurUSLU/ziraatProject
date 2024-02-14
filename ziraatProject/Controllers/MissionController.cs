using Microsoft.AspNetCore.Mvc;

namespace ziraatProject.Controllers
{
    public class MissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
