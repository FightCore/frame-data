using AutoMapper;
using FightCore.Api.DataTransferObjects.Exports.Full;
using FightCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using Newtonsoft.Json;

namespace FightCore.Api.Controllers
{
    [Route("exports")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;
        private readonly IDistributedCache _cache;
        private const string _fullExportCacheKey = "full-export";

        public ExportController(ICharacterService characterService, IMapper mapper, IDistributedCache cache)
        {
            _characterService = characterService;
            _mapper = mapper;
            _cache = cache;
        }

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

        [HttpGet("full")]
        public async Task<IActionResult> GetAllFrameData()
        {
            var cachedFullExport = await _cache.GetAsync(_fullExportCacheKey);

            if (cachedFullExport != null)
            {
                return Ok(JsonConvert.DeserializeObject<List<FullExportCharacter>>(
                    Encoding.UTF8.GetString(cachedFullExport)));
            }

            var export = await _characterService.ExportAll();

            var convertedDtos = _mapper.Map<List<FullExportCharacter>>(export);

            await _cache.SetAsync(_fullExportCacheKey,
                Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(convertedDtos)));

            return Ok(convertedDtos);
        }
    }
}
