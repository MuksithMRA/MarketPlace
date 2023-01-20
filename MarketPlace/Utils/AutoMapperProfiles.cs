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
            CreateMap<UserDTO, User>();
            CreateMap<MemberDTO, Member>();
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
