using AltenVehiclesMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenVehiclesMS.DBContexts
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options)
        {
        }

        public DbSet<vehicle> Vehicles { get; set; }
        public DbSet<VehiclePingHistory> VehiclePingHistory { get; set; }

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
