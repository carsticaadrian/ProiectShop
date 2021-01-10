using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_shop.Data;
using Proiect_shop.Models;

namespace Proiect_shop.Pages.Brands
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_shop.Data.Proiect_shopContext _context;

        public IndexModel(Proiect_shop.Data.Proiect_shopContext context)
        {
            _context = context;
        }

        public IList<Brand> Brand { get;set; }

        public async Task OnGetAsync()
        {
            Brand = await _context.Brand.ToListAsync();
        }
    }
}
