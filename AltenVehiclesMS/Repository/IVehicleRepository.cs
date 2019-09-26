using AltenVehiclesMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenVehiclesMS.Repository
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAllVehicle();
        IEnumerable<Vehicle> FilterVehicles(int? customerID, bool? isConnected);
        void PingVehicle(string VehicleId);
    }
}
