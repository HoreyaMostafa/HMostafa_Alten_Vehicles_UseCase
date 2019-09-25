using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltenVehiclesMS.DBContexts;
using AltenVehiclesMS.Models;

namespace AltenVehiclesMS.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleContext _dbContext;
        public VehicleRepository(VehicleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicleByID(int VehicleId)
        {
            throw new NotImplementedException();
        }
    }
}
