using AutoMapper;
using AutoMapper.QueryableExtensions;
using EShop.Entity_Framework;
using EShop.Models;
using EShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
        private EshopModel db = new EshopModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddCategory()
        {
            ViewBag.Message = "Add category page.";

            AddCategoryVM acVM = new AddCategoryVM();
            //var entities = db.Categories.ToList();

            var cats = db.Categories;
            acVM.AllCategories = Mapper.Map<List<CategoryVM>>(cats);

            return View(acVM);
        }

        [HttpPost]
        public ActionResult AddCategory(AddCategoryVM cat)
        {
            if (ModelState.IsValid)
            {
                var category = Mapper.Map<CategoryEntity>(cat.Category);

                db.Categories.Add(category);
                db.SaveChanges();

                ViewBag.Message = "Category Added succefully";
            }
            AddCategoryVM acVM = new AddCategoryVM();
            acVM.AllCategories = Mapper.Map<List<CategoryVM>>(db.Categories);

            return View(acVM);
        }

        public ActionResult AddProduct()
        {
            ViewBag.Message = "Add product page.";
            AddProductVM acVM = new AddProductVM();

            acVM.AllProducts = Mapper.Map<List<ProductVM>>(db.Products);
            acVM.AllCategories = Mapper.Map<List<CategoryVM>>(db.Categories);
            acVM.CurrentProduct = new ProductVM();

            return View(acVM);
        }

        [HttpPost]
        public ActionResult AddProduct(AddProductVM product)
        {
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<ProductEntity>(product.CurrentProduct);
                db.Products.Add(entity);
                db.Entry(entity).State = EntityState.Added;

                db.SaveChanges();
            }

            return RedirectToAction("AddProduct");
        }

        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            var entity = db.Products.Find(id);
            var vm = Mapper.Map<ProductVM>(entity);
            
            return View(vm);
        }

        [HttpPost]
        public ActionResult EditProduct(ProductVM product)
        {
            var entity = Mapper.Map<ProductEntity>(product);
            db.Products.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("AddProduct");
        }

        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            var entity = db.Products.Find(id);
            db.Products.Remove(entity);
            db.Entry(entity).State = EntityState.Deleted;

            db.SaveChanges();

            //var allProducts = Mapper.Map<ICollection<ProductVM>>(db.Products); 

            return RedirectToAction("AddProduct");
        }

    }
}