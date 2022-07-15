using FightCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace FightCore.Api.Controllers
{
    [Route("hitboxes")]
    [ApiController]
    public class HitboxController : ControllerBase
    {
        private readonly IHitboxService _hitboxService;

        public HitboxController(IHitboxService hitboxService)
        {
            _hitboxService = hitboxService;
        }

        /// <summary>
        /// Gets a specific hitbox based on its id.
        /// </summary>
        /// <param name="id">The id of the hitbox to get.</param>
        /// <response code="200">The hitbox was found and returned.</response>
        /// <response code="404">The hitbox was not found.</response>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var hitbox = await _hitboxService.GetById(id);

            if (hitbox == null)
            {
                return NotFound();
            }

            return Ok(hitbox);
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
            var hitboxes = await _hitboxService.GetHitboxesByMove(moveId);

            if (!hitboxes.Any())
            {
                return NotFound();
            }

            return Ok(hitboxes);
        }
    }
}
