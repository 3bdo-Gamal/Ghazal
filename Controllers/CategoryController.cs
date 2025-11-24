using Ghazal.Models;
using Microsoft.AspNetCore.Mvc;


namespace Ghazal.Controllers
{
    public class CategoryController : Controller
    {
        GhazalContext context=new GhazalContext();
        public IActionResult Index()
        {
            List<Category> categoryList= context.Categories.ToList();
            return View("index",categoryList);
        }
    }
}
