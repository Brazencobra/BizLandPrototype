using BizLand.DAL;
using BizLand.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace BizLand.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class EmployeeController : Controller
    {
        readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid) return View();
            _context.Employees.Add(employee);
            _context.SaveChanges(); 
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? Id)
        {
            if (Id is null) return BadRequest();
            Employee employee = _context.Employees.Find(Id);
            if (employee is null) return NotFound();
            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(int? Id, Employee model)
        {
            if(!ModelState.IsValid) return View();
            if (Id is null) return BadRequest();
            Employee employee = _context.Employees.Find(Id);
            if (employee is null) return NotFound();
            employee.Name = model.Name;
            employee.Surname = model.Surname;
            employee.Position = model.Position;
            employee.ImageUrl = model.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id) 
        {
            if (id is null) return BadRequest();
            Employee employee = _context.Employees.Find(id);
            if (employee is null) return NotFound();
            _context.Employees.Remove(employee);
            _context.SaveChanges(); 
            return RedirectToAction(nameof(Index));
        }
    }
}
