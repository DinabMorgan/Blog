﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Create()
        {
            ViewBag.Catagories = new SelectList(db.Catagories.ToList(), "Id", "Name");
            return View(new Catagory());
        }

        [HttpPost]
        public IActionResult Create(Catagory model)
        {
            db.Catagories.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(db.Catagories.Find(id));
        }
        public IActionResult Update(int id)
        {
            ViewBag.Catagories = new SelectList(db.Catagories.ToList(), "Id", "Name");
            return View(db.Catagories.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Catagory model)
        {
            db.Catagories.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Catagory catagory = db.Catagories.Find(id);
            return View(catagory);
        }
        [HttpPost]
        public IActionResult Delete(Catagory model)
        {
            db.Catagories.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

