using FirstMVCDemo.Models;
using FirstMVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Details()
        {
            //Employee Basic Details
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Ben",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };
            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Barrie",
                State = "Ontario",
                Country = "Canada",
                Pin = "755019"
            };
            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };
            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }
    }
}