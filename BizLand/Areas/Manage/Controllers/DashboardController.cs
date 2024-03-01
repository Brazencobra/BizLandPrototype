using BizLand.DAL;
using BizLand.Models;
using Microsoft.AspNetCore.Mvc;

namespace BizLand.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashboardController : Controller
    {
        readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
