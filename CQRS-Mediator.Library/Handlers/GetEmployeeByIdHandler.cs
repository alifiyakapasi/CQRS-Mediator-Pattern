using CQRS_Mediator.Library.Data;
using CQRS_Mediator.Library.Models;
using CQRS_Mediator.Library.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeModel>
    {
        private readonly IMediator mediator;
        public GetEmployeeByIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<EmployeeModel> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employees = await mediator.Send(new GetEmployeeListQuery());
            var searchEmployeeId = employees.FirstOrDefault(x=> x.Id == request.Id);
            return searchEmployeeId;
        }
    }
}
