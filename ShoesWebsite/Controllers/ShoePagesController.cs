using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoesWebsite.Data;
using ShoesWebsite.Models;

namespace ShoesWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoePagesController : ControllerBase
    {
        private readonly ShoesWebsiteContext _context;

        public ShoePagesController(ShoesWebsiteContext context)
        {
            _context = context;
        }

        // GET: api/ShoePages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShoePage>>> GetShoePage()
        {
            return await _context.ShoePage.ToListAsync();
        }

        // GET: api/ShoePages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShoePage>> GetShoePage(int id)
        {
            var shoePage = await _context.ShoePage.FindAsync(id);

            if (shoePage == null)
            {
                return NotFound();
            }

            return shoePage;
        }

        // PUT: api/ShoePages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoePage(int id, ShoePage shoePage)
        {
            if (id != shoePage.ID)
            {
                return BadRequest();
            }

            _context.Entry(shoePage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoePageExists(id))
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

        // POST: api/ShoePages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShoePage>> PostShoePage(ShoePage shoePage)
        {
            _context.ShoePage.Add(shoePage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoePage", new { id = shoePage.ID }, shoePage);
        }

        // DELETE: api/ShoePages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShoePage(int id)
        {
            var shoePage = await _context.ShoePage.FindAsync(id);
            if (shoePage == null)
            {
                return NotFound();
            }

            _context.ShoePage.Remove(shoePage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShoePageExists(int id)
        {
            return _context.ShoePage.Any(e => e.ID == id);
        }
    }
}
