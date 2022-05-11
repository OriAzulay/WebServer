using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
