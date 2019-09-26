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

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    ID = 1,
                    VIN = " YS2R4X20005399401",
                    Regnr = "ABC123",
                    CustomerId = 1,
                    LastSeen = null,
                },
                new Vehicle
                {
                    ID = 2,
                    VIN = "VLUR4X20009093588",
                    Regnr = "DEF456",
                    CustomerId = 1,
                    LastSeen = null,
                },
                new Vehicle
                {
                    ID = 3,
                    VIN = "VLUR4X20009048066",
                    Regnr = "GHI789",
                    CustomerId = 1,
                    LastSeen = null,
                },
                new Vehicle
                {
                    ID = 4,
                    VIN = "YS2R4X20005388011",
                    Regnr = "JKL012",
                    CustomerId = 2,
                    LastSeen = null,
                },
                new Vehicle
                {
                    ID = 5,
                    VIN = "YS2R4X20005387949",
                    Regnr = "MNO345",
                    CustomerId = 2,
                    LastSeen = null,
                },
                new Vehicle
                {
                    ID = 6,
                    VIN = "VLUR4X20009048066",
                    Regnr = "PQR678",
                    CustomerId = 3,
                    LastSeen = null,
                },
                new Vehicle
                {
                    ID = 7,
                    VIN = "YS2R4X20005387055",
                    Regnr = "STU901",
                    CustomerId = 3,
                    LastSeen = null,
                }
              );
        }
    }
}