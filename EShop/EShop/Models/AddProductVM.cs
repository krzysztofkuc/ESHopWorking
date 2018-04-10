using System.Collections.Generic;

namespace EShop.Models
{
    public class AddProductVM
    {
        public ICollection<ProductVM> AllProducts { get; set; }

        public ICollection<CategoryVM> AllCategories { get; set; }

        public ProductVM CurrentProduct { get; set; }
    }
}