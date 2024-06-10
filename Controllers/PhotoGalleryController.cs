using bshbbackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bshbbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoGalleryController : ControllerBase
    {
        private readonly BshbDbContext _context;

        public PhotoGalleryController(BshbDbContext context)
        {
            _context = context;
        }

        // GET: api/PhotoGallery
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhotoGallery>>> GetPhotoGallery()
        {
            return await _context.PhotoGallerys.ToListAsync();
        }

        // GET: api/PhotoGallery/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<PhotoGallery>> GetPhotoById(int id)
        {
            var photo = await _context.PhotoGallerys.FindAsync(id);
            if (photo == null)
            {
                return NotFound();
            }
            return Ok(photo);
        }

        // POST: api/PhotoGallery
        [HttpPost]
        public async Task<ActionResult<PhotoGallery>> PostPhoto(PhotoGallery photo)
        {
            _context.PhotoGallerys.Add(photo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPhotoById), new { id = photo.Id }, photo);
        }

        // PUT: api/PhotoGallery/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoto(int id, PhotoGallery photo)
        {
            if (id != photo.Id)
            {
                return BadRequest();
            }

            _context.Entry(photo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/PhotoGallery/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoto(int id)
        {
            var photo = await _context.PhotoGallerys.FindAsync(id);
            if (photo == null)
            {
                return NotFound();
            }

            _context.PhotoGallerys.Remove(photo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhotoExists(int id)
        {
            return _context.PhotoGallerys.Any(e => e.Id == id);
        }
    }
}
