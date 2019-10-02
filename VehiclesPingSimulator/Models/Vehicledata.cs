using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesPingSimulator.Models
{
    public class Vehicledata 
    {
            public int ID { get; set; }
            public string VIN { get; set; }
            public string Regnr { get; set; }
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public DateTime? LastSeen { get; set; }

    }
}
