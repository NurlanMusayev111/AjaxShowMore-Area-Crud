using FiorelloSlider_OnetoMany.Data;
using FiorelloSlider_OnetoMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloSlider_OnetoMany.Areas.Admin.Controllers
{
    [Area("admin")]

    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;   
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            return View();
        }
    }
}
