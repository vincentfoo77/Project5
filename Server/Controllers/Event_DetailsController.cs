using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project5.Server.Data;
using Project5.Shared.Domain;

namespace Project5.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Event_DetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Event_DetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Event_Details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event_Details>>> GetEvent_details()
        {
            return await _context.Event_details.ToListAsync();
        }

        // GET: api/Event_Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event_Details>> GetEvent_Details(int id)
        {
            var event_Details = await _context.Event_details.FindAsync(id);

            if (event_Details == null)
            {
                return NotFound();
            }

            return event_Details;
        }

        // PUT: api/Event_Details/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent_Details(int id, Event_Details event_Details)
        {
            if (id != event_Details.Id)
            {
                return BadRequest();
            }

            _context.Entry(event_Details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Event_DetailsExists(id))
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

        // POST: api/Event_Details
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Event_Details>> PostEvent_Details(Event_Details event_Details)
        {
            _context.Event_details.Add(event_Details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvent_Details", new { id = event_Details.Id }, event_Details);
        }

        // DELETE: api/Event_Details/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent_Details(int id)
        {
            var event_Details = await _context.Event_details.FindAsync(id);
            if (event_Details == null)
            {
                return NotFound();
            }

            _context.Event_details.Remove(event_Details);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Event_DetailsExists(int id)
        {
            return _context.Event_details.Any(e => e.Id == id);
        }
    }
}
