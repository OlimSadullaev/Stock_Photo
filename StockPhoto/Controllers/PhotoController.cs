using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockPhoto.Data;
using StockPhoto.Entities;
using StockPhoto.Services;
using System.Reflection.PortableExecutable;

namespace StockPhoto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly StockPhotoDbContext _context;
        private readonly IAltPhotoService  _pService;

        public PhotoController(StockPhotoDbContext context, IAltPhotoService photoService)
        {
            _context = context;
            _pService = photoService;

        }

        /*[HttpGet("id")]

        public async Task<ActionResult<List<AltPhoto>>> GetPhotoById(int id)
        {
            var characters = await _context.Photos
                .Where(c => c.Id == id)
                .ToListAsync();


            if (characters.Count < 0)
                return BadRequest($"You do not have {id} id");
            else
                return Ok(characters);
        }*/


        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostAsync([FromRoute] int id)
        {
            var photo = await _pService.GetPhotoByIdAsync(id);

            if(photo == default)
            {
                return NotFound();
            }

            
            
            return Ok(new
            {
                Id = photo.Id,
                Name = photo.Name,
                Link = photo.Link,
                Origional_Size = photo.Original_Size,
                Date_Of_Creation = photo.Date_Of_Creation,
                Author = photo.Author,
                Cost = photo.Cost,
                Num_of_Sales = photo.Num_of_Sales,
                Photo_Rating = photo.Photo_Rating,
            }); 
            
        }
    }
}
