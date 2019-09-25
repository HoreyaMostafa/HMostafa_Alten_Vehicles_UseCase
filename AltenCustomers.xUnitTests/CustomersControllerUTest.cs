using AltenCustomersMS.Controllers;
using AltenCustomersMS.Models;
using AltenCustomersMS.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace AltenCustomers.xUnitTests
{
    public class CustomersControllerUTest
    {
        ICustomerRepository customerRepository;
        CustomerController customerController;

        public CustomersControllerUTest()
        {
            customerRepository = new CustomerRepositoryFake();
            customerController = new CustomerController(customerRepository);
        }

        [Fact]
        public void Getall_ReturnsOkResult()
        {
            // Act
            var okResult = customerController.Get();

            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void Get_ReturnsAllItems()
        {
            // Act
            var okResult = customerController.Get() as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Customer>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

    }
}
