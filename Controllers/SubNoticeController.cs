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
    public class SubNoticeController : ControllerBase
    {
        private readonly BshbDbContext _context;

        public SubNoticeController(BshbDbContext context)
        {
            _context = context;
        }

        // GET: api/SubNotice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubNotice>>> GetSubNotices()
        {
            return await _context.SubNotices.ToListAsync();
        }

        // GET: api/SubNotice/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubNotice>> GetSubNotice(int id)
        {
            var subNotice = await _context.SubNotices.FindAsync(id);

            if (subNotice == null)
            {
                return NotFound();
            }

            return subNotice;
        }

        // PUT: api/SubNotice/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubNotice(int id, SubNotice subNotice)
        {
            if (id != subNotice.Id)
            {
                return BadRequest();
            }

            subNotice.UpdatedOn = DateTime.Now;
            _context.Entry(subNotice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubNoticeExists(id))
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

        // POST: api/SubNotice
        [HttpPost]
        public async Task<ActionResult<SubNotice>> PostSubNotice(SubNotice subNotice)
        {
            subNotice.CreatedOn = DateTime.Now;
            subNotice.UpdatedOn = DateTime.Now;
            _context.SubNotices.Add(subNotice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubNotice", new { id = subNotice.Id }, subNotice);
        }

        // DELETE: api/SubNotice/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubNotice(int id)
        {
            var subNotice = await _context.SubNotices.FindAsync(id);
            if (subNotice == null)
            {
                return NotFound();
            }

            _context.SubNotices.Remove(subNotice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubNoticeExists(int id)
        {
            return _context.SubNotices.Any(e => e.Id == id);
        }
    }
}
