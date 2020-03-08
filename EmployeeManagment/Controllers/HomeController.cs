using EmployeeManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employees)
        {
            _employeeRepository = employees;
        }
        public string Index() 
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            
            //PASSING DATA BY ViewData
            ViewData["Employee"] = model;
            ViewData["PageTitleVD"] = "ViewData Title";

            //PASSING BY ViewBag
            ViewBag.Employee = model;
            ViewBag.PageTitleVB = "ViewBag Title";

            return View(model);
        }
    }
}
