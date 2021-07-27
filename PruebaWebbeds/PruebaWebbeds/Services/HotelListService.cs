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
        private const int N_Nights = 5; // calcula las noches a pincho porque la url no varía, pero se debería coger de los parámetros pasados por url
        public HotelListService(IHotelListRepository i)
        {
            iOffer = i;
        }
        public Task<List<Offer>> getAvailability()
        {
            Task<List<Offer>> offers = iOffer.getAvailability();
            foreach (var i in offers.Result)
            {
                for (int j = 0; j < i.rates.Length; j++)
                {
                    if (i.rates[j].rateType== "PerNight")
                    {
                        i.rates[j].value = i.rates[j].value * N_Nights;
                    }
                }
            }
            return offers;
        }
    }
}