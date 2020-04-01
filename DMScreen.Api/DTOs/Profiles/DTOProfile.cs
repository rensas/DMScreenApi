using AutoMapper;
using DMScreen.Core.Models;

namespace DMScreen.Api.DTOs.Profiles
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<PlayerCharacter, PlayerCharacterDomain>().ReverseMap();
        }
    }
}