using Microsoft.AspNetCore.Mvc;
using PentaNest.Emlak.Api.Services;

namespace PentaNest.Emlak.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DanismanlarController : ControllerBase
    {
        private readonly DataService _dataService;

        public DanismanlarController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.Danismanlar);
        }

        [HttpGet("{url}")]
        public IActionResult GetByUrl(string url)
        {
            var danisman = _dataService.Danismanlar.FirstOrDefault(d => d.Url.Equals(url, StringComparison.OrdinalIgnoreCase));
            return danisman == null ? NotFound(new { error = "Danışman bulunamadı", url }) : Ok(danisman);
        }

        [HttpGet("{url}/ilanlar")]
        public IActionResult GetPropertiesByDanisman(string url)
        {
            var danisman = _dataService.Danismanlar.FirstOrDefault(d => d.Url.Equals(url, StringComparison.OrdinalIgnoreCase));
            if (danisman == null)
            {
                return NotFound(new { error = "Danışman bulunamadı", url });
            }
            return Ok(danisman.Properties);
        }
    }
}