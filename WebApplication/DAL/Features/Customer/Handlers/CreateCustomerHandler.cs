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
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customer;
        public CreateCustomerHandler(ICustomerRepository customer)
        {
            _customer = customer;
        }
        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customer.CreateCustomer(request.Customer);
        }
    }
}
