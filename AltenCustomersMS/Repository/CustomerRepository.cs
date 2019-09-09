using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltenCustomersMS.DBContext;
using AltenCustomersMS.Models;

namespace AltenCustomersMS.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _dbContext;

        public CustomerRepository(CustomerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Customer GetCustomerByID(int CustomerId)
        {
            return _dbContext.Customers.Find(CustomerId);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }

    }
}
