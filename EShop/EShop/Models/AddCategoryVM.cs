using System.Collections.Generic;
using System.ComponentModel;

namespace EShop.Models
{
    public class AddCategoryVM
    {
        public AddCategoryVM()
        {
            this.AllCategories = new List<CategoryVM>();
        }

        [DisplayName("Parent category")]
        public ICollection<CategoryVM> AllCategories { get; set; }

        public CategoryVM Category { get; set; }
    }
}