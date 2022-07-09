using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using template_csharp_blog.Models;

namespace template_csharp_blog.Controllers
{
    public class PlatformController : Controller
    {
        public BlogContext db { get; set; }
        public PlatformController(BlogContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Platforms.ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Platforms = new SelectList(db.Platforms.ToList(), "Id", "Name");
            return View(new Platform());
        }

        [HttpPost]
        public IActionResult Create(Platform model)
        {
            db.Platforms.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(db.Platforms.Find(id)); 
        }
        public IActionResult Update(int id)
        {
            ViewBag.Platforms = new SelectList(db.Platforms.ToList(), "Id", "Name");
            return View(db.Platforms.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Platform model)
        {
            db.Platforms.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
           Platform platform = db.Platforms.Find(id);
            return View(platform);
        }
        [HttpPost]
        public IActionResult Delete(Platform model)
        {
            db.Platforms.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
