using Microsoft.AspNetCore.Mvc;
using template_csharp_blog.Models;

namespace template_csharp_blog.Controllers
{
    public class PostController : Controller
    {
        public BlogContext db { get; set; }
        public PostController(BlogContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
