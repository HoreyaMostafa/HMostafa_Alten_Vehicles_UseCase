using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenVehiclesMS.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string VIN { get; set; }
        public string Regnr { get; set; }
        public int CustomerId { get; set; }

        public DateTime? LastSeen { get; set; }

        public bool IsConnected { get { return LastSeen.HasValue && LastSeen < DateTime.Now.AddMinutes(-1) ? true : false; } }
    } 
}
