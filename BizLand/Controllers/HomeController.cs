using BizLand.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BizLand.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;            
        }
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
    }
}
