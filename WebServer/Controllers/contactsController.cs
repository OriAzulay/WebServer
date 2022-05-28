using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebServer.Data;
using WebServer.Models;

namespace WebServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class contactsController : Controller
    {
        private readonly WebServerContext _context;

        public contactsController(WebServerContext context)
        {
            _context = context;
        }

        [HttpGet]

        // GET: Users
       /* public async Task<IActionResult> Index()
        {
              return Json(await _context.User.ToListAsync());
        }*/
        public async Task<IActionResult> Index2()
        {
            var q = _context.Contacts;
            //  Where(user => user.UserName.All || user.Password.All);

            return Json(await q.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var c = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            return Json(c);

        }   


    }
}
