using FightCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace FightCore.Api.Controllers
{
    [Route("moves")]
    [ApiController]
    public class MovesController : ControllerBase
    {
        private readonly IMoveService _moveService;

        public MovesController(IMoveService moveService)
        {
            _moveService = moveService;
        }

        /// <summary>
        /// Gets a move based on the provided <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The id of the move to get.</param>
        /// <response code="200">The move was found and returned.</response>
        /// <response code="404">The move was not found.</response>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMove(int id)
        {
            var move = await _moveService.GetById(id);

            if (move == null)
            {
                return NotFound();
            }

            return Ok(move);
        }

        /// <summary>
        /// Gets all moves for the specified character.
        /// </summary>
        /// <param name="characterId">The id of the character.</param>
        /// <response code="200">The character was found and returned.</response>
        /// <response code="404">The character was not found.</response>
        [HttpGet("/characters/{characterId:int}/moves")]
        public async Task<IActionResult> GetCharacterMoves(int characterId)
        {
            var moves = await _moveService.GetMovesByCharacter(characterId);

            if (!moves.Any())
            {
                return NotFound();
            }

            return Ok(moves);
        }

        /// <summary>
        /// Gets a specific moves for the specified character.
        /// </summary>
        /// <param name="characterId">The id of the character.</param>
        /// <param name="moveId">The id of the move.</param>
        /// <response code="200">The character and move was found and returned.</response>
        /// <response code="404">The character or move was not found.</response>
        [HttpGet("/characters/{characterId:int}/moves/{moveId:int}")]
        public async Task<IActionResult> GetCharacterMoves(int characterId, int moveId)
        {
            var move = await _moveService.GetMoveByCharacter(moveId, characterId);

            if (move == null)
            {
                return NotFound();
            }

            return Ok(move);
        }
    }
}
