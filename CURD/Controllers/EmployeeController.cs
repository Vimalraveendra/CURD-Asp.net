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
            return View();
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
    }
}
