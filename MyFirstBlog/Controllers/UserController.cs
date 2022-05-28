using Microsoft.AspNetCore.Mvc;

namespace MyFirstBlog.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout() 
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }
    }
}
