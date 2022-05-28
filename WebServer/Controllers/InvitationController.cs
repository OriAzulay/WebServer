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

    public class InvitationController : Controller
    {
        private readonly WebServerContext _context;

        public InvitationController(WebServerContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name")] Contact c)
        {
           
            if (ModelState.IsValid)
            {
                _context.Add(c);
                await _context.SaveChangesAsync();
                return Created(string.Format("api/contacts/{0}", c.Id), c);

            }
            return BadRequest();
        }
    }
}
