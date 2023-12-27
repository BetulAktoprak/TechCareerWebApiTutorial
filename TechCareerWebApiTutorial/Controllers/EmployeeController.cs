using Microsoft.AspNetCore.Mvc;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public EmployeeController()
        {
            _context = new TechCareerDbContext();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult EmployeePost(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return StatusCode(201, employee);
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            var employees = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employees == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(employees);
            _context.SaveChanges();
            return Ok(employees);
        }
        [HttpPut("{id}")]
        public IActionResult EmployeeUpdate(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }
            var employees = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (employees == null)
            {
                return NotFound();
            }
            employees.FirstName = employee.FirstName;
            employees.LastName = employee.LastName;
            employees.Address = employee.Address;
            employees.BirthDate = employee.BirthDate;
            employees.City = employee.City;

            _context.SaveChanges();
            return StatusCode(201, employees);
        }
    }
}
