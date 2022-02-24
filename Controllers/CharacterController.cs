using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using System.Collections.Generic;
using dotnet.Services.CharacterService;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Dtos.Character;

namespace dotnet.Controllers
{
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
            return Ok(await _characterService.GetAllCharacters());
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

    }
}