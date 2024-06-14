using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Milestone3API;

namespace Milestone3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Task3Controller : ControllerBase
    {
        private readonly Milestone3Context _context;

        public Task3Controller(Milestone3Context context)
        {
            _context = context;
        }

        // GET: api/Task3
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Task3>>> GetTask3s()
        {
          if (_context.Task3s == null)
          {
              return NotFound();
          }
            return await _context.Task3s.ToListAsync();
        }

        // GET: api/Task3/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Task3>> GetTask3(int id)
        {
          if (_context.Task3s == null)
          {
              return NotFound();
          }
            var task3 = await _context.Task3s.FindAsync(id);

            if (task3 == null)
            {
                return NotFound();
            }

            return task3;
        }

        // PUT: api/Task3/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask3(int id, Task3 task3)
        {
            if (id != task3.Id)
            {
                return BadRequest();
            }

            _context.Entry(task3).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Task3Exists(id))
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

        // POST: api/Task3
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Task3>> PostTask3(Task3 task3)
        {
          if (_context.Task3s == null)
          {
              return Problem("Entity set 'Milestone3Context.Task3s'  is null.");
          }
            _context.Task3s.Add(task3);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Task3Exists(task3.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTask3", new { id = task3.Id }, task3);
        }

        // DELETE: api/Task3/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask3(int id)
        {
            if (_context.Task3s == null)
            {
                return NotFound();
            }
            var task3 = await _context.Task3s.FindAsync(id);
            if (task3 == null)
            {
                return NotFound();
            }

            _context.Task3s.Remove(task3);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Task3Exists(int id)
        {
            return (_context.Task3s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
