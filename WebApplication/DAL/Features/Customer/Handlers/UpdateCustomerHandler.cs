using DAL.Features.Commands;
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
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customer;
        public UpdateCustomerHandler(ICustomerRepository customer)
        {
            _customer = customer;
        }
        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {

            return await _customer.UpdateCustomer(request.Customer);
        }
    }
}
