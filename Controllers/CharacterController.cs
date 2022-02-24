using Microsoft.AspNetCore.Mvc;
using dotnet.Models;
using System.Collections.Generic;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Name = "Sam"}
        };
        [HttpGet("GetAll")]

        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
        [HttpGet]

        public ActionResult<Character> GetSignle()
        {
            return Ok(characters[0]);
        }

    }
}