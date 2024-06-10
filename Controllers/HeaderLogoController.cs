using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bshbbackend.Models;

namespace bshbbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderLogoController : ControllerBase
    {
        private readonly BshbDbContext _context;

        public HeaderLogoController(BshbDbContext context)
        {
            _context = context;
        }

        // GET: api/HeaderLogo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeaderLogo>>> GetHeaderLogos()
        {
            return await _context.HeaderLogos.ToListAsync();
        }

        // GET: api/HeaderLogo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HeaderLogo>> GetHeaderLogo(int id)
        {
            var headerLogo = await _context.HeaderLogos.FindAsync(id);

            if (headerLogo == null)
            {
                return NotFound();
            }

            return headerLogo;
        }

        // PUT: api/HeaderLogo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHeaderLogo(int id, HeaderLogo headerLogo)
        {
            if (id != headerLogo.id)
            {
                return BadRequest();
            }

            _context.Entry(headerLogo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeaderLogoExists(id))
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

        //// POST: api/HeaderLogo
        //[HttpPost]
        //public async Task<ActionResult<HeaderLogo>> PostHeaderLogo(HeaderLogo headerLogo)
        //{
        //    _context.HeaderLogos.Add(headerLogo);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetHeaderLogo", new { id = headerLogo.id }, headerLogo);
        //}
        // POST: api/HeaderLogo
        [HttpPost]
        public async Task<ActionResult<HeaderLogo>> PostHeaderLogo([FromForm] ModelDto.HeaderLogoDto headerLogoDto)
        {
            var headerLogo = new HeaderLogo
            {
                url1 = headerLogoDto.url1,
                Img1 = headerLogoDto.Img1 != null ? ConvertToBytes(headerLogoDto.Img1) : null,
                url2 = headerLogoDto.url2,
                Img2 = headerLogoDto.Img2 != null ? ConvertToBytes(headerLogoDto.Img2) : null,
                url3 = headerLogoDto.url3,
                Img3 = headerLogoDto.Img3 != null ? ConvertToBytes(headerLogoDto.Img3) : null,
                url4 = headerLogoDto.url4,
                Img4 = headerLogoDto.Img4 != null ? ConvertToBytes(headerLogoDto.Img4) : null,
                url5 = headerLogoDto.url5,
                Img15 = headerLogoDto.Img15 != null ? ConvertToBytes(headerLogoDto.Img15) : null,
                url6 = headerLogoDto.url6,
                Img6 = headerLogoDto.Img6 != null ? ConvertToBytes(headerLogoDto.Img6) : null,
                url7 = headerLogoDto.url7,
                Img7 = headerLogoDto.Img7 != null ? ConvertToBytes(headerLogoDto.Img7) : null,
                url8 = headerLogoDto.url8,
                Img8 = headerLogoDto.Img8 != null ? ConvertToBytes(headerLogoDto.Img8) : null,
                url9 = headerLogoDto.url9,
                Img9 = headerLogoDto.Img9 != null ? ConvertToBytes(headerLogoDto.Img9) : null,
            };

            _context.HeaderLogos.Add(headerLogo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHeaderLogo", new { id = headerLogo.id }, headerLogo);
        }

        private byte[] ConvertToBytes(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }


        // DELETE: api/HeaderLogo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHeaderLogo(int id)
        {
            var headerLogo = await _context.HeaderLogos.FindAsync(id);
            if (headerLogo == null)
            {
                return NotFound();
            }

            _context.HeaderLogos.Remove(headerLogo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HeaderLogoExists(int id)
        {
            return _context.HeaderLogos.Any(e => e.id == id);
        }
    }
}

