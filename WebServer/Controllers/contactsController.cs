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
     
        [HttpDelete("{id}")]
        //api/contacts/id
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var c = await _context.Contacts.FindAsync(id);
            if (c == null)
            {
                return StatusCode(204);
            }
            if (c.Id == id)
            {
                 _context.Remove(c);
                 return Ok();
            }
            
            _context.Contacts.Remove(c);
            await _context.SaveChangesAsync();
            return NoContent();

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

        public class addcontact
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Server { get; set; }
            public string Connected { get; set; }
        }
       /*
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] addcontact cont /*string connected,  string id, string name, string server*/ /*[Bind("Id,Name,Server")] Contacts contacts*/
/*{

            Contact contact = new Contact() { Id = cont.Id, Server = cont.Server, Name = cont.Name };
            if (contact == null)
            {
                return BadRequest();
            }
            contact.LastDate = null;
            contact.Last = null;

            await _context.SaveChangesAsync();
            return Ok();
        */

     
        /* private dynamic addContact(Contact contact)
{
    if (contact == null)
    {
        return (new { });
    }
    var temp = new
    {
        id = contact.Id,
        name = contact.Name,
        server = contact.Server,
        last = contact.Last,
        lastDate = contact.LastDate
    };
    return temp;
}*/



    }
}
