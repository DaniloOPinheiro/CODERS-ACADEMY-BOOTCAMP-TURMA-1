using Microsoft.AspNetCore.Mvc;

namespace CodersAcademyJRider.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlbuns()
        {
            return Ok(new
            {
                Message = "API com template JetBrains Rider"
            });
        }
    }
}