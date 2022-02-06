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
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customer;
        public DeleteCustomerHandler(ICustomerRepository customer)
        {
            _customer = customer;
        }
        public async Task<Customer> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customer.DeleteCustomer(request.Customer);
        }
    }
}
