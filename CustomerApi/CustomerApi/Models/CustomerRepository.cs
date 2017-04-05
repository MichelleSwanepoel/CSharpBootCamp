using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext context;

        public CustomerRepository(CustomerContext _context)
        {
            context = _context;
        }

        public void Create(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public IEnumerable<Customer> ReadCustomers()
        {
            return context.Customers.ToList();
        }

        public Customer ReadCustomer(long customerId)
        {
            return context.Customers.FirstOrDefault(t => t.CustomerId == customerId);
        }

        public void Delete(long customerId)
        {
            var entity = context.Customers.First(t => t.CustomerId == customerId);
            context.Customers.Remove(entity);
            context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
    }
}
