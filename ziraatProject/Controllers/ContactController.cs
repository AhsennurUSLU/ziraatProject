using Microsoft.AspNetCore.Mvc;

namespace ziraatProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
