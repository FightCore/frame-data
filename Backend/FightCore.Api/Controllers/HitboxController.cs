using Microsoft.AspNetCore.Mvc;

namespace FightCore.Api.Controllers
{
    [Route("hitboxes")]
    [ApiController]
    public class HitboxController : ControllerBase
    {
        /// <summary>
        /// Gets a specific hitbox based on its id.
        /// </summary>
        /// <param name="id">The id of the hitbox to get.</param>
        /// <response code="200">The hitbox was found and returned.</response>
        /// <response code="404">The hitbox was not found.</response>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Gets all hitboxes for the specified move.
        /// </summary>
        /// <param name="moveId">The id of the move to get the hitboxes for.</param>
        /// <response code="200">The move found and the hitboxes were returned.</response>
        /// <response code="404">The move was not found.</response>
        [HttpGet("/moves/{moveId:int}/hitboxes")]
        public async Task<IActionResult> GetHitboxesForMove(int moveId)
        {
            return Ok();
        }
    }
}
