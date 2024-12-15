using CQRS_Mediator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Data
{
    public class DataAccess :IDataAccess
    {
        private List<EmployeeModel> _employees = new(); // C# 9 syntax.

        public DataAccess()
        {
            _employees.Add(new EmployeeModel { Id = 1, FirstName = "Praveen", LastName = "Raveendran Pillai" });
            _employees.Add(new EmployeeModel { Id = 2, FirstName = "James", LastName = "Roger" });
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }

        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName = firstName, LastName = lastName };
            newEmployee.Id = _employees.Max(x => x.Id) + 1;
            return newEmployee;
        }
    }
}
