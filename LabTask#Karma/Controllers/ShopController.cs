using LabTask_Karma.Models;
using LabTask_Karma.Models.DataAccess;
using LabTask_Karma.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LabTask_Karma.Controllers
{
    public class ShopController(KarmaDbContext? context) : Controller
    {
        private readonly KarmaDbContext _context=context;

		public IActionResult Index()
        {
            List<Category> categories = [.. _context.Categories];
            List<Product> products = [.. _context.Products];
            ShopVM vm = new() { CategoryList=categories,ProductList=products};
            return View(vm);
        }
    }
}
