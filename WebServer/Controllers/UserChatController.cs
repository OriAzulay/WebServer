using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    public class UserChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
