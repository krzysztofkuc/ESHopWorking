using System.Collections.Generic;

namespace EShop.Models
{
    public class CategoryVM
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }

        public ICollection<CategoryVM> Categories { get; set; }

        public ICollection<ProductVM> Products { get; set; }

    }
}