using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    public class SignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
