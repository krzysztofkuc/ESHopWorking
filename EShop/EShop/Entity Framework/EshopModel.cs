namespace EShop.Entity_Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using EShop.Models.Entities;

    public partial class EshopModel : DbContext
    {
        public EshopModel()
            : base("name=EshopModelConnString")
        {
        }

        public virtual DbSet<ProductEntity> Products { get; set; }
        public virtual DbSet<CategoryEntity> Categories { get; set; }
        public virtual DbSet<PictureEntity> Pictures { get; set; }

        //public virtual DbSet<CategoriesCol> ChildCategories { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PictureEntity>().
        //      HasOptional(e => e.Product).
        //      WithMany().
        //      HasForeignKey(m => m.ProductId);
        //}

        //public System.Data.Entity.DbSet<EShop.Models.CategoriesVM> CategoriesVMs { get; set; }
    }
}
