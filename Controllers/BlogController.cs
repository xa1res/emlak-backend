using Microsoft.AspNetCore.Mvc;
using PentaNest.Emlak.Api.Services;

namespace PentaNest.Emlak.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly DataService _dataService;

        public BlogController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.BlogPosts);
        }

        [HttpGet("{slug}")]
        public IActionResult GetBySlug(string slug)
        {
            var blogPost = _dataService.BlogPosts.FirstOrDefault(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
            return blogPost == null ? NotFound(new { error = "Blog yazısı bulunamadı", slug }) : Ok(blogPost);
        }
    }
}