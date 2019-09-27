using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesPingSimulator.Models
{
    public class Vehicledata : IComparable<Vehicledata>
    {
            public int ID { get; set; }
            public string VIN { get; set; }
            public string Regnr { get; set; }
            public int CustomerId { get; set; }
            public DateTime? LastSeen { get; set; }

        public int CompareTo(Vehicledata other)
        {
            if (other == null)
                return 1;
            if (this.ID != other.ID)
                return 1;
            return 0;
        }
        public override bool Equals(object x)
        {
            return this.CompareTo(x as Vehicledata) == 0;
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
