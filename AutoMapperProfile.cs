using AutoMapper;
using dotnet.Dtos.Character;
using dotnet.Models;

namespace dotnet
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
        }
    }
}