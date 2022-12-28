using AutoMapper;
using FightCore.Api.DataTransferObjects.Characters;
using FightCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace FightCore.Api.Controllers
{
    [Route("characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;

        public CharacterController(ICharacterService characterService, IMapper mapper)
        {
            _characterService = characterService;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets all characters.
        /// </summary>
        /// <response code="200">Returns all characters.</response>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<BasicCharacter>>(await _characterService.GetAll()));
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

            return Ok(_mapper.Map<CharacterWithMoves>(character));
        }
    }
}
