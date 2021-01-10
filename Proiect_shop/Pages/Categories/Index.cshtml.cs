using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_shop.Data;
using Proiect_shop.Models;

namespace Proiect_shop.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_shop.Data.Proiect_shopContext _context;

        public IndexModel(Proiect_shop.Data.Proiect_shopContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
