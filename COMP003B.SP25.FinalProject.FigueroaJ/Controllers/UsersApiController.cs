using Microsoft.AspNetCore.Mvc;
using COMP003B.SP25.FinalProject.FigueroaJ.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP25.FinalProject.FigueroaJ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersApiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        // GET
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User updatedUser)
        {
            if (id != updatedUser.UserId)
                return BadRequest();

            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            user.Username = updatedUser.Username;
            user.Email = updatedUser.Email;
            user.Password = updatedUser.Password;
            user.Bio = updatedUser.Bio;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
