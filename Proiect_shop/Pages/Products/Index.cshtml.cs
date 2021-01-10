using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_shop.Data;
using Proiect_shop.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Proiect_shop.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_shop.Data.Proiect_shopContext _context;

        public IndexModel(Proiect_shop.Data.Proiect_shopContext context)
        {
            
            _context = context;
        }

        

        public IList<Product> Product { get;set; }
        public ProductData ProductD { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }

        public async Task OnGetAsync(int? id, int? categoryID)
        {
                ProductD = new ProductData();

            ProductD.Products = await _context.Product
            .Include(b => b.Brand)
            .Include(b => b.ProductCategories)
            .ThenInclude(b => b.Category)
            .AsNoTracking()
            .OrderBy(b => b.Name)
            .ToListAsync();
            if (id != null)
            {
                ProductID = id.Value;
                Product Product = ProductD.Products
                .Where(i => i.ID == id.Value).Single();
                ProductD.Categories = Product.ProductCategories.Select(s => s.Category);
            }
        }

        
    }
}
