using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace QubixCinema.Business.Services
{
    public class CustomerService
    {
        private readonly QubixCinemaContext _context;

        public CustomerService(QubixCinemaContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = _context.Customers.FirstOrDefault(m => m.CustomerId
            == customer.CustomerId);

            if (existingCustomer != null)
            {
                existingCustomer.CustomerFirstName = customer.CustomerFirstName;
                existingCustomer.CustomerLastName = customer.CustomerLastName;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.Email = customer.Email;
                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId
            == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

    }
}
