using Microsoft.AspNetCore.Mvc;

namespace ziraatProject.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
