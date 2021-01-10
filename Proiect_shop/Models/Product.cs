using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_shop.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required, StringLength(150, MinimumLength = 3)]
        [Display(Name = "Product Name")] 
        public string Name { get; set; }
        public string Description { get; set; }

         [Range(1, 300)]
         [Column(TypeName = "decimal(6, 2)")] 
        public decimal Price { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
