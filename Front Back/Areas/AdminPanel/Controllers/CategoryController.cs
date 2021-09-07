using Front_Back.DAL;
using Front_Back.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_Back.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        public AppDbContext _context { get; }
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories);
        }
        //[HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            bool hasCategory = _context.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (hasCategory)
            {
                ModelState.AddModelError("Name","This category already exist");
                return View();
            }
             _context.Categories.AddAsync(category);
             _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
