using CQRS_Mediator.Library.Commands;
using CQRS_Mediator.Library.Data;
using CQRS_Mediator.Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, EmployeeModel>
    {
        private readonly IDataAccess dataAccess;

        public AddEmployeeHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Task<EmployeeModel> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.AddEmployee(request.FirstName, request.LastName));
        }
    }
}
