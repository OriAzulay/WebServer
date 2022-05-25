using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
