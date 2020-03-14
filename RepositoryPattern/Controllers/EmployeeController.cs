using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Data.Repository;
using RepositoryPattern.ViewModels;

namespace RepositoryPattern.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public IActionResult Index()
        {
            var employees = _employeeRepo.GetAll().Select(employee => new EmployeeIndexViewModel() 
            {
                Id=employee.Id,
                FirstName=employee.FirstName,
                LastName=employee.LastName,
                MiddleName=employee.MiddleName,
                DOB=employee.DOB,
                Gender=employee.Gender,
                Email=employee.Email,
                Phone=employee.Phone,
                Address=employee.Address,
                City=employee.City
            });

            return View(employees);
        }
    }
}