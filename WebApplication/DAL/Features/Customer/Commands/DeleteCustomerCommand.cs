using DataModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Features.Commands
{
    public class DeleteCustomerCommand: IRequest<Customer>
    {
        public DeleteCustomerCommand(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; }
    }
}
