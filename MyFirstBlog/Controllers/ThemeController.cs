using Microsoft.AspNetCore.Mvc;

namespace MyFirstBlog.Controllers
{
    public class ThemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
