using AspFirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspFirstApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly aspContext _context;

        public UsersController(aspContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
    }
}
