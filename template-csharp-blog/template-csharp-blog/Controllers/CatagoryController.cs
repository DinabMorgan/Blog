using Microsoft.AspNetCore.Mvc;
using template_csharp_blog.Models;

namespace template_csharp_blog.Controllers
{
    public class CatagoryController : Controller

    {
        public BlogContext db { get; set; }
        public CatagoryController(BlogContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Catagories.ToList());
        }
    }
}
