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
    public class UsersController : Controller
    {
        private readonly WebServerContext _context;

        public UsersController(WebServerContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
              return View(await _context.User.ToListAsync());
        }


        // GET: Users/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Users/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                var r = _context.User.Where(u => u.UserName == user.UserName && u.Password == user.Password);

                if (r.Any())
                {
                    return RedirectToAction(nameof(Index),"Chat");
                }
                else
                {
                    ViewData["Error"] = "User name or password is not correct!";
                }
            }
            return View(user);
        }
        

        // GET: Users/SignUp
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([Bind("UserName,Password")] User user)
        {
            if(ModelState.IsValid)
                if (ModelState.IsValid)
                {
                    var checkUser = from u in _context.User
                                where u.UserName == user.UserName
                                select u;
                    
                    if (checkUser.Count() > 0)
                    {
                        ViewData["Error"] = "This account is already exist!";
                    }

                    else
                    {
                        if(user.Password.Length >=8 && user.Password.Length <= 2)
                        {
                            ViewData["Error"] = "Password has to be between 2-8 characters.";
                        } 
                        _context.Add(user);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index), "Chat");
                    }
                }
            return View(user);
        }


    }
}
