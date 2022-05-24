using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebServer.Models;

namespace WebServer.Data
{
    public class WebServerContext : DbContext
    {
        public WebServerContext (DbContextOptions<WebServerContext> options)
            : base(options)
        {
        }

        public DbSet<WebServer.Models.User>? User { get; set; }
    }
}
