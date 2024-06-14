using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mile3;

namespace Mile3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User1Controller : ControllerBase
    {
        private readonly Mileston3task2Context _context;

        public User1Controller(Mileston3task2Context context)
        {
            _context = context;
        }

        // GET: api/User1
        [HttpGet("GetUsers")]
        public async Task<ActionResult<IEnumerable<User1>>> GetUser1s()
        {
          if (_context.User1s == null)
          {
              return NotFound();
          }
            return await _context.User1s.ToListAsync();
        }

        // GET: api/User1/5
        [HttpGet("GetUser/{id}")]
        public async Task<ActionResult<User1>> GetUser1(int id)
        {
          if (_context.User1s == null)
          {
              return NotFound();
          }
            var user1 = await _context.User1s.FindAsync(id);

            if (user1 == null)
            {
                return NotFound();
            }

            return user1;
        }

        // PUT: api/User1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("UpdateUser/{id}")]
        public async Task<IActionResult> PutUser1(int id, User1 user1)
        {
            if (id != user1.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User1Exists(id))
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

        // POST: api/User1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AddUser")]
        public async Task<ActionResult<User1>> PostUser1(User1 user1)
        {
          if (_context.User1s == null)
          {
              return Problem("Entity set 'Mileston3task2Context.User1s'  is null.");
          }
            _context.User1s.Add(user1);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (User1Exists(user1.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUser1", new { id = user1.UserId }, user1);
        }

        // DELETE: api/User1/5
        [HttpDelete("DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser1(int id)
        {
            if (_context.User1s == null)
            {
                return NotFound();
            }
            var user1 = await _context.User1s.FindAsync(id);
            if (user1 == null)
            {
                return NotFound();
            }

            _context.User1s.Remove(user1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool User1Exists(int id)
        {
            return (_context.User1s?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
