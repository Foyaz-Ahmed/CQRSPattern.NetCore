using DAL.Repository.IRepository;
using DataModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Features.Queries
{
    public class GetAllCustomerQuery: IRequest<List<Customer>>
    {
        //public class GetAllCustomerHandler : IRequestHandler<GetAllCustomerQuery, List<Customer>>
        //{
        //    private readonly ICustomerRepository _customer;
        //    public GetAllCustomerHandler(ICustomerRepository customer)
        //    {
        //        _customer = customer;
        //    }
        //    public Task<List<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        //    {
        //        return Task.Run(() =>
        //        {
        //            return _customer.GetCustomerList();
        //        });
        //    }
        //}
    }
}
