using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerApi.Models;

namespace CustomerApi.Controllers
{
    [Route("api/CustomerController")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return customerRepository.ReadCustomers();

        }

        [HttpGet("{id}", Name = "GetCustomer")]
        public IActionResult GetById(long id)
        {
            var item = customerRepository.ReadCustomer(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Customer item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            customerRepository.Create(item);

            return CreatedAtRoute("GetCustomer", new { id = item.CustomerId }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var customer = customerRepository.ReadCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }

            customerRepository.Delete(id);
            return new NoContentResult();
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Customer item)
        {
            if (item == null || item.CustomerId != id)
            {
                return BadRequest();
            }

            var customer = customerRepository.ReadCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }

            customer.FirstName = item.FirstName;
            customer.LastName = item.LastName;
            customer.Phone = item.Phone;
            customer.Email = item.Email;
            customer.Address = item.Address;
            customer.City = item.City;
            customer.State = item.State;
            customer.PostalAddress = item.PostalAddress;

            customerRepository.Update(customer);
            return new NoContentResult();
        }
    }
}
