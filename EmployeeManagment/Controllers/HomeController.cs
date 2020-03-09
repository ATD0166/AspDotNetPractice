using EmployeeManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagment.ViewModels;

namespace EmployeeManagment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employees)
        {
            _employeeRepository = employees;
        }        

        public ViewResult Index()
        {
            IEnumerable<Employee> model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            if (id == 0) { id = 1; }

            HomeDetailsViewModel model = new HomeDetailsViewModel
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "ViewModel Method"
            };            
            
            //PASSING DATA BY ViewData
            ViewData["Employee"] = model.Employee;
            ViewData["PageTitleVD"] = "ViewData Method";

            //PASSING BY ViewBag
            ViewBag.Employee = model.Employee;
            ViewBag.PageTitleVB = "ViewBag Method";

            //PASSING BY STRONGLY TYPE AND VIEWMODEL
            
            return View(model);
        }
    }
}
