using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWebbeds.Models
{
    public class Offer
    {
        // Se crea la clase oferta para poder almacenar las diferentes tarifas que se asocian con un hotel
        public Hotel hotel { get; set; }
        public Rate[] rates { get; set; }
    }
}
