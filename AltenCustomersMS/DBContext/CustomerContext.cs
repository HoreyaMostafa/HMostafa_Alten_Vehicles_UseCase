using AltenCustomersMS.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenCustomersMS.DBContext
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
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
                );


                 
        }
    }
}
