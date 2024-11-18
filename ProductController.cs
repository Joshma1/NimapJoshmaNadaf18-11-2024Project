using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Nimap.Models;


namespace Nimap.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
       // private ApplicationDbContext db = new ApplicationDbContext();

        // public ProductController(ILogger<ProductController> logger)
        // {
        //     _logger = logger;
        // }
        private readonly ApplicationDbContext _dbContext;

         // Constructor for Dependency Injection
        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("")]
        [HttpGet("Index")]
        public IActionResult Index(string search, int categoryId = 0, int page = 1, int pageSize = 10) 
        {
        var totalProducts = _dbContext.Products.Count();
        
        var products = _dbContext.Products
                         .Include(p => p.Category)
                         .OrderBy(p => p.ProductId)
                         .Skip((page - 1) * pageSize)
                         .Take(pageSize)
                         .ToList();

        ViewBag.Page = page;
        ViewBag.PageSize = pageSize;
        ViewBag.TotalCount = totalProducts;

        return View(products);
        }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");

        // GET: /Product/Create

        [HttpGet("Product")]
        public IActionResult Product()
        {
            return RedirectToAction("Index");
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewBag.Categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_dbContext.Categories, "CategoryId", "CategoryName");
            return View();
        }

          // POST: /Product/Create
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
             ViewBag.Categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_dbContext.Categories, "CategoryId", "CategoryName");
            return View(product);
        }

        // GET: /Product/Edit/5
        [HttpGet("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var product = _dbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        
        // POST: /Product/Edit
        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Products.Update(product);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
        // GET: /Product/Delete/5
        [HttpGet("Delete/{id}")]
public IActionResult Delete(int id)
{
    var product = _dbContext.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == id);
    if (product == null)
    {
        return NotFound(); // Returns a 404 if the product is not found
    }
    return View(product); // Returns a confirmation view
}

// POST: /Product/Delete/5
[HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public IActionResult DeleteConfirmed(int id)
{
    var product = _dbContext.Products.Find(id);
    if (product == null)
    {
        return NotFound();
    }

    _dbContext.Products.Remove(product);
    _dbContext.SaveChanges();
    return RedirectToAction("Index");
}


    }
}
