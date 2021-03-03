using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JoggingApi.Models;

namespace JoggingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogEntriesController : ControllerBase
    {
        private readonly JogContext _context;

        public JogEntriesController(JogContext context)
        {
            _context = context;
        }

        // GET: api/JogEntries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JogEntry>>> GetJogEntries()
        {
            return await _context.JogEntries.ToListAsync();
        }

        // GET: api/JogEntries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JogEntry>> GetJogEntry(long id)
        {
            var jogEntry = await _context.JogEntries.FindAsync(id);

            if (jogEntry == null)
            {
                return NotFound();
            }

            return jogEntry;
        }

        // PUT: api/JogEntries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJogEntry(long id, JogEntry jogEntry)
        {
            if (id != jogEntry.Id)
            {
                return BadRequest();
            }

            _context.Entry(jogEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JogEntryExists(id))
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

        // POST: api/JogEntries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JogEntry>> PostJogEntry(JogEntry jogEntry)
        {
            _context.JogEntries.Add(jogEntry);
            jogEntry.Date = DateTime.Now.Date;
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJogEntry", new { id = jogEntry.Id }, jogEntry);
        }

        // DELETE: api/JogEntries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJogEntry(long id)
        {
            var jogEntry = await _context.JogEntries.FindAsync(id);
            if (jogEntry == null)
            {
                return NotFound();
            }

            _context.JogEntries.Remove(jogEntry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JogEntryExists(long id)
        {
            return _context.JogEntries.Any(e => e.Id == id);
        }
    }
}
