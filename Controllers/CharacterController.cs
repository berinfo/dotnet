using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using System.Collections.Generic;
using System.Linq;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };
        [HttpGet("GetAll")]

        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
        // adds id parameter to route
        [HttpGet("{id}")]
        public ActionResult<Character> GetSignle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
        // adds new character post
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }

    }
}