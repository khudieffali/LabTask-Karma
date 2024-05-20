using LabTask_Karma.Models;
using LabTask_Karma.Models.DataAccess;
using LabTask_Karma.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LabTask_Karma.Controllers
{
    public class BlogController(KarmaDbContext context) : Controller
    {
        private readonly KarmaDbContext _context=context;
        public IActionResult Index()
        {
            List<Blog> blogs = [.. _context.Blogs];
            BlogVM vm = new() { BlogList = blogs };
            return View(vm);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> Create(Blog blog)
		{
            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();
			return RedirectToAction("index");
		}
	}
}
