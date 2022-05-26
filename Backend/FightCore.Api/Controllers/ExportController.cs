using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FightCore.Api.Controllers
{
    [Route("exports")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        /// <summary>
        /// Exports the character to the specified format and returns the generated file.
        /// </summary>
        /// <param name="id">The id of the character.</param>
        /// <response code="200">The generated file.</response>
        /// <response code="404">The character was not found.</response>
        /// <response code="500">An error occurred while exporting the character.</response>
        /// <response code="400">The format is not supported.</response>
        [HttpGet("/characters/{id:int}/export")]
        public async Task<IActionResult> GetExportForCharacter(int id)
        {
            return Ok();
        }
    }
}
