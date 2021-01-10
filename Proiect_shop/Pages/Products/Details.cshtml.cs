using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_shop.Data;
using Proiect_shop.Models;

namespace Proiect_shop.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_shop.Data.Proiect_shopContext _context;

        public DetailsModel(Proiect_shop.Data.Proiect_shopContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
