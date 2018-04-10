using AutoMapper;
using EShop.Models;
using EShop.Models.Entities;

namespace ConcertHub.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<CategoryVM, CategoryEntity>().ForAllMembers(o => o.Ignore());
            //    .ForMember
            //    (dst => dst.Name, src => src.Ignore())
            //    .ForMember
            //    (dst => dst.Id, src => src.Ignore())
            //.ForMember
            //    (dst => dst.ParentId, src => src.Ignore())
            //.ForMember
            //    (dst => dst.CategoriesCol, src => src.Ignore());

        }
    }
}