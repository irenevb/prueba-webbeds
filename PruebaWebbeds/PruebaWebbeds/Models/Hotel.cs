using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWebbeds.Models
{
    public class Hotel
    {
        public int propertyID { get; set; }
        public string name { get; set; }
        public int geoId { get; set; }
        public int rating { get; set; }

        public Hotel(int propertyId, string name, int geoId, int rating)
        {
            this.propertyID = propertyId;
            this.name = name;
            this.geoId = geoId;
            this.rating = rating;
        }
    }
}
