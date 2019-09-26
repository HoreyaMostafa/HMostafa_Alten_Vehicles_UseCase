using AltenVehiclesMS.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenVehiclesMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var vehicle = _vehicleRepository.GetAllVehicle();
            return new OkObjectResult(vehicle);
        }

        [HttpGet("customer/{customerId}", Name = "Get")]
        public IActionResult GetByCustomer(int CustomerId)
        {
            var vehicles = _vehicleRepository.FilterVehicles(CustomerId, null);
            return new OkObjectResult(vehicles);
        }

        [HttpGet("{isConnceted}")]
        public IActionResult GetByConnectivityStatus(bool isConnceted)
        {
            var vehicles = _vehicleRepository.FilterVehicles(null, isConnceted);
            return new OkObjectResult(vehicles);
        }

        [HttpPost("{vehicleId}")]
        public IActionResult KeepAlive(int vehicleId)
        {
            _vehicleRepository.PingVehicle(vehicleId);
            return new OkResult();
        }

    }
}
