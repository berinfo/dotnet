using AutoMapper;
using dotnet.Dtos.Character;
using dotnet.Dtos.Skill;
using dotnet.Dtos.Weapon;
using dotnet.Models;

namespace dotnet
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}