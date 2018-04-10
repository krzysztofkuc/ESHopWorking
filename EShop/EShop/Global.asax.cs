using AutoMapper;
using ConcertHub.Models;
using EShop.Models;
using EShop.Models.Entities;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EShop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());

            Mapper.Initialize(cfg => {
                cfg.CreateMap<CategoryEntity, CategoryVM>()
                .ForMember(m => m.Categories, opt => opt.MapFrom(c => c.Categories));
                cfg.CreateMap<CategoryVM, CategoryEntity>()
                .ForMember(m => m.Categories, opt => opt.MapFrom(c => c.Categories));
                //cfg.CreateMap<PictureEntity, PictureVM>();

                //cfg.CreateMap<ProductEntity, ProductVM>()
                //.ForMember(m => m.Pictures, opt => opt.MapFrom(c => c.Pictures));

                //cfg.CreateMap<ProductVM, ProductEntity>()
                //.ForMember(m => m.Pictures, opt => opt.MapFrom(c => c.Pictures));


                //cfg.CreateMap<CategoriesVM, Categories>();
            });
            Mapper.AssertConfigurationIsValid();

            //DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
        }
    }
}
