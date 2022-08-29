using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockPhoto.Data;
using StockPhoto.Entities;
using System.Reflection.PortableExecutable;

namespace StockPhoto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly StockPhotoDbContext _context;
        public PhotoController(StockPhotoDbContext context)
        {
            _context = context;
        }

        [HttpGet("id")]

        public async Task<ActionResult<List<AltPhoto>>> GetPhotoById(int id)
        {
            var characters = await _context.Photos
                .Where(c => c.Id == id)
                .ToListAsync();


            if (characters.Count < 0)
                return BadRequest($"You do not have {id} id");
            else
                return Ok(characters);
        }

        [HttpPost]
        public async Task<IActionResult>
    }
}
