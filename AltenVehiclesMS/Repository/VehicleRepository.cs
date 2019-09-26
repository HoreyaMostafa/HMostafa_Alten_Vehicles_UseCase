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
            return _dbContext.Vehicles.ToList();
        }

        public IEnumerable<Vehicle> FilterVehicles(int? customerID, bool? isConnected)
        {
            if (customerID.HasValue)
                return _dbContext.Vehicles.AsEnumerable<Vehicle>().Where(x => x.CustomerId == customerID);
            else if (isConnected.HasValue)
                return _dbContext.Vehicles.AsEnumerable<Vehicle>().Where(x => x.IsConnected == isConnected);
            else
                return new List<Vehicle>();
        }

        public void PingVehicle(int VehicleId)
        {
            throw new NotImplementedException();
        }
        
    }
}
