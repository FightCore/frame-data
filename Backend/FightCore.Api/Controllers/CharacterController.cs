using FightCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FightCore.Api.Controllers
{
    [Route("characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        /// <summary>
        /// Gets all characters.
        /// </summary>
        /// <response code="200">Returns all characters.</response>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        /// <summary>
        /// Gets a single character based on its id.
        /// </summary>
        /// <response code="200">Returns all characters.</response>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCharacter(int id)
        {
            var character = await _characterService.GetById(id);

            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }
    }
}
