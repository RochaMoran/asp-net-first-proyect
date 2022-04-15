using Microsoft.AspNetCore.Mvc;

namespace AspFirstApp.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
