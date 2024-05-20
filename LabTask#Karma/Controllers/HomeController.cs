using LabTask_Karma.Models;
using LabTask_Karma.Models.DataAccess;
using LabTask_Karma.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LabTask_Karma.Controllers
{
    public class HomeController(KarmaDbContext? context) : Controller
    {
		private readonly KarmaDbContext _context = context;
        public IActionResult Index()
        {
           List<Product> productList= [.. _context.Products];
            HomeVM vm = new() {ProductList=productList };   
            return View(vm);
        }
    }
}
