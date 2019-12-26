using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PaySlipGenerator.Models;
using PaySlipGenerator.Services;

namespace PaySlipGenerator.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeeService.GetAll().Select(employee => new EmployeeIndexViewModel
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                ImageUrl = employee.ImageUrl,
                FullName = employee.FullName,
                Gender = employee.Gender,
                Designation = employee.Designation,
                City = employee.City,
                DateJoined = employee.DateJoined
            }).ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}