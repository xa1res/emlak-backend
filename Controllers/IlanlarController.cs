using Microsoft.AspNetCore.Mvc;
using PentaNest.Emlak.Api.Models;
using PentaNest.Emlak.Api.Services;
using System.Globalization;

namespace PentaNest.Emlak.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IlanlarController : ControllerBase
    {
        private readonly DataService _dataService;

        public IlanlarController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.AllProperties);
        }

        [HttpGet("search")]
        public IActionResult Search(
            [FromQuery] string? q,
            [FromQuery] int? minPrice,
            [FromQuery] int? maxPrice,
            [FromQuery] string? durum,
            [FromQuery] string? emlakTipi,
            [FromQuery] string? location,
            [FromQuery] string? odaSayisi,
            [FromQuery] string? emlakci,
            [FromQuery] string? danismanUrl,
            [FromQuery] string sortBy = "default",
            [FromQuery] string sortOrder = "asc",
            [FromQuery] int page = 1,
            [FromQuery] int limit = 20)
        {
            var result = _dataService.AllProperties.AsEnumerable();
            var culture = new CultureInfo("tr-TR");

            // ... Filtreleme, sıralama ve sayfalama mantığı buraya eklenecektir ...

            var total = result.Count();
            var limitNum = Math.Clamp(limit, 1, 100);
            var pageNum = Math.Max(page, 1);
            var totalPages = (int)Math.Ceiling((double)total / limitNum);
            var items = result.Skip((pageNum - 1) * limitNum).Take(limitNum);

            return Ok(new SearchResult
            {
                Meta = new Meta
                {
                    Page = pageNum,
                    Limit = limitNum,
                    Total = total,
                    TotalPages = totalPages
                },
                Data = items
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var ilan = _dataService.AllProperties.FirstOrDefault(p => p.Id == id);
            return ilan == null ? NotFound(new { error = "İlan bulunamadı", id }) : Ok(ilan);
        }
    }
}