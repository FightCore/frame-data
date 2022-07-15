using FightCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace FightCore.Api.Controllers
{
    [Route("characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        /// <summary>
        /// Gets all characters.
        /// </summary>
        /// <response code="200">Returns all characters.</response>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAll());
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
