using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using System.Collections.Generic;
using dotnet.Services.CharacterService;
using System.Linq;

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

        public ActionResult<List<Character>> Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }
        // adds id parameter to route
        [HttpGet("{id}")]
        public ActionResult<Character> GetSignle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }
        // adds new character post
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {

            return Ok(_characterService.AddCharacter(newCharacter));
        }

    }
}