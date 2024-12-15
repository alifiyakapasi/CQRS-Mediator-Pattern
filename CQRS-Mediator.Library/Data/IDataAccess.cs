using CQRS_Mediator.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Data
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();

        EmployeeModel AddEmployee(string firstname, string lastname);
    }
}
