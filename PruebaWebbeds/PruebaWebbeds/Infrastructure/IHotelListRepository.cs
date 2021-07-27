using PruebaWebbeds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWebbeds.Infrastructure
{
    public interface IHotelListRepository
    {
        Task<List<Offer>> getAvailability(int nights, int id, string code);
    }
}