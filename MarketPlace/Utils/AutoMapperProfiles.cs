using AutoMapper;
using MarketPlace.Dtos;
using MarketPlace.Dtos.Requests;
using MarketPlace.Models;
using System.Linq;

namespace POS_API.Helpers {
public class AutoMapperProfiles : Profile {
  public AutoMapperProfiles() {

    // DTO Maps

    CreateMap<UserDTO, User>()
        .ForMember(des => des.Member, src => src.MapFrom(src => src.MemberDTO))
        .ForPath(des => des.Member.Location,
                 src => src.MapFrom(src => src.MemberDTO.LocationDTO));
    CreateMap<User, UserDTO>()
        .ForMember(des => des.MemberDTO, src => src.MapFrom(src => src.Member))
        .ForPath(des => des.MemberDTO.LocationDTO,
                 src => src.MapFrom(src => src.Member.Location));

    CreateMap<Member, MemberDTO>().ForMember(
        des => des.LocationDTO, src => src.MapFrom(src => src.Location));
    CreateMap<MemberDTO, Member>().ForMember(
        des => des.Location, src => src.MapFrom(src => src.LocationDTO));

    CreateMap<Category, CategoryDTO>().ForMember(
        des => des.SubCategories, src => src.MapFrom(src => src.SubCategories));
    //    .ForPath(
    //    des => des.SubCategories.Select((e)=>e.Brand),
    //    src => src.MapFrom(src => src.SubCategories.Select((e) => e.Brand))
    //);
    CreateMap<CategoryDTO, Category>().ForMember(
        des => des.SubCategories, src => src.MapFrom(src => src.SubCategories));
    //    .ForPath(
    //    des => des.SubCategories.Select((e) => e.Brand),
    //    src => src.MapFrom(src => src.SubCategories.Select((e) => e.Brand))
    //);

    CreateMap<SubCategory, SubCategoryDTO>().ForMember(
        des => des.Brand, src => src.MapFrom(src => src.Brand));
    CreateMap<SubCategoryDTO, SubCategory>().ForMember(
        des => des.Brand, src => src.MapFrom(src => src.Brand));

    CreateMap<Brand, BrandDTO>();
    CreateMap<BrandDTO, Brand>();

    CreateMap<LocationDTO, Location>();
    CreateMap<Location, LocationDTO>();

    CreateMap<ProductImage, ProductImageDTO>();
    CreateMap<ProductImageDTO, ProductImage>();

    CreateMap<Store, StoreDTO>()
        .ForMember(des => des.Location, src => src.MapFrom(src => src.Location))
        .ForMember(des => des.Products,
                   src => src.MapFrom(src => src.Products));
    CreateMap<StoreDTO, Store>().ForMember(
        des => des.Location, src => src.MapFrom(src => src.Location));

    CreateMap<Product, ProductDTO>()
        .ForMember(des => des.Category, src => src.MapFrom(src => src.Category))
        .ForPath(des => des.Category.SubCategories,
                 src => src.MapFrom(src => src.Category.SubCategories));
    //.ForPath(
    //    des => des.Category.SubCategories.Select((e) => e.Brand),
    //    src => src.MapFrom(src => src.Category.SubCategories.Select((e) =>
    //    e.Brand))
    //).ForMember(
    //    des => des.Store,
    //    src => src.MapFrom(src => src.Store)
    //).ForPath(
    //    des => des.Store.Location,
    //    src => src.MapFrom(src => src.Store.Location)
    //).ForMember(
    //    des => des.SubCategory,
    //    src => src.MapFrom(src => src.SubCategory)
    //);

    // Request Maps
    CreateMap<RegisterRequestDto, User>()
        .ForMember(des => des.Member, src => src.MapFrom(src => src.Member))
        .ForPath(des => des.Member.Location,
                 src => src.MapFrom(src => src.Member.LocationDTO));
  }
}
}
