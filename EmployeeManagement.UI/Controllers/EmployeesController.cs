using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.BLL.Contracts;
using EmployeeManagement.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.UI.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeBLL _bll;

        public EmployeesController(IEmployeeBLL bll)
        {
            _bll = bll ?? throw new ArgumentNullException(nameof(bll));
        }

        public IActionResult Index()
        {
            var employees = _bll.GetAll();
            return View(employees);
        }

        public IActionResult GetEmployeeById(int id = 2)
        {
            var employee = _bll.GetEmployeeById(id);
            return View(employee);
        }

        public IActionResult SearchEmployees()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchEmployees(Employee search)
        {
            var searchResults = _bll.SearchEmployees(search);
            return View(searchResults);
        }

        [HttpGet]
        public IActionResult SaveEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveEmployee(Employee details)
        {
            var saveResult = _bll.SaveEmployee(details);
            if(saveResult == true)
            {
                //Let us see what to do with this successful operation
                return View("EmployeeCreationSuccess");
            }
            else
            {
                //saveResult = false means something went wrong, so display the view.
                return View();
            }
        }
    }
}
