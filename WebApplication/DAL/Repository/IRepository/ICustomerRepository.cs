using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.IRepository
{
    public interface ICustomerRepository
    {
            List<Customer> GetCustomerList();
            Task<Customer> GetCustomerById(int id);
            Task<Customer> CreateCustomer(Customer customer);
            Task<Customer> UpdateCustomer(Customer customer);
            Task<Customer> DeleteCustomer(Customer customer);
        
    }
}
