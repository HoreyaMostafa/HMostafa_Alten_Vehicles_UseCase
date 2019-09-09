using AltenCustomersMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenCustomersMS.Repository
{
    public interface ICustomerRepository
    {
       IEnumerable<Customer> GetAllCustomers();
       Customer GetCustomerByID(int CustomerId);
    }
}
