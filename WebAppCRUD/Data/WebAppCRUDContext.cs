using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppCRUD.Models
{
    public class WebAppCRUDContext : DbContext
    {
        public WebAppCRUDContext (DbContextOptions<WebAppCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCRUD.Models.Alumnos> Alumnos { get; set; }
    }
}
