using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        IEnumerable<Customer> ReadCustomers();
        Customer ReadCustomer(long customerId);
        void Delete(long CustomerId);
        void Update(Customer customer);
    }
}
