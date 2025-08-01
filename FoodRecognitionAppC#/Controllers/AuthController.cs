using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using FoodRecognitionAppC_.Data;

namespace FoodRecognitionAppC_.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private ApplicationDbContext _context;
        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public IActionResult Register()
        {
            return Ok("OK");
        }
    }
}
