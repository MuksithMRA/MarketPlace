using AutoMapper;
using MarketPlace.Dtos;
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
            CreateMap<MemberDTO, Member>().ForMember(
                des => des.Location,
                src => src.MapFrom(src => src.LocationDTO)
            );
            CreateMap<LocationDTO, Location>();

            CreateMap<RegisterRequestDto, User>().ForMember(
                des => des.Member,
                src => src.MapFrom(src => src.memberDTO)
            ).ForPath(
                des => des.Member.Location,
                src => src.MapFrom(src => src.memberDTO.LocationDTO)
            );
        }
    }
}
