using Ghazal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ghazal.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GhazalContext _context;

        public CategoryController(GhazalContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            List<Category> categoryList = _context.Categories.ToList();
            return View("Index", categoryList);
        }
    }
}