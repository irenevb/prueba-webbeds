using PruebaWebbeds.Infrastructure;
using PruebaWebbeds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWebbeds.Services
{
    public class HotelListService: IHotelListService
    {
        private IHotelListRepository iOffer;
        public HotelListService(IHotelListRepository i)
        {
            iOffer = i;
        }
        public Task<List<Offer>> getAvailability(int nights, int id, string code)
        {
            Task<List<Offer>> offers = iOffer.getAvailability(nights, id, code); // coge toda la disponibilidad según los parámetros
            foreach (var i in offers.Result) // por cada una de las ofertas disponibles
            {
                for (int j = 0; j < i.rates.Length; j++) // de cada hotel, mira cada una de sus tarifas
                {
                    if (i.rates[j].rateType== "PerNight") // si se trata de tipo "PerNight" debe multiplicar el valor por el nº de noches
                    {
                        i.rates[j].value = i.rates[j].value * nights;
                    }
                }
            }
            return offers;
        }
    }
}