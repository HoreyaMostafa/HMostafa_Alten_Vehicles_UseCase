using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltenVehiclesMS.Models
{
    public class vehicle
    {
        public int ID { get; set; }
        public string VIN { get; set; }
        public string Regnr { get; set; }
        public int CustomerId { get; set; }

        public string GetStatus()
        {
            return "Connected";
   
        }

    }
}