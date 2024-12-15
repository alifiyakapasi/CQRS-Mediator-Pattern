using CQRS_Mediator.Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Queries
{
    public record GetEmployeeListQuery(): IRequest<List<EmployeeModel>>;

}
