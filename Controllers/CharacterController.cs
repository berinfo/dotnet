using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using System.Collections.Generic;
using dotnet.Services.CharacterService;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Dtos.Character;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace dotnet.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        // using underscore instead this.
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]

        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            int id = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _characterService.GetAllCharacters(id));
        }
        // adds id parameter to route
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSignle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }
        // adds new character post
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {

            return Ok(await _characterService.AddCharacter(newCharacter));
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);
            if (response.data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Delete(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if (response.data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}