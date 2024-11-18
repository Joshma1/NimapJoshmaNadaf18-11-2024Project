using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nimap.Models;


namespace Nimap.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // public CategoryController(ILogger<CategoryController> logger)
        // {
        //     _logger = logger;
        // }
        
        [HttpGet("")]
        [HttpGet("Index")]
        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            return View(categories);
        }
         [HttpGet("Category")]
        public IActionResult Category()
        {
            return RedirectToAction("Index");
        }

        [HttpGet("Create")]
        public IActionResult Create() 
        {
           return View();
        }

            [HttpPost("Create")]
            [ValidateAntiForgeryToken]
        public IActionResult Create(Category category) 
        {
            if (ModelState.IsValid) 
            {
              _dbContext.Categories.Add(category);
              _dbContext.SaveChanges();
              return RedirectToAction("Index");
            }
            return View(category);
        }

         [HttpGet("Edit/{id}")]
        public IActionResult Edit(int id) 
        {
           var category = _dbContext.Categories.Find(id);
           if (category == null)
           {
            return NotFound();
           }
           return View(category);
        }

            [HttpPost("Edit/{id}")]
             [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category) 
        {
            if (ModelState.IsValid) 
            
            {
                _dbContext.Categories.Update(category);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

             [HttpGet("Delete/{id}")]
             [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var category = _dbContext.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
         // POST: /Category/Delete

         
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _dbContext.Categories.Find(id);
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}