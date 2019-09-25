using AltenCustomersMS.Models;
using AltenCustomersMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltenCustomers.xUnitTests
{
    public class CustomerRepositoryFake: ICustomerRepository
    {
        private readonly IEnumerable<Customer> customers;

        public CustomerRepositoryFake()
        {
            customers = new List<Customer>()
            {
                new Customer
                {
                    Id = 1,
                    Name = "Kalles Grustransporter AB",
                    Address = "Cementvägen 8, 111 11 Södertälje",
                    //Vehicles = new List<Vehicle>()
                },
                new Customer
                {
                    Id = 2,
                    Name = "Johans Bulk AB",
                    Address = "Balkvägen 12, 222 22 Stockholm",
                    // Vehicles = new List<Vehicle>()
                },
                new Customer
                {
                    Id = 3,
                    Name = "Haralds Värdetransporter AB",
                    Address = "Budgetvägen 1, 333 33 Uppsala",
                    //Vehicles = new List<Vehicle>()
                }
            };
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public Customer GetCustomerByID(int CustomerId)
        {
            throw new NotImplementedException();
        }
    }
}
