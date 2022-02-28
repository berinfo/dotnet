using System.Threading.Tasks;
using dotnet.Dtos.Character;
using dotnet.Dtos.Weapon;
using dotnet.Models;

namespace dotnet.Services.CharacterService.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}