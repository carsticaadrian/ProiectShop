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
    public class DetailsModel : PageModel
    {
        private readonly Proiect_shop.Data.Proiect_shopContext _context;

        public DetailsModel(Proiect_shop.Data.Proiect_shopContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
