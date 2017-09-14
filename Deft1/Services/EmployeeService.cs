using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Deft1.Models;

namespace Deft1.Services
{
    public class EmployeeService : IEmployeeService
    {
        private DeftDB db = new DeftDB();

        public List<EmployeeViewModel> GetAll()
        {
            var employeeList = db.Employees.ToList();
            return employeeList.Select(emp => EmpDto(emp)).ToList();
        }

        private static EmployeeViewModel EmpDto(Employee emp)
        {
            return new EmployeeViewModel
            {
                EmployeeId = emp.EmployeeId,
                FirstName  = emp.FirstName,
                LastName   = emp.LastName,
                Email      = emp.Email,
                Phone      = emp.Phone,
                HireDate   = emp.HireDate,
                Position   = emp.Position,
                Location   = emp.Location
            };
        }
    }
}