using AutoMapper;
using MarketPlace.Dtos;
using MarketPlace.Dtos.NewFolder;
using MarketPlace.Dtos.Requests;
using MarketPlace.Models;

namespace POS_API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
       public AutoMapperProfiles()
        {
            CreateMap<UserDTO, User>().ForMember(
                des => des.Member,
                src => src.MapFrom(src => src.MemberDTO)
            ).ForPath(
                des => des.Member.Location,
                src => src.MapFrom(src => src.MemberDTO.LocationDTO)
            );

            CreateMap<User,UserDTO>().ForMember(
                des => des.MemberDTO,
                src => src.MapFrom(src => src.Member)
            ).ForPath(
                des => des.MemberDTO.LocationDTO,
                src => src.MapFrom(src => src.Member.Location)
            );

            CreateMap<Member, MemberDTO>().ForMember(
                des => des.LocationDTO,
                src => src.MapFrom(src => src.Location)
            );

            CreateMap<MemberDTO, Member>().ForMember(
                des => des.Location,
                src => src.MapFrom(src => src.LocationDTO)
            );

            CreateMap<LocationDTO, Location>();
            CreateMap<Location, LocationDTO>();

            CreateMap<RegisterRequestDto, User>().ForMember(
                des => des.Member,
                src => src.MapFrom(src => src.MemberDTO)
            ).ForPath(
                des => des.Member.Location,
                src => src.MapFrom(src => src.MemberDTO.LocationDTO)
            );
        }
    }
}
