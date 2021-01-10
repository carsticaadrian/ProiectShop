using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_shop.Models;

namespace Proiect_shop.Data
{
    public class Proiect_shopContext : DbContext
    {
        public Proiect_shopContext (DbContextOptions<Proiect_shopContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_shop.Models.Product> Product { get; set; }

        public DbSet<Proiect_shop.Models.Brand> Brand { get; set; }

        public DbSet<Proiect_shop.Models.Category> Category { get; set; }
    }
}
