using DAL.Features.Queries;
using DAL.Repository.IRepository;
using DataModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Features.Handlers
{
    public class GetSingleCustomerHandler : IRequestHandler<GetSingleCustomerQuery, Customer>
    {
        private readonly ICustomerRepository _customer;
       
        public GetSingleCustomerHandler(ICustomerRepository customer)
        {
            _customer = customer;
        }


        public async  Task<Customer> Handle(GetSingleCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _customer.GetCustomerById(request.Id);

        }

        //another process

        //public Task<Customer> Handle(GetSingleCustomerQuery request, CancellationToken cancellationToken)
        //{
        //    return Task.Run(() =>
        //    {
        //        return _customer.GetCustomerById(request.Id);
        //    });
        //}
    }
}
