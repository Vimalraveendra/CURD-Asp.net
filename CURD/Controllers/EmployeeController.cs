using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURD.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CURD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Repository.AllEmployees);
        }

        // HTTP GET VERSION
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            Repository.Create(employee);
            return View("Thanks",employee);
        }

        public IActionResult Update(string empname)
        {
            Employee employee = Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee employee, string empname)
        {
            Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Age = employee.Age;
            Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Salary = employee.Salary;
            Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Department = employee.Department;
            Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Sex = employee.Sex;
            Repository.AllEmployees.Where(e => e.Name == empname).FirstOrDefault().Name = employee.Name;

            return RedirectToAction("Index");
        }
    }
}
