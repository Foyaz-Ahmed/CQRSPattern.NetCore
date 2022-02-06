using DataModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Features.Queries
{
    public class GetSingleCustomerQuery: IRequest<Customer>
    {
        public GetSingleCustomerQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
