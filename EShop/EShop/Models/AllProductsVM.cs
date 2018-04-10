using System.Collections.Generic;

namespace EShop.Models
{
    public class AllProductsVM
    {
        public ICollection<ProductVM> Products { get; set; }
    }
}