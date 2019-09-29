using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltenCustomersMS.Models;
using AltenCustomersMS.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltenCustomersMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        // GET: api/Customer
        [HttpGet]
        public IActionResult Get()
        {
             var customers = _customerRepository.GetAllCustomers();
             return new OkObjectResult(customers);
            //return new OkObjectResult(new List<Customer>());
        }


        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var customer = _customerRepository.GetCustomerByID(id);
            return new OkObjectResult(customer);
        }

    
    }
}
